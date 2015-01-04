namespace QueryRunner
{
    partial class QueryRunner
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gvuData = new System.Windows.Forms.DataGridView();
            this.cboQuery = new System.Windows.Forms.ComboBox();
            this.btnRunQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvuData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query";
            // 
            // gvuData
            // 
            this.gvuData.AllowUserToAddRows = false;
            this.gvuData.AllowUserToDeleteRows = false;
            this.gvuData.AllowUserToOrderColumns = true;
            this.gvuData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvuData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvuData.Location = new System.Drawing.Point(16, 57);
            this.gvuData.Name = "gvuData";
            this.gvuData.ReadOnly = true;
            this.gvuData.Size = new System.Drawing.Size(642, 347);
            this.gvuData.TabIndex = 1;
            // 
            // cboQuery
            // 
            this.cboQuery.FormattingEnabled = true;
            this.cboQuery.Location = new System.Drawing.Point(94, 13);
            this.cboQuery.Name = "cboQuery";
            this.cboQuery.Size = new System.Drawing.Size(308, 21);
            this.cboQuery.TabIndex = 2;
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Location = new System.Drawing.Point(409, 10);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(75, 23);
            this.btnRunQuery.TabIndex = 3;
            this.btnRunQuery.Text = "Run Query";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // QueryRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.cboQuery);
            this.Controls.Add(this.gvuData);
            this.Controls.Add(this.label1);
            this.Name = "QueryRunner";
            this.Size = new System.Drawing.Size(673, 422);
            this.Load += new System.EventHandler(this.QueryRunner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvuData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvuData;
        private System.Windows.Forms.ComboBox cboQuery;
        private System.Windows.Forms.Button btnRunQuery;
    }
}
