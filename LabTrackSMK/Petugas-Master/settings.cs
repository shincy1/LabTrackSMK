using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTrackSMK.Petugas_Master
{
    public partial class settings : UserControl
    {
        public event EventHandler ButtonClicked;
        public settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnButtonClicked(EventArgs.Empty);
        }

        protected virtual void OnButtonClicked(EventArgs e)
        {
            // Pastikan event handler tidak null sebelum dipanggil
            ButtonClicked?.Invoke(this, e);
        }
    }
}
