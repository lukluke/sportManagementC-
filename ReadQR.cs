using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using ZXing;

namespace WindowsFormsApplication1
{
    public partial class ReadQR : MetroFramework.Forms.MetroForm
    {
        public ReadQR()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Imagen png|*.png",
                InitialDirectory = @"C:\Users\Gepar\Desktop\Codigos barra"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbgenerar.Image.Save(sfd.FileName);
            }
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Imagen png|*.png",
                InitialDirectory = @"C:\Users\Gepar\Desktop\Codigos barra"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbmostrararchivo.Image = Image.FromFile(ofd.FileName);
                BarcodeReader br = new BarcodeReader();
                string texto = br.Decode((Bitmap)pbmostrararchivo.Image).ToString();
                txtmostrar.Text = texto;
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(txtnombre.Text), 200, 200);
                pbgenerar.Image = bm;
            }
        }

    

        private void ReadQR_Load(object sender, EventArgs e)
        {
         
        }

    
    }
}
