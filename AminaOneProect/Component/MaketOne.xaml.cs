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

namespace AminaOneProect.Component
{
    /// <summary>
    /// Логика взаимодействия для MaketOne.xaml
    /// </summary>
    public partial class MaketOne : UserControl
    {
        Product product;
        public MaketOne(Product _product)
        {
            InitializeComponent();
            this.product = _product;
            if (App.IsAdmin == false)
            {

                EditBtn.Visibility = Visibility.Hidden;
                DeleteBtn.Visibility = Visibility.Hidden;
            }
            TitleTb.Text = product.Title;
            EvalutionTb.Text = product.OverrideFeedback;
            NewPrice.Text = product.CostDiscount;
            OldPrice.Visibility = product.CostVisibility;


        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new PartialClassComponent("Редактирование услуги", new AddEditProductPartial(product)));
        }
        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (product.Feedback.Count != 0)
            {
                MessageBox.Show("ЗАПРЕЩЕНО УДАЛЯТЬ ");
            }
            else
            {
                App.db.Product.Remove(product);
                App.db.SaveChanges();
            }
        }


    }

}

