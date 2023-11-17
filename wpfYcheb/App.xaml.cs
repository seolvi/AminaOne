using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using wpfYcheb.Components;
using Application = System.Windows.Application;

namespace wpfYcheb
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static wpf_ychebEntities db = new wpf_ychebEntities();
    }
}
