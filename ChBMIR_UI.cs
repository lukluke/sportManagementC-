using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ChBMIR_UI : UserControl
    {
        public ChBMIR_UI()
        {
            InitializeComponent();
        }

        private void ChBMI_Click(object sender, EventArgs e)
        {
            bmI_UI1.Visible = true;
            bmR_UI1.Visible = false;
        }

        private void ChBMR_Click(object sender, EventArgs e)
        {
            bmR_UI1.Visible = true;
            bmI_UI1.Visible = false;
        }
    }
}
