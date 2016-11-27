using System;
using System.Windows.Forms;
using SuperPoker.Controler;

namespace SuperPoker.Views
{
    public partial class MainView : UserControl, IMainView
    {
        private readonly MainController controller;

        public MainView()
        {
            InitializeComponent();
            controller = new MainController(this);
        }

        private void bServerSubmit_Click(object sender, EventArgs e)
        {
            controller.SolveServer();
        }

        public void SetOutput(string output)
        {
            tbOutput.Text = output;
        }

        private void bManualSubmit_Click(object sender, EventArgs e)
        {
            controller.ManualSolve(int.Parse(nudCard1.Text), int.Parse(nudCard2.Text), int.Parse(nudCard3.Text), int.Parse(nudCard4.Text));
        }
    }
}
