﻿using AminaOneProect.Base;
using AminaOneProect.Component;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AminaOneProect
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static HardwareShopAminaEntities db = new HardwareShopAminaEntities();
        public static bool IsAdmin = false;
    }
}
