using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Translator;
using System.Web;
using System.Net;
using System.Reflection;

namespace BillingPbi
{
    public partial class VoucherMst : Form
    {

        //Device communication declarations
        public Thread mWorker;
        AutoResetEvent mStop = new AutoResetEvent(false);

        //Data Declarations
        SQLConnection clsCon = new SQLConnection();
        //Data Declarations
        SQLConnection clsConsql = new SQLConnection();

        public VoucherMst()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wtrBillingDataSet.ActMst' table. You can move, or remove it, as needed.
            //this.actMstTableAdapter.Fill(this.wtrBillingDataSet.ActMst);
            fncLoadGridData();

        }
        private void fncLoadGridData()
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = clsConsql.getDatasetsql("SELECT  [id],[VmNo],[VmDate],[VmType],[VmAmtRO],[VmMonthYr] FROM [VuMst] WHERE [VmNo]>0 and [VmDate] between '" + From.Value.ToString("yyyy-MM-dd") + "' and '" + To.Value.ToString("yyyy-MM-dd") + "'");
                dataGridView1.DataMember = clsConsql.getDatasql().Tables[0].TableName;
                //this.dataGridView1.DefaultCellStyle.Font = new Font("AnmolKalmi", 8);
                //this.dataGridView1.Columns[5].DefaultCellStyle.Font = new Font("AnmolKalmi", 8);
                //this.dataGridView1.Columns[6].DefaultCellStyle.Font = new Font("AnmolKalmi", 8);
                //this.dataGridView1.Columns[7].DefaultCellStyle.Font = new Font("AnmolKalmi", 8);
                dataGridView1.Refresh();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;
                lblTotal.Text = dataGridView1.Rows.Count.ToString();

                advancedDataGridViewSearchToolBar1.SetColumns(dataGridView1.Columns);
                //fncUpdateDisplay(clsConsql.getDatasql().Tables[0].Rows[0][0].ToString(), clsCon.getData().Tables[0].Rows[0][1].ToString(), clsCon.getData().Tables[0].Rows[0][2].ToString(), clsCon.getData().Tables[0].Rows[0][3].ToString());
            }
            catch (Exception errGrid)
            {
                toolStripErrors.Text = errGrid.Message;
            }
        }
        private void fncLoadVoucherGridData()
        {
            try
            {
                advancedDataGridView1.Columns.Clear();
                advancedDataGridView1.DataSource = clsConsql.getDatasetsql("SELECT  [id], [VuNo], [VuDate], [VuType], [VuACode], case when [VuAmt]>=0 then [VuAmt] else 0 end as Debit, case when [VuAmt]<0 then [VuAmt] else 0 end as Credit , [VuNart], [VuCRDR] FROM [VuData] WHERE [VuNo]= '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' and [VuDate] = '" + Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value).ToString("yyyy-MM-dd") + "'");
                advancedDataGridView1.DataMember = clsConsql.getDatasql().Tables[0].TableName;
                //this.advancedDataGridView1.DefaultCellStyle.Font = new Font("AnmolKalmi", 8);
                //this.advancedDataGridView1.Columns[5].DefaultCellStyle.Font = new Font("AnmolKalmi", 8);
                //this.advancedDataGridView1.Columns[6].DefaultCellStyle.Font = new Font("AnmolKalmi", 8);
                //this.advancedDataGridView1.Columns[7].DefaultCellStyle.Font = new Font("AnmolKalmi", 8);
                advancedDataGridView1.Refresh();
                advancedDataGridView1.Columns[0].Visible = false;
                advancedDataGridView1.RowHeadersVisible = false;
                lblTotal.Text = advancedDataGridView1.Rows.Count.ToString();

                //advancedDataGridViewSearchToolBar1.SetColumns(advancedDataGridView1.Columns);
                //fncUpdateDisplay(clsConsql.getDatasql().Tables[0].Rows[0][0].ToString(), clsCon.getData().Tables[0].Rows[0][1].ToString(), clsCon.getData().Tables[0].Rows[0][2].ToString(), clsCon.getData().Tables[0].Rows[0][3].ToString());
            }
            catch (Exception errGrid)
            {
                toolStripErrors.Text = errGrid.Message;
            }
        }

        private void fncUpdateDisplay(String mp1, String mp2, String mp3, String mp4)
        {
            txtCustCode.Text = mp1;
            txtCustName.Text = mp2;
            txtCustFName.Text = mp3;
            txtCustCast.Text = mp4;

        }
        private void fncAddnew()
        {
            txtId.Text = "";
            txtCustCode.Text = fncGenerateNewCode();
            txtCustName.Text = "";
            txtCustFName.Text = "";
            txtCustCast.Text = "";
            txtCustName.Focus();

        }
        private void fncEmptyFields()
        {
            txtId.Text = "";
            txtCustCode.Text = "";
            txtCustName.Text = "";
            txtCustFName.Text = "";
            txtCustCast.Text = "";
            //txtCustName.Focus();

        }
        private string fncGenerateNewCode()
        {
            DataSet NewCode = clsConsql.getDatasetsql("select RIGHT(CONCAT('000',max([ActCode])+1), 4) from [ActMst] where [ActType]='C' ");
            var ReturnCode= NewCode.Tables[0].Rows[0][0].ToString();
            return ReturnCode;
        }
        private void CreateCycleData()
        {
            string strSqlCr;
            Application.DoEvents();
            try
            {
                if (txtId.Text.Trim() == "")
                {
                    strSqlCr = " insert into [ActMst] ";
                    //strSqlCr = strSqlCr + " ([ActCode],[ActNAME],[Act_F_NAME],[Act_CAST],[Act_NAMEPbi],[Act_F_NAMEPbi],[Act_CASTPbi],[ActType],[ActAddress],[ActCity]) ";
                    strSqlCr = strSqlCr + " ([ActCode],[ActNAME],[Act_F_NAME],[Act_CAST],[Act_NAMEPbi],[Act_F_NAMEPbi],[Act_CASTPbi],[ActType],[ActAddress],[ActBill]) ";
                    strSqlCr = strSqlCr + " values('" + (txtCustCode.Text) + "','" + (txtCustName.Text) + "','" + (txtCustFName.Text) + "','" + (txtCustCast.Text) + "','" + (txtActType.Text) + "')";
                }
                else
                {
                    strSqlCr = " UPDATE [ActMst] ";
                    strSqlCr = strSqlCr + "  SET [ActCode]='" + (txtCustCode.Text.Trim()) + "'";
                    strSqlCr = strSqlCr + "  , [ActNAME]='" + (txtCustName.Text.Trim()) + "'";
                    strSqlCr = strSqlCr + "  , [Act_F_NAME]='" + (txtCustFName.Text.Trim()) + "'";
                    strSqlCr = strSqlCr + "  , [Act_CAST]='" + (txtCustCast.Text.Trim()) + "'";
                    strSqlCr = strSqlCr + " WHERE [ID]=" + (txtId.Text.Trim()) + "";
                }
                try
                {
                    Application.DoEvents();
                    if (clsCon.getCon().State != ConnectionState.Open) clsCon.getCon().Open();
                    SqlCommand xCr = new SqlCommand(strSqlCr, clsCon.getCon());
                    xCr.ExecuteReader();
                    clsCon.getCon().Close();
                    toolStripErrors.Text = "Writing LocalData Successful";
                    fncEmptyFields();
                    fncLoadGridData();
                }
                catch (SystemException err)
                {
                    toolStripErrors.Text = "Problem Writing LocalData" + err.Message;
                }




            }
            catch (SystemException errSave)
            {

                toolStripErrors.Text = errSave.Message;
            }



        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CreateCycleData();
            fncLoadGridData();
        }


        private void DataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //if (dataGridView1.Rows.Count > 1)
            //{
            //    txtCustCode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //    txtCustName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //    txtCustFName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //}
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                //txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //txtCustCode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //txtCustName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //txtCustFName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //txtCustCast.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //txtActType.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                fncLoadVoucherGridData();
            }

        }

        private void advancedDataGridViewSearchToolBar1_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = dataGridView1.CurrentCell.ColumnIndex + 1 >= dataGridView1.ColumnCount;
                bool endrow = dataGridView1.CurrentCell.RowIndex + 1 >= dataGridView1.RowCount;

                if (endcol && endrow)
                {
                    startColumn = dataGridView1.CurrentCell.ColumnIndex;
                    startRow = dataGridView1.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : dataGridView1.CurrentCell.ColumnIndex + 1;
                    startRow = dataGridView1.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = dataGridView1.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = dataGridView1.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                dataGridView1.CurrentCell = c;
        }

        private void dataGridView1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
        }
        DataSet OrignalADGVdt = null;
        private void dataGridView1_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {


            Zuby.ADGV.AdvancedDataGridView fdgv = dataGridView1;
            DataSet dt = null;
            if (OrignalADGVdt == null)
            {
                OrignalADGVdt = (DataSet)fdgv.DataSource;
            }
            if (fdgv.FilterString.Length > 0)
            {
                dt = (DataSet)fdgv.DataSource;
                fdgv.DataSource = dt.Tables[0].Select(fdgv.FilterString).CopyToDataTable();
            }
            else//Clear Filter
            {
                //fncLoadGridData();
                dt = OrignalADGVdt;
                fdgv.DataSource = dt.Tables[0].Select(fdgv.FilterString).CopyToDataTable();
            }

            //string stringcolumnfilter = "";
            //if (!String.IsNullOrEmpty(stringcolumnfilter))
            //    e.FilterString += (!String.IsNullOrEmpty(e.FilterString) ? " AND " : "") + String.Format("string LIKE '%{0}%'", stringcolumnfilter.Replace("'", "''"));

        }
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            dataGridView1.CleanFilter();
            fncLoadGridData();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Application.DoEvents();
                    //Thread.Sleep(1);
                    //if(row.Index< dataGridView1.Rows.Count-1)
                    //dataGridView1.Rows[row.Index+1].Selected = false;
                    dataGridView1.CurrentCell = row.Cells["Select"];
                    dataGridView1.Rows[row.Index].Selected = true;

                    row.Cells["Select"].Value = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fncAddnew();
        }

        private void advancedDataGridViewSearchToolBar1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void From_ValueChanged(object sender, EventArgs e)
        {
            To.Focus();
            fncLoadGridData();
        }

        private void To_ValueChanged(object sender, EventArgs e)
        {
           
            fncLoadGridData();
            dataGridView1.Focus();

        }
    }
}
