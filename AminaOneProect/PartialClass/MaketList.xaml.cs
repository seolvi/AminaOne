using AminaOneProect;
using AminaOneProect.Base;
using AminaOneProect.PartialClass;
using System;
using System.Collections.Generic;
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

namespace AminaOneProect.Component.PartialClass
{
    /// <summary>
    /// Логика взаимодействия для MaketList.xaml
    /// </summary>
    public partial class MaketList  
    {
        public MaketList()
        {
            InitializeComponent();
            IEnumerable<Product> productSortList = App.db.Product;
            foreach (var product in productSortList)
            {
                MainWp.Children.Add(new MaketOne(product));
            }
        }
        private void refresh()
        {
            IEnumerable<Product> serviceSortList = App.db.Product;
            if (SortCb.SelectedIndex > 0)
            {
                if (SortCb.SelectedIndex == 1)
                {
                    serviceSortList = serviceSortList.OrderBy(x => x.CostDiscount);
                }
                else
                {
                    serviceSortList = serviceSortList.OrderByDescending(x => x.CostDiscount);
                }
            }
            if (FilterDiscountCb.SelectedIndex != 0)
            {
                if (FilterDiscountCb.SelectedIndex == 1)
                    serviceSortList = serviceSortList.Where(x => x.Discount >= 0 && x.Discount < 5);
                else if (FilterDiscountCb.SelectedIndex == 2)
                    serviceSortList = serviceSortList.Where(x => x.Discount >= 5 && x.Discount < 15);
                else if (FilterDiscountCb.SelectedIndex == 3)
                    serviceSortList = serviceSortList.Where(x => x.Discount >= 15 && x.Discount < 30);
                else if (FilterDiscountCb.SelectedIndex == 4)
                    serviceSortList = serviceSortList.Where(x => x.Discount >= 30 && x.Discount < 70);
                else if (FilterDiscountCb.SelectedIndex == 5)
                    serviceSortList = serviceSortList.Where(x => x.Discount >= 70 && x.Discount <= 100);

            }

            if (SearchTb.Text != null)
            {
                serviceSortList = serviceSortList.Where(x => x.Title.ToLower().Contains
                (SearchTb.Text.ToLower()) || x.Description.ToLower().Contains
                (SearchTb.Text.ToLower()));
            }
            CountDataTb.Text = serviceSortList.Count() + " из " + App.db.Product.Count();
            MainWp.Children.Clear();
            foreach (var Product in serviceSortList)
            {
                MainWp.Children.Add(new MaketOne (Product));
            }




        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            refresh();
        }

        private void FilterDiscountCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            refresh();
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            refresh();
        }

      private void AddBtn_Click(object sender, RoutedEventArgs e)
       {

         Navigation.NextPage(new PartialClassComponent("Добавление услуги", new AddEditProductPartial(new Product())));
       }
    }
}


