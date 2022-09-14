using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LoadingData : Form
    {
        public LoadingData()
        {
            InitializeComponent();
        }
        public Action Worker
        {
            get;
            set;
        }
        public LoadingData(Action worker)
        {
            InitializeComponent();
            if (Worker == null)

                Worker = worker;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
