namespace ApplicationInterface
{
    partial class FrmInfoTest
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
            this.BtnFindUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPatientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblOffices = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblCostTotal = new System.Windows.Forms.Label();
            this.LblMenssage = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblOfficeName = new System.Windows.Forms.Label();
            this.BtnFindOffice = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.errorOfficeName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPatientId = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorOfficeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPatientId)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFindUser
            // 
            this.BtnFindUser.Location = new System.Drawing.Point(275, 51);
            this.BtnFindUser.Name = "BtnFindUser";
            this.BtnFindUser.Size = new System.Drawing.Size(75, 23);
            this.BtnFindUser.TabIndex = 0;
            this.BtnFindUser.Text = "Consultar";
            this.BtnFindUser.UseVisualStyleBackColor = true;
            this.BtnFindUser.Click += new System.EventHandler(this.BtnFindUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indentificación:";
            // 
            // TxtPatientId
            // 
            this.TxtPatientId.Location = new System.Drawing.Point(101, 51);
            this.TxtPatientId.Name = "TxtPatientId";
            this.TxtPatientId.Size = new System.Drawing.Size(145, 23);
            this.TxtPatientId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Completo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblAge);
            this.groupBox1.Controls.Add(this.LblName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(391, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(142, 63);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(12, 15);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad:";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(48, 63);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(12, 15);
            this.LblAge.TabIndex = 5;
            this.LblAge.Text = "-";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(6, 42);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(12, 15);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "-";
            // 
            // LblOffices
            // 
            this.LblOffices.AutoSize = true;
            this.LblOffices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOffices.Location = new System.Drawing.Point(12, 9);
            this.LblOffices.Name = "LblOffices";
            this.LblOffices.Size = new System.Drawing.Size(161, 21);
            this.LblOffices.TabIndex = 5;
            this.LblOffices.Text = "Registro de Examen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Costo total:";
            // 
            // LblCostTotal
            // 
            this.LblCostTotal.AutoSize = true;
            this.LblCostTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCostTotal.ForeColor = System.Drawing.Color.Red;
            this.LblCostTotal.Location = new System.Drawing.Point(89, 379);
            this.LblCostTotal.Name = "LblCostTotal";
            this.LblCostTotal.Size = new System.Drawing.Size(97, 30);
            this.LblCostTotal.TabIndex = 13;
            this.LblCostTotal.Text = "0000000";
            // 
            // LblMenssage
            // 
            this.LblMenssage.AutoSize = true;
            this.LblMenssage.ForeColor = System.Drawing.Color.Red;
            this.LblMenssage.Location = new System.Drawing.Point(10, 416);
            this.LblMenssage.Name = "LblMenssage";
            this.LblMenssage.Size = new System.Drawing.Size(60, 15);
            this.LblMenssage.TabIndex = 14;
            this.LblMenssage.Text = "Menssage";
            this.LblMenssage.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sede:";
            // 
            // LblOfficeName
            // 
            this.LblOfficeName.AutoSize = true;
            this.LblOfficeName.Location = new System.Drawing.Point(47, 27);
            this.LblOfficeName.Name = "LblOfficeName";
            this.LblOfficeName.Size = new System.Drawing.Size(0, 15);
            this.LblOfficeName.TabIndex = 16;
            // 
            // BtnFindOffice
            // 
            this.BtnFindOffice.Location = new System.Drawing.Point(275, 17);
            this.BtnFindOffice.Name = "BtnFindOffice";
            this.BtnFindOffice.Size = new System.Drawing.Size(75, 23);
            this.BtnFindOffice.TabIndex = 17;
            this.BtnFindOffice.Text = "Consultar";
            this.BtnFindOffice.UseVisualStyleBackColor = true;
            this.BtnFindOffice.Click += new System.EventHandler(this.BtnFindOffice_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(73, 44);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 18;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // errorOfficeName
            // 
            this.errorOfficeName.ContainerControl = this;
            // 
            // errorPatientId
            // 
            this.errorPatientId.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.BtnFindUser);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BtnFindOffice);
            this.groupBox2.Controls.Add(this.TxtPatientId);
            this.groupBox2.Controls.Add(this.LblOfficeName);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 90);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selección";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 163);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selección";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(653, 95);
            this.dataGridView1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Examen:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 11;
            // 
            // FrmInfoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(693, 449);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblMenssage);
            this.Controls.Add(this.LblCostTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblOffices);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmInfoTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorOfficeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPatientId)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFindUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPatientId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblOffices;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblCostTotal;
        private System.Windows.Forms.Label LblMenssage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblOfficeName;
        private System.Windows.Forms.Button BtnFindOffice;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider errorOfficeName;
        private System.Windows.Forms.ErrorProvider errorPatientId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}