using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QueryRunner
{
    public partial class MainForm : Form
    {
        public static SqlConnection DbConnection = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            this.Controls.Add(new ConnectionControl());
        }
    }
}
