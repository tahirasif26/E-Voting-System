
namespace AdminPanel
{
    partial class CandidateList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGPAColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Past_ExpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApproveColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RejectColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 103);
            this.panel1.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.ActiveBorderThickness = 1;
            this.Back.ActiveCornerRadius = 20;
            this.Back.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.Back.ActiveForecolor = System.Drawing.Color.White;
            this.Back.ActiveLineColor = System.Drawing.Color.Blue;
            this.Back.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.ButtonText = "Back";
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Back.IdleBorderThickness = 1;
            this.Back.IdleCornerRadius = 20;
            this.Back.IdleFillColor = System.Drawing.Color.White;
            this.Back.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.Back.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.Back.Location = new System.Drawing.Point(3, 18);
            this.Back.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(108, 45);
            this.Back.TabIndex = 2;
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Candidate List";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.EmailColumn,
            this.PnoColumn,
            this.PositionColumn,
            this.CGPAColumn,
            this.Past_ExpColumn,
            this.Status,
            this.ApproveColumn,
            this.RejectColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.GridColor = System.Drawing.Color.SteelBlue;
            this.DataGrid.Location = new System.Drawing.Point(4, 79);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(804, 364);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "id";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Width = 80;
            // 
            // EmailColumn
            // 
            this.EmailColumn.DataPropertyName = "email";
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            // 
            // PnoColumn
            // 
            this.PnoColumn.DataPropertyName = "pno";
            this.PnoColumn.HeaderText = "Pno";
            this.PnoColumn.Name = "PnoColumn";
            this.PnoColumn.ReadOnly = true;
            this.PnoColumn.Width = 50;
            // 
            // PositionColumn
            // 
            this.PositionColumn.DataPropertyName = "position";
            this.PositionColumn.HeaderText = "Position";
            this.PositionColumn.Name = "PositionColumn";
            this.PositionColumn.ReadOnly = true;
            // 
            // CGPAColumn
            // 
            this.CGPAColumn.DataPropertyName = "cgpa";
            this.CGPAColumn.HeaderText = "CGPA";
            this.CGPAColumn.Name = "CGPAColumn";
            this.CGPAColumn.ReadOnly = true;
            this.CGPAColumn.Width = 50;
            // 
            // Past_ExpColumn
            // 
            this.Past_ExpColumn.DataPropertyName = "past_exp";
            this.Past_ExpColumn.HeaderText = "Past_Exp";
            this.Past_ExpColumn.Name = "Past_ExpColumn";
            this.Past_ExpColumn.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ApproveColumn
            // 
            this.ApproveColumn.HeaderText = "Approve";
            this.ApproveColumn.Name = "ApproveColumn";
            this.ApproveColumn.ReadOnly = true;
            this.ApproveColumn.Text = "Approve";
            this.ApproveColumn.UseColumnTextForButtonValue = true;
            this.ApproveColumn.Width = 90;
            // 
            // RejectColumn
            // 
            this.RejectColumn.HeaderText = "Reject";
            this.RejectColumn.Name = "RejectColumn";
            this.RejectColumn.ReadOnly = true;
            this.RejectColumn.Text = "Reject";
            this.RejectColumn.UseColumnTextForButtonValue = true;
            this.RejectColumn.Width = 90;
            // 
            // CandidateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 455);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "CandidateList";
            this.Text = "CandidateList";
            this.Activated += new System.EventHandler(this.CandidateList_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PnoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGPAColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Past_ExpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn ApproveColumn;
        private System.Windows.Forms.DataGridViewButtonColumn RejectColumn;
    }
}