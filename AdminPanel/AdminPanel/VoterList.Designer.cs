
namespace AdminPanel
{
    partial class VoterList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoterList));
            this.adminLoginDataSet = new AdminPanel.AdminLoginDataSet();
            this.votersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votersListTableAdapter = new AdminPanel.AdminLoginDataSetTableAdapters.VotersListTableAdapter();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Panel = new System.Windows.Forms.Panel();
            this.Back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RollnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminLoginDataSet
            // 
            this.adminLoginDataSet.DataSetName = "AdminLoginDataSet";
            this.adminLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersListBindingSource
            // 
            this.votersListBindingSource.DataMember = "VotersList";
            this.votersListBindingSource.DataSource = this.adminLoginDataSet;
            // 
            // votersListTableAdapter
            // 
            this.votersListTableAdapter.ClearBeforeFill = true;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RollnoColumn,
            this.usernameColumn,
            this.sectionColumn,
            this.batchColumn,
            this.degreeColumn,
            this.phonenumberColumn,
            this.cnicColumn,
            this.passwordColumn,
            this.UpdateColumn,
            this.DeleteColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DataGrid.Location = new System.Drawing.Point(6, 69);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(944, 426);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick_1);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Panel.Controls.Add(this.Back);
            this.Panel.Controls.Add(this.Label);
            this.Panel.Location = new System.Drawing.Point(3, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(941, 100);
            this.Panel.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.ActiveBorderThickness = 1;
            this.Back.ActiveCornerRadius = 20;
            this.Back.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.Back.ActiveForecolor = System.Drawing.Color.White;
            this.Back.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
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
            this.Back.Location = new System.Drawing.Point(12, 19);
            this.Back.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(108, 45);
            this.Back.TabIndex = 3;
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(401, 19);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(174, 42);
            this.Label.TabIndex = 0;
            this.Label.Text = "Voter List";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RollnoColumn
            // 
            this.RollnoColumn.DataPropertyName = "rollno";
            this.RollnoColumn.HeaderText = "rollno";
            this.RollnoColumn.Name = "RollnoColumn";
            this.RollnoColumn.ReadOnly = true;
            this.RollnoColumn.Width = 80;
            // 
            // usernameColumn
            // 
            this.usernameColumn.DataPropertyName = "username";
            this.usernameColumn.HeaderText = "username";
            this.usernameColumn.Name = "usernameColumn";
            this.usernameColumn.ReadOnly = true;
            // 
            // sectionColumn
            // 
            this.sectionColumn.DataPropertyName = "section";
            this.sectionColumn.HeaderText = "section";
            this.sectionColumn.Name = "sectionColumn";
            this.sectionColumn.ReadOnly = true;
            this.sectionColumn.Width = 70;
            // 
            // batchColumn
            // 
            this.batchColumn.DataPropertyName = "batch";
            this.batchColumn.HeaderText = "batch";
            this.batchColumn.Name = "batchColumn";
            this.batchColumn.ReadOnly = true;
            this.batchColumn.Width = 70;
            // 
            // degreeColumn
            // 
            this.degreeColumn.DataPropertyName = "degree";
            this.degreeColumn.HeaderText = "degree";
            this.degreeColumn.Name = "degreeColumn";
            this.degreeColumn.ReadOnly = true;
            this.degreeColumn.Width = 70;
            // 
            // phonenumberColumn
            // 
            this.phonenumberColumn.DataPropertyName = "phonenumber";
            this.phonenumberColumn.HeaderText = "phonenumber";
            this.phonenumberColumn.Name = "phonenumberColumn";
            this.phonenumberColumn.ReadOnly = true;
            this.phonenumberColumn.Width = 120;
            // 
            // cnicColumn
            // 
            this.cnicColumn.DataPropertyName = "cnic";
            this.cnicColumn.HeaderText = "cnic";
            this.cnicColumn.Name = "cnicColumn";
            this.cnicColumn.ReadOnly = true;
            this.cnicColumn.Width = 120;
            // 
            // passwordColumn
            // 
            this.passwordColumn.DataPropertyName = "password";
            this.passwordColumn.HeaderText = "password";
            this.passwordColumn.Name = "passwordColumn";
            this.passwordColumn.ReadOnly = true;
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.HeaderText = "Update";
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.ReadOnly = true;
            this.UpdateColumn.Text = "Update";
            this.UpdateColumn.UseColumnTextForButtonValue = true;
            this.UpdateColumn.Width = 80;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 80;
            // 
            // VoterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 507);
            this.ControlBox = false;
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.Panel);
            this.Name = "VoterList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoterList";
            this.Activated += new System.EventHandler(this.VoterList_Activated);
            this.Load += new System.EventHandler(this.VoterList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AdminLoginDataSet adminLoginDataSet;
        private System.Windows.Forms.BindingSource votersListBindingSource;
        private AdminLoginDataSetTableAdapters.VotersListTableAdapter votersListTableAdapter;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Panel Panel;
        private Bunifu.Framework.UI.BunifuCustomLabel Label;
        private Bunifu.Framework.UI.BunifuThinButton2 Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollnoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}