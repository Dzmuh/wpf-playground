using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//Добавляем ссылки на нужные нам пространства имён
using Linq2Sql;
using System.Xml.Linq;

namespace WpfGuiProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XElement xml;
        public MainWindow()
        {
            InitializeComponent();
            xml = XElement.Load(@"..\..\XMLFile1.xml");
        }

        //В этом методе заключается вся логика по указанию источника данных, которые следует отображать в окне
        private void Change_DataSource(object sender, RoutedEventArgs e)
        {
            if (rbDatabase.IsChecked == true)
            {
                treeStructure.ItemsSource = new MyTestDbDataContext().Categories.Where(n => n.ParrentCategoryId == null);
            }
            else
            {
                treeStructure.ItemsSource = xml.Elements("Category");
            }
        }
    }
}