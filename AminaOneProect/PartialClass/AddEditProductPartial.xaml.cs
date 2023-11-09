using AminaOneProect.Base;
using AminaOneProect.Component.PartialClass;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AminaOneProect.PartialClass
{
    /// <summary>
    /// Логика взаимодействия для AddEditProductPartial.xaml
    /// </summary>
    /// 

    public partial class AddEditProductPartial : Page
    { 
       
        private Product product;
        public AddEditProductPartial(Product _product )
        {
            InitializeComponent();
            product = _product;
            this.DataContext = product;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

            App.db.Product.Add(product);
            App.db.SaveChanges();
            MessageBox.Show("Сохранено!");
            Navigation.NextPage(new PartialClassComponent("Список услуг", new MaketList()));
        }

        private void EditImageBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpg|*.jpg|*.jepg|*.jepg"
            };
            if (openFile.ShowDialog().GetValueOrDefault())
            {
                product.MainImage = File.ReadAllBytes(openFile.FileName);
                MainImage.Source = new BitmapImage(new Uri(openFile.FileName));
            }
        
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
