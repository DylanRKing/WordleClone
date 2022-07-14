﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WordleClone.Classes
{
    public class RestrictedTextBox : TextBox
    {
        private static readonly Regex regex = new Regex("[^a-zA-Z]");

        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            if(regex.IsMatch(e.Text))
                e.Handled = true;
            base.OnPreviewTextInput(e);
        }
    }
}
