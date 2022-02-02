﻿using System;
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

namespace Lab20.Pages
{
    /// <summary>
    /// Логика взаимодействия для CodePage.xaml
    /// </summary>
    public partial class CodePage : Page
    {
        public CodePage()
        {
            InitializeComponent();
            DGAnalyzer.ItemsSource = Manager.db.Service_rendered.ToList();
            CMBanalyzer.ItemsSource = Manager.db.Analyzers.ToList();
            CMBService.ItemsSource = Manager.db.servicesLabs.ToList();
        }
    }
}
