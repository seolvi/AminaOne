using AminaOneProect.Base;
using AminaOneProect.Component;
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

namespace AminaOneProect
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigation.mainWindow = this;

            Navigation.NextPage(new PartialClassComponent("Авторизация", new AuthorizatePartialClass()));
            //MyFrame.Navigate(new PartialClassComponent("",new AuthorizatePartialClass()));
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            
       
                Navigation.BackPage();
        }

        private void ExitBTN_Click(object sender, RoutedEventArgs e)
        {
             Navigation.ClearHistory();
             
        }
    }
}
