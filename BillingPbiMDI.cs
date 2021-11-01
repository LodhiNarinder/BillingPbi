using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingPbi
{
    public partial class BillingPbiMDI : Form
    {
        private int childFormNumber = 0;
        SQLConnection clsCon = new SQLConnection();
        public BillingPbiMDI()
        {
            InitializeComponent();
        }

        private void ShowCustomerMst(object sender, EventArgs e)
        {
            CustomerMst CustMst = new CustomerMst();
            CustMst.MdiParent = this;
            CustMst.Text = "CustomerMst " ;
            CustMst.WindowState = FormWindowState.Minimized;
            CustMst.Dock = DockStyle.Fill;
            CustMst.Show();
            CustMst.WindowState = FormWindowState.Maximized;

        }
        private void ShowActMst(object sender, EventArgs e)
        {
            ActMst ActMst = new ActMst();
            ActMst.MdiParent = this;
            ActMst.Text = "AccountMst ";
            ActMst.WindowState = FormWindowState.Minimized;
            ActMst.Dock = DockStyle.Fill;
            ActMst.Show();
            ActMst.WindowState = FormWindowState.Maximized;
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //toolStripDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss");
        }

        private void BillingPbiMDI_Load(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BillProcess BillProcess = new BillProcess();
            BillProcess.MdiParent = this;
            BillProcess.Text = "BillProcess ";
            BillProcess.WindowState = FormWindowState.Minimized;
            BillProcess.Dock = DockStyle.Fill;
            BillProcess.Show();
            BillProcess.WindowState = FormWindowState.Maximized;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            VoucherMst VoucherMst = new VoucherMst();
            VoucherMst.MdiParent = this;
            VoucherMst.Text = "VoucherMst ";
            VoucherMst.WindowState = FormWindowState.Minimized;
            VoucherMst.Dock = DockStyle.Fill;
            VoucherMst.Show();
            VoucherMst.WindowState = FormWindowState.Maximized;

        }
    }
}
