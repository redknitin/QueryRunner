using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using ConfigUtilities;

namespace QueryRunner
{
    public partial class ConnectionControl : UserControl
    {
        public ConnectionControl()
        {
            InitializeComponent();
        }

        private void rdoWinAuth_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoSqlAuth_CheckedChanged(object sender, EventArgs e)
        {
            sqlAuthTxtboxesState(rdoSqlAuth.Checked);
        }

        void sqlAuthTxtboxesState(bool aIsEnabled)
        {
            txtUsername.Enabled = txtPassword.Enabled = aIsEnabled;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                //lblStatus.Text = "Please wait. Trying to connect to DB.";
                var tryConn = GetConnection();
                tryConn.Open();
                var cmd = tryConn.CreateCommand();
                cmd.CommandText = @"SELECT GETDATE()";
                cmd.CommandType = CommandType.Text;
                var objRet = cmd.ExecuteScalar();
                tryConn.Close();

                MessageBox.Show("Test successful");

                new ConnectionStringHelper()["DbConn"] = tryConn.ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Debugger.Break();
            }
            finally
            {
                //lblStatus.Text = "-";
            }
        }

        SqlConnection GetConnection()
        {
            var connStrBld = new SqlConnectionStringBuilder();
            connStrBld.DataSource = txtServer.Text;
            connStrBld.InitialCatalog = txtDb.Text;
            connStrBld.IntegratedSecurity = rdoWinAuth.Checked;
            if (rdoSqlAuth.Checked)
            {
                connStrBld.UserID = txtUsername.Text;
                connStrBld.Password = txtPassword.Text;
            }
            var dbConn = new SqlConnection(connStrBld.ConnectionString);
            return dbConn;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //lblStatus.Text = "Please wait. Trying to connect to DB.";
                var conn = GetConnection();
                conn.Open();
                MainForm.DbConnection = conn;
                this.Parent.Controls.Add(new QueryRunner());                
                this.Parent.Controls.Remove(this);

                new ConnectionStringHelper()["DbConn"] = conn.ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Debugger.Break();
            }
            finally
            {
                //lblStatus.Text = "-";
            }
        }

        private void ConnectionControl_Load(object sender, EventArgs e)
        {
            var currConnStr = new ConnectionStringHelper()["DbConn"];
            if (currConnStr != null)
            {
                var connStrBld = new SqlConnectionStringBuilder(currConnStr);
                txtServer.Text = connStrBld.DataSource;
                txtDb.Text = connStrBld.InitialCatalog;
                rdoWinAuth.Checked = connStrBld.IntegratedSecurity;
                rdoSqlAuth.Checked = !connStrBld.IntegratedSecurity;
                if (rdoSqlAuth.Checked)
                {
                    txtUsername.Text = connStrBld.UserID;
                    txtPassword.Text = connStrBld.Password;
                }
            }
        }
    }
}
