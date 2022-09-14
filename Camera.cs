using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApplication1
{
    public partial class Camera : MetroFramework.Forms.MetroForm
    {
        private AForge.Video.DirectShow.VideoCaptureDevice cam;
        public Camera()
        {
            InitializeComponent();
            AForge.Video.DirectShow.FilterInfoCollection filtro;
            filtro = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);
            cam = new AForge.Video.DirectShow.VideoCaptureDevice(filtro[0].MonikerString);
            cam.NewFrame += (s, e) => pictureBox1.Image = (Bitmap)e.Frame.Clone();
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            cam.Start();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
            {
                cam.SignalToStop();
                cam = null;
            }
        }
    }
}
