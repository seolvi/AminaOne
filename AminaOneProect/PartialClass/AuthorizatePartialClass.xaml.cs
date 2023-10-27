﻿using AminaOneProect.Base;
using AminaOneProect.Component.PartialClass;
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

namespace AminaOneProect.PartialClass
{
    /// <summary>
    /// Логика взаимодействия для AuthorizatePartialClass.xaml
    /// </summary>
    public partial class AuthorizatePartialClass : Page
    {
        public AuthorizatePartialClass()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.RemoveBackEntry();
            App.IsAdmin = false;
            if (PasswordPb.Password == "0000")
            {
                App.IsAdmin = true;
                MessageBox.Show("Вы вошли как администратор!");
            }
             Navigation.NextPage(new PartialClassComponent("Список услуг", new MaketList()));
        }
    }
}
