using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Threading;


namespace BillingPbi
{

    public class SQLConnection
    {
        //Device communication declarations
        public Thread mWorker;
        //Database communication declarations
        public System.Data.SqlClient.SqlConnection con;
        public System.Data.SqlClient.SqlConnection conMysql;

        private string mStringServer;
        private string mStringDB;
        private string mStringUID;
        private string mStringPWD;
        String strCon;
        SqlDataAdapter daParam;
        DataSet dsParam;

        private string mStringServerMysql;
        private string mStringDBMysql;
        private string mStringUIDMysql;
        private string mStringPWDMysql;
        String strConMysql;
        SqlDataAdapter daParamMysql;
        DataSet dsParamMysql;


        public SQLConnection()
        {
            con = new SqlConnection();
            conMysql = new SqlConnection();
            StreamReader myFile = new StreamReader("c:\\server\\ConfigService.cfg");
            mStringServer = myFile.ReadLine();
            mStringDB = myFile.ReadLine();
            mStringUID = myFile.ReadLine();
            mStringPWD = myFile.ReadLine();


            myFile.Close();
            //SERVER=" + mServer + ";Integrated Security=True;DATABASE=" + mGenDataName + "
            strCon = "SERVER =" + mStringServer + "; Persist Security Info = True; Password = " + mStringPWD + "; User ID = " + mStringUID + "; Initial Catalog = " + mStringDB + "";
            con.ConnectionString = strCon;

            //strConMysql = "Server=" + mStringServerMysql + ";Database=" + mStringDBMysql + ";Uid=" + mStringUIDMysql + ";Pwd= " + mStringPWDMysql + "";

            //conMysql.ConnectionString = strConMysql;

        }
        public DataSet getDataset(String mStrSql)
        {
            daParam = new System.Data.SqlClient.SqlDataAdapter(mStrSql, con);
            dsParam = new DataSet();
            con.Open();
            daParam.Fill(dsParam);
            con.Close();
            return dsParam;
        }
        public DataSet getData()
        {
            return dsParam;
        }
        public SqlConnection getCon()
        {
            return con;
        }

        public DataSet getDatasetsql(String mStrSqlMysql)
        {
            daParamMysql = new System.Data.SqlClient.SqlDataAdapter(mStrSqlMysql, con);
            dsParamMysql = new DataSet();
            con.Open();
            daParamMysql.Fill(dsParamMysql);
            con.Close();
            return dsParamMysql;
        }
        public DataSet getDatasql()
        {
            return dsParamMysql;
        }
        public SqlConnection getConMysql()
        {
            return con;
        }

    }
}
