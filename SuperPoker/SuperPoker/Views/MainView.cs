using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperPoker.Controler;

namespace SuperPoker.Views
{
    public partial class MainView : UserControl, IMainView
    {
        private MainControler controler;

        public MainView()
        {
            InitializeComponent();
            controler = new MainControler(this);
        }

        private void bServerSubmit_Click(object sender, EventArgs e)
        {
            controler.SolveServer();
        }

        public void SetOutput(string output)
        {
            tbOutput.Text = output;
        }

        private void bManualSubmit_Click(object sender, EventArgs e)
        {
            controler.ManualSolve(int.Parse(nudCard1.Text), int.Parse(nudCard2.Text), int.Parse(nudCard3.Text), int.Parse(nudCard4.Text));
        }
    }
}
