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
using WordleClone.Models;

namespace WordleClone.Views.Controls
{
    /// <summary>
    /// Interaction logic for HistoryItem.xaml
    /// </summary>
    public partial class HistoryItem : UserControl
    {
        public Attempt Attempt
        {
            get { return (Attempt)GetValue(AttemptProperty); }
            set { SetValue(AttemptProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Attempt.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AttemptProperty =
            DependencyProperty.Register("Attempt", typeof(Attempt), typeof(HistoryItem), new PropertyMetadata(null, SetValues));

        private static void SetValues(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HistoryItem attempt = (HistoryItem)d;
            if (attempt != null)
                attempt.DataContext = attempt.Attempt;
        }

        public HistoryItem()
        {
            InitializeComponent();
        }
    }
}
