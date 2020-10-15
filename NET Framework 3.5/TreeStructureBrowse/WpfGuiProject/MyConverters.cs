using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using Linq2Sql;
using System.Xml.Linq;

namespace WpfGuiProject
{
    //Конвертер для класса Category. Задача этого конвертера - извлечение вложенных элементов типа Category.
    public sealed class CategoryValueConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Category)
            {
                Category x = (Category) value;
                return (x).Categories.Where(n => n.ParrentCategoryId == x.CategoryId).OrderBy(n => n.CategoryName); 
            }
            else
            {
                return null;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    //Конвертер для класса XElement. Задача этого конвертера - извлечение вложенных элементов типа XElement, инкапсулирующих
    //в себе разделы Category.
    public sealed class XmlConverter :IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is XElement)
            {
                XElement x = (XElement)value;
                return x.Elements("Category");
            }
            else
            {
                return null;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}