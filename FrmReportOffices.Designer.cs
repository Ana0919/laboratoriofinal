namespace ApplicationInterface
{
    partial class FrmReportOffices
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
            this.TxtOfficeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMenssage = new System.Windows.Forms.Label();
            this.LblOffices = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgOffices = new System.Windows.Forms.DataGridView();
            this.errorOfficeName = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgOffices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOfficeName)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOfficeName
            // 
            this.TxtOfficeName.Location = new System.Drawing.Point(80, 47);
            this.TxtOfficeName.Name = "TxtOfficeName";
            this.TxtOfficeName.Size = new System.Drawing.Size(164, 23);
            this.TxtOfficeName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // LblMenssage
            // 
            this.LblMenssage.AutoSize = true;
            this.LblMenssage.ForeColor = System.Drawing.Color.Red;
            this.LblMenssage.Location = new System.Drawing.Point(20, 292);
            this.LblMenssage.Name = "LblMenssage";
            this.LblMenssage.Size = new System.Drawing.Size(60, 15);
            this.LblMenssage.TabIndex = 14;
            this.LblMenssage.Text = "Menssage";
            this.LblMenssage.Visible = false;
            // 
            // LblOffices
            // 
            this.LblOffices.AutoSize = true;
            this.LblOffices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOffices.Location = new System.Drawing.Point(20, 11);
            this.LblOffices.Name = "LblOffices";
            this.LblOffices.Size = new System.Drawing.Size(90, 21);
            this.LblOffices.TabIndex = 13;
            this.LblOffices.Text = "Sucursales";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(261, 47);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgOffices
            // 
            this.DgOffices.AllowUserToAddRows = false;
            this.DgOffices.AllowUserToDeleteRows = false;
            this.DgOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgOffices.Location = new System.Drawing.Point(20, 76);
            this.DgOffices.Name = "DgOffices";
            this.DgOffices.ReadOnly = true;
            this.DgOffices.RowTemplate.Height = 25;
            this.DgOffices.Size = new System.Drawing.Size(768, 199);
            this.DgOffices.TabIndex = 12;
            // 
            // errorOfficeName
            // 
            this.errorOfficeName.ContainerControl = this;
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(342, 47);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(62, 23);
            this.BtnClean.TabIndex = 17;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // FrmReportOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.TxtOfficeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMenssage);
            this.Controls.Add(this.LblOffices);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DgOffices);
            this.Controls.Add(this.BtnClean);
            this.MaximizeBox = false;
            this.Name = "FrmReportOffices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmReportOffices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgOffices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOfficeName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOfficeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMenssage;
        private System.Windows.Forms.Label LblOffices;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgOffices;
        private System.Windows.Forms.ErrorProvider errorOfficeName;
        private System.Windows.Forms.Button BtnClean;
    }
}