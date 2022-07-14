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

namespace WordleClone.Views.Controls
{
    /// <summary>
    /// Interaction logic for LetterItem.xaml
    /// </summary>
    public partial class LetterItem : UserControl
    {
        public string Letter
        {
            get { return (string)GetValue(LetterProperty); }
            set { SetValue(LetterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Letter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LetterProperty =
            DependencyProperty.Register("Letter", typeof(string), typeof(LetterItem), new PropertyMetadata(null));

        public LetterItem()
        {
            InitializeComponent();
        }
    }
}
