using MyMessageBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMessageBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBoxOK.Show("This is Ok Button Alert", "Alert", MessageBoxType.INFO);
        }

        private void btnYesNo_Click(object sender, EventArgs e)
        {
            MessageBoxYesNo.Show("This is Yes/No Button Alert", "Alert", MessageBoxType.INFO);
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            MessageBoxNotify.Show("This is Auto hide Alert", "Alert", MessageBoxType.INFO);
        }
    }
}
