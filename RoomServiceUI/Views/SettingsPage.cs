using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomServiceUI.Views
{
    public partial class SettingsPage : Form
    {
        #region Fields
        private static SettingsPage _instance;
        #endregion

        public SettingsPage()
        {
            InitializeComponent();
        }

        #region Properties
        public static SettingsPage Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new SettingsPage();

                return _instance;
            }
        }
        #endregion
    }
}
