namespace ApplicationInterface
{
    partial class FrmFindPatients
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMenssage = new System.Windows.Forms.Label();
            this.LblOffices = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgPatients = new System.Windows.Forms.DataGridView();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(72, 45);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(164, 23);
            this.TxtName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // LblMenssage
            // 
            this.LblMenssage.AutoSize = true;
            this.LblMenssage.ForeColor = System.Drawing.Color.Red;
            this.LblMenssage.Location = new System.Drawing.Point(12, 290);
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
            this.LblOffices.Location = new System.Drawing.Point(12, 9);
            this.LblOffices.Name = "LblOffices";
            this.LblOffices.Size = new System.Drawing.Size(83, 21);
            this.LblOffices.TabIndex = 13;
            this.LblOffices.Text = "Pacientes";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(253, 45);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgPatients
            // 
            this.DgPatients.AllowUserToAddRows = false;
            this.DgPatients.AllowUserToDeleteRows = false;
            this.DgPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPatients.Location = new System.Drawing.Point(12, 118);
            this.DgPatients.Name = "DgPatients";
            this.DgPatients.ReadOnly = true;
            this.DgPatients.RowTemplate.Height = 25;
            this.DgPatients.Size = new System.Drawing.Size(395, 155);
            this.DgPatients.TabIndex = 12;
            this.DgPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPatients_CellDoubleClick);
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Para seleccionar el paciente de doble click sobre el nombre.";
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(334, 45);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(62, 23);
            this.BtnClean.TabIndex = 17;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            // 
            // FrmFindPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(428, 312);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMenssage);
            this.Controls.Add(this.LblOffices);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DgPatients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnClean);
            this.MaximizeBox = false;
            this.Name = "FrmFindPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmFindPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMenssage;
        private System.Windows.Forms.Label LblOffices;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgPatients;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClean;
    }
}