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

namespace teammy
{
    /// <summary>
    /// Interaction logic for AssigneeEllipse.xaml
    /// </summary>
    public partial class AssigneeEllipse : UserControl
    {
        public static readonly DependencyProperty BackColorProperty = DependencyProperty.Register("BackColor", typeof(Color), typeof(AssigneeEllipse));
        public static readonly DependencyProperty UserProperty = DependencyProperty.Register("User", typeof(string), typeof(AssigneeEllipse));

        public string User
        {
            get { return (string)GetValue(UserProperty); }
            set { SetValue(UserProperty, value); }
        }
        public Color BackColor
        {
            get { return (Color)GetValue(BackColorProperty); }
            set { SetValue(BackColorProperty, value); }
        }
        public AssigneeEllipse()
        {
            InitializeComponent();
        }
    }
}
