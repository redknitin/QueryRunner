using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QueryRunner
{
    public partial class QueryRunner : UserControl
    {
        public QueryRunner()
        {
            InitializeComponent();
        }

        private void QueryRunner_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            var queryArr = QueryLoader.LoadXml();
            foreach (var iterDbCmd in queryArr)
            {
                cboQuery.Items.Add(iterDbCmd);
            }
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            var qry = (QueryModel) cboQuery.SelectedItem;
            var dbCmd = MainForm.DbConnection.CreateCommand();
            dbCmd.CommandType = CommandType.Text;
            dbCmd.CommandText = qry.SQL;
            RunDbCmd(dbCmd);
        }

        void RunDbCmd(SqlCommand aCmd)
        {
            var rdr = aCmd.ExecuteReader();

            var dtSchema = rdr.GetSchemaTable();
            //gvuData.Columns.Clear();
            List<string> colList = new List<string>();
            DataTable dt = new DataTable();
            for (int i = 0; i < dtSchema.Rows.Count; i++)
            {
                string iterColName = dtSchema.Rows[i][0].ToString();
                //gvuData.Columns.Add(iterColName, iterColName);
                dt.Columns.Add(iterColName);
                colList.Add(iterColName);
            }

            while (rdr.Read())
            {
                List<object> rowData = new List<object>();
                for (int j=0; j<colList.Count; j++) {
                    rowData.Add(rdr.GetValue(j));
                }
                dt.Rows.Add(rowData.ToArray());
            }

            rdr.Close();

            gvuData.DataSource = dt;
        }
    }
}
