using AminaOneProect.Base;
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
        public MaketOne(Product product)
        {
            InitializeComponent();
            TitleTb.Text = product.Title;
            EvalutionTb.Text = product.OverrideFeedback;
            NewPrice.Text = product.CostDiscount;
            OldPrice.Visibility = product.CostVisibility;

        }
    }
}
