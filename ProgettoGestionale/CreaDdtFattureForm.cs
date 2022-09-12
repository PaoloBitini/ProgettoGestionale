using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoGestionale
{
    public partial class CreaDdtFattureForm : Form
    {
        private MainForm refer;
        private bool isDdt;
        public CreaDdtFattureForm(MainForm reference, bool ddt)
        {
            refer = reference;
            isDdt = ddt;

            InitializeComponent();

            if (isDdt)
            {
                Text = "Crea Ddt";
            }
            else
            {
                Text = "Crea Fattura";
            }
        }
    }
}
