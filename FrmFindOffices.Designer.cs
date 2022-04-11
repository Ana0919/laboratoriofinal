namespace ApplicationInterface
{
    partial class FrmFindOffices
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
            this.DgOffices = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblOffices = new System.Windows.Forms.Label();
            this.LblMenssage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOfficeName = new System.Windows.Forms.TextBox();
            this.errorOfficeName = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnClean = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BsOffices = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgOffices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOfficeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsOffices)).BeginInit();
            this.SuspendLayout();
            // 
            // DgOffices
            // 
            this.DgOffices.AllowUserToAddRows = false;
            this.DgOffices.AllowUserToDeleteRows = false;
            this.DgOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgOffices.Location = new System.Drawing.Point(21, 125);
            this.DgOffices.Name = "DgOffices";
            this.DgOffices.ReadOnly = true;
            this.DgOffices.RowTemplate.Height = 25;
            this.DgOffices.Size = new System.Drawing.Size(395, 155);
            this.DgOffices.TabIndex = 1;
            this.DgOffices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOffices_CellDoubleClick);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(262, 52);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblOffices
            // 
            this.LblOffices.AutoSize = true;
            this.LblOffices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOffices.Location = new System.Drawing.Point(21, 16);
            this.LblOffices.Name = "LblOffices";
            this.LblOffices.Size = new System.Drawing.Size(90, 21);
            this.LblOffices.TabIndex = 2;
            this.LblOffices.Text = "Sucursales";
            // 
            // LblMenssage
            // 
            this.LblMenssage.AutoSize = true;
            this.LblMenssage.ForeColor = System.Drawing.Color.Red;
            this.LblMenssage.Location = new System.Drawing.Point(21, 297);
            this.LblMenssage.Name = "LblMenssage";
            this.LblMenssage.Size = new System.Drawing.Size(60, 15);
            this.LblMenssage.TabIndex = 6;
            this.LblMenssage.Text = "Menssage";
            this.LblMenssage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // TxtOfficeName
            // 
            this.TxtOfficeName.Location = new System.Drawing.Point(81, 52);
            this.TxtOfficeName.Name = "TxtOfficeName";
            this.TxtOfficeName.Size = new System.Drawing.Size(164, 23);
            this.TxtOfficeName.TabIndex = 8;
            // 
            // errorOfficeName
            // 
            this.errorOfficeName.ContainerControl = this;
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(343, 52);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(62, 23);
            this.BtnClean.TabIndex = 9;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Para seleccionar la sucursal de doble click sobre el nombre de la sucursal .";
            // 
            // FrmOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(433, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.TxtOfficeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMenssage);
            this.Controls.Add(this.LblOffices);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DgOffices);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOffices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmOffices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgOffices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOfficeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsOffices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgOffices;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblOffices;
        private System.Windows.Forms.Label LblMenssage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOfficeName;
        private System.Windows.Forms.ErrorProvider errorOfficeName;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource BsOffices;
    }
}