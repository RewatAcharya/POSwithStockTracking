using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BandB
{
    public partial class MainForm : Form
    {
        Form1 form = new Form1();
        Sell sell = new Sell();
        History history = new History();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
            sell.Visible = false;
            history.Visible = false;

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            sell.ShowDialog();
            form.Visible = false;
            history.Visible = false;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            history.ShowDialog();
            form.Visible = false;
            sell.Visible = false;
        }
    }
}
