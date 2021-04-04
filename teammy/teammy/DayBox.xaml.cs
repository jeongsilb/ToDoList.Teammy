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

namespace teammy
{
    /// <summary>
    /// Interaction logic for DayBox.xaml
    /// </summary>
    public partial class DayBox : UserControl
    {
        public static readonly DependencyProperty DateProperty = DependencyProperty.Register("Date", typeof(int?), typeof(DayBox));

        public static readonly DependencyProperty TaskProperty = DependencyProperty.Register("Task", typeof(string), typeof(DayBox));

        public static readonly DependencyProperty StatusProperty = DependencyProperty.Register("Status", typeof(string), typeof(DayBox));

        public int? Date
        {
            get => (int?)GetValue(DateProperty);
            set => SetValue(DateProperty, value);
        }
        public string Task
        {
            get => GetValue(TaskProperty).ToString();
            set => SetValue(TaskProperty, value);
        }
        public string Status
        {
            get => GetValue(StatusProperty).ToString();
            set => SetValue(StatusProperty, value);
        }

        public DayBox()
        {
            InitializeComponent();
        }
    }
}
