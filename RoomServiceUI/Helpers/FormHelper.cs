using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomServiceUI.Helpers
{
    internal static class FormHelper
    {
        internal static void ShowMessage(Label label, string type)
        {

        }

        internal static void HideMessage(Label label)
        {

        }

        internal static void OpenUserControl()
        {

        }

        internal static void EnterTextBox(string text, TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            if (textBox.Text == text)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        internal static void LeaveTextBox(string text, TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                textBox.Text = text;
                textBox.ForeColor = Color.Gray;
            }
        }

        internal static void ShowMessage(Label label, string message, string type)
        {
            label.Visible = true;
            label.Text = message;

            if (type == "Error")            
                label.ForeColor = Color.Red;
            
            if (type == "Mes")            
                label.ForeColor = Color.Lime;
            
        }

        internal static bool ClearIsSure(string list)
        {
            string message = $"Are You Sure You Want to Clear { list }?";
            string title = "Clear";
            DialogResult a = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (a == DialogResult.Yes)
            {
                message = $"Are You Absolutely Sure You Want to Clear { list }, this irriversible action?";
                title = "Clear";
                a = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (a == DialogResult.Yes)                
                    return true;                
                else
                    return false;
            }
            else
                return false;
        }

        internal static bool RemoveIsSure(string name)
        {
            string message = $"Are You Sure You Want to Remove { name }?";
            string title = "Remove";
            DialogResult a = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (a == DialogResult.Yes)            
                return true;            
            else
                return false;
        }
    }
}
