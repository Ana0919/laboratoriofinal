namespace ApplicationInterface
{
    partial class FrmPatient
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
            this.LblOffices = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboOc = new System.Windows.Forms.ComboBox();
            this.CboCivilState = new System.Windows.Forms.ComboBox();
            this.TxtMedicalHistory = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtEmergencyContact = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CboRegime = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CboEps = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CboLevelSchooling = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPhoneContact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtNeiborHood = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DpBorn = new System.Windows.Forms.DateTimePicker();
            this.CboGender = new System.Windows.Forms.ComboBox();
            this.CboTypeId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSavePatient = new System.Windows.Forms.Button();
            this.LblMenssage = new System.Windows.Forms.Label();
            this.BtnNewPatient = new System.Windows.Forms.Button();
            this.BtnNewText = new System.Windows.Forms.Button();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTypeId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAge = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNeiborHood = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhoneContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmergencyContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMedicalHistory = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCivilState = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEps = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRegime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLevelSchooling = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNeiborHood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhoneContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmergencyContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMedicalHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCivilState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLevelSchooling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // LblOffices
            // 
            this.LblOffices.AutoSize = true;
            this.LblOffices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOffices.Location = new System.Drawing.Point(12, 9);
            this.LblOffices.Name = "LblOffices";
            this.LblOffices.Size = new System.Drawing.Size(172, 21);
            this.LblOffices.TabIndex = 3;
            this.LblOffices.Text = "Regristro de Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombres Completos:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(141, 26);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(203, 23);
            this.TxtName.TabIndex = 5;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(141, 55);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(121, 23);
            this.TxtId.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero Identificación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboOc);
            this.groupBox1.Controls.Add(this.CboCivilState);
            this.groupBox1.Controls.Add(this.TxtMedicalHistory);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.TxtEmergencyContact);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.CboRegime);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.CboEps);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CboLevelSchooling);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtPhoneContact);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtNeiborHood);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtAge);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DpBorn);
            this.groupBox1.Controls.Add(this.CboGender);
            this.groupBox1.Controls.Add(this.CboTypeId);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 484);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Paciente";
            // 
            // CboOc
            // 
            this.CboOc.FormattingEnabled = true;
            this.CboOc.Location = new System.Drawing.Point(142, 172);
            this.CboOc.Name = "CboOc";
            this.CboOc.Size = new System.Drawing.Size(121, 23);
            this.CboOc.TabIndex = 46;
            // 
            // CboCivilState
            // 
            this.CboCivilState.FormattingEnabled = true;
            this.CboCivilState.Location = new System.Drawing.Point(474, 85);
            this.CboCivilState.Name = "CboCivilState";
            this.CboCivilState.Size = new System.Drawing.Size(121, 23);
            this.CboCivilState.TabIndex = 32;
            // 
            // TxtMedicalHistory
            // 
            this.TxtMedicalHistory.Location = new System.Drawing.Point(7, 328);
            this.TxtMedicalHistory.Multiline = true;
            this.TxtMedicalHistory.Name = "TxtMedicalHistory";
            this.TxtMedicalHistory.Size = new System.Drawing.Size(588, 150);
            this.TxtMedicalHistory.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 299);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 15);
            this.label17.TabIndex = 44;
            this.label17.Text = "Antecedentes Médicos:";
            // 
            // TxtEmergencyContact
            // 
            this.TxtEmergencyContact.Location = new System.Drawing.Point(196, 259);
            this.TxtEmergencyContact.Name = "TxtEmergencyContact";
            this.TxtEmergencyContact.Size = new System.Drawing.Size(399, 23);
            this.TxtEmergencyContact.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 15);
            this.label16.TabIndex = 42;
            this.label16.Text = "Contacto en caso de emergencia:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(142, 230);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(106, 23);
            this.TxtEmail.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 40;
            this.label15.Text = "Email:";
            // 
            // CboRegime
            // 
            this.CboRegime.FormattingEnabled = true;
            this.CboRegime.Location = new System.Drawing.Point(329, 200);
            this.CboRegime.Name = "CboRegime";
            this.CboRegime.Size = new System.Drawing.Size(106, 23);
            this.CboRegime.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(266, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 15);
            this.label14.TabIndex = 38;
            this.label14.Text = "Regimen:";
            // 
            // CboEps
            // 
            this.CboEps.FormattingEnabled = true;
            this.CboEps.Location = new System.Drawing.Point(142, 200);
            this.CboEps.Name = "CboEps";
            this.CboEps.Size = new System.Drawing.Size(106, 23);
            this.CboEps.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 15);
            this.label13.TabIndex = 36;
            this.label13.Text = "EPS:";
            // 
            // CboLevelSchooling
            // 
            this.CboLevelSchooling.FormattingEnabled = true;
            this.CboLevelSchooling.Location = new System.Drawing.Point(440, 172);
            this.CboLevelSchooling.Name = "CboLevelSchooling";
            this.CboLevelSchooling.Size = new System.Drawing.Size(155, 23);
            this.CboLevelSchooling.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(334, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Nivel Escolaridad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "Ocupación:";
            // 
            // TxtPhoneContact
            // 
            this.TxtPhoneContact.Location = new System.Drawing.Point(394, 143);
            this.TxtPhoneContact.Name = "TxtPhoneContact";
            this.TxtPhoneContact.Size = new System.Drawing.Size(201, 23);
            this.TxtPhoneContact.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Teléfono Contacto:";
            // 
            // TxtNeiborHood
            // 
            this.TxtNeiborHood.Location = new System.Drawing.Point(141, 143);
            this.TxtNeiborHood.Name = "TxtNeiborHood";
            this.TxtNeiborHood.Size = new System.Drawing.Size(121, 23);
            this.TxtNeiborHood.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Barrio Residencia:";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(141, 114);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(454, 23);
            this.TxtAddress.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Estado Civil:";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(308, 84);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(36, 23);
            this.TxtAge.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Edad:";
            // 
            // DpBorn
            // 
            this.DpBorn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpBorn.Location = new System.Drawing.Point(141, 84);
            this.DpBorn.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DpBorn.Name = "DpBorn";
            this.DpBorn.Size = new System.Drawing.Size(119, 23);
            this.DpBorn.TabIndex = 20;
            // 
            // CboGender
            // 
            this.CboGender.FormattingEnabled = true;
            this.CboGender.Location = new System.Drawing.Point(474, 55);
            this.CboGender.Name = "CboGender";
            this.CboGender.Size = new System.Drawing.Size(121, 23);
            this.CboGender.TabIndex = 19;
            // 
            // CboTypeId
            // 
            this.CboTypeId.FormattingEnabled = true;
            this.CboTypeId.Location = new System.Drawing.Point(474, 26);
            this.CboTypeId.Name = "CboTypeId";
            this.CboTypeId.Size = new System.Drawing.Size(121, 23);
            this.CboTypeId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo Identificación";
            // 
            // BtnSavePatient
            // 
            this.BtnSavePatient.Location = new System.Drawing.Point(93, 42);
            this.BtnSavePatient.Name = "BtnSavePatient";
            this.BtnSavePatient.Size = new System.Drawing.Size(64, 23);
            this.BtnSavePatient.TabIndex = 21;
            this.BtnSavePatient.Text = "Guardar";
            this.BtnSavePatient.UseVisualStyleBackColor = true;
            this.BtnSavePatient.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblMenssage
            // 
            this.LblMenssage.AutoSize = true;
            this.LblMenssage.ForeColor = System.Drawing.Color.Red;
            this.LblMenssage.Location = new System.Drawing.Point(12, 567);
            this.LblMenssage.Name = "LblMenssage";
            this.LblMenssage.Size = new System.Drawing.Size(60, 15);
            this.LblMenssage.TabIndex = 29;
            this.LblMenssage.Text = "Menssage";
            this.LblMenssage.Visible = false;
            // 
            // BtnNewPatient
            // 
            this.BtnNewPatient.Location = new System.Drawing.Point(12, 42);
            this.BtnNewPatient.Name = "BtnNewPatient";
            this.BtnNewPatient.Size = new System.Drawing.Size(60, 23);
            this.BtnNewPatient.TabIndex = 30;
            this.BtnNewPatient.Text = "Nuevo";
            this.BtnNewPatient.UseVisualStyleBackColor = true;
            this.BtnNewPatient.Click += new System.EventHandler(this.BtnNewPatient_Click);
            // 
            // BtnNewText
            // 
            this.BtnNewText.Location = new System.Drawing.Point(514, 42);
            this.BtnNewText.Name = "BtnNewText";
            this.BtnNewText.Size = new System.Drawing.Size(113, 23);
            this.BtnNewText.TabIndex = 31;
            this.BtnNewText.Text = "Registro Examen";
            this.BtnNewText.UseVisualStyleBackColor = true;
            this.BtnNewText.Click += new System.EventHandler(this.BtnNewText_Click);
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorTypeId
            // 
            this.errorTypeId.ContainerControl = this;
            // 
            // errorId
            // 
            this.errorId.ContainerControl = this;
            // 
            // errorAge
            // 
            this.errorAge.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // errorNeiborHood
            // 
            this.errorNeiborHood.ContainerControl = this;
            // 
            // errorPhoneContact
            // 
            this.errorPhoneContact.ContainerControl = this;
            // 
            // errorEmergencyContact
            // 
            this.errorEmergencyContact.ContainerControl = this;
            // 
            // errorMedicalHistory
            // 
            this.errorMedicalHistory.ContainerControl = this;
            // 
            // errorCivilState
            // 
            this.errorCivilState.ContainerControl = this;
            // 
            // errorEps
            // 
            this.errorEps.ContainerControl = this;
            // 
            // errorRegime
            // 
            this.errorRegime.ContainerControl = this;
            // 
            // errorLevelSchooling
            // 
            this.errorLevelSchooling.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(639, 597);
            this.Controls.Add(this.BtnNewText);
            this.Controls.Add(this.BtnNewPatient);
            this.Controls.Add(this.BtnSavePatient);
            this.Controls.Add(this.LblMenssage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblOffices);
            this.MaximizeBox = false;
            this.Name = "FrmPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNeiborHood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhoneContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmergencyContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMedicalHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCivilState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLevelSchooling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOffices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DpBorn;
        private System.Windows.Forms.ComboBox CboGender;
        private System.Windows.Forms.ComboBox CboTypeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSavePatient;
        private System.Windows.Forms.Label LblMenssage;
        private System.Windows.Forms.Button BtnNewPatient;
        private System.Windows.Forms.Button BtnNewText;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboOccupation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboLevelSchooling;
        private System.Windows.Forms.Label label12;
       
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPhoneContact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtNeiborHood;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtMedicalHistory;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtEmergencyContact;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CboRegime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CboEps;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CboCivilState;
        private System.Windows.Forms.ComboBox CboOc;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorTypeId;
        private System.Windows.Forms.ErrorProvider errorId;
        private System.Windows.Forms.ErrorProvider errorAge;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.ErrorProvider errorNeiborHood;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorPhoneContact;
        private System.Windows.Forms.ErrorProvider errorEmergencyContact;
        private System.Windows.Forms.ErrorProvider errorMedicalHistory;
        private System.Windows.Forms.ErrorProvider errorCivilState;
        private System.Windows.Forms.ErrorProvider errorEps;
        private System.Windows.Forms.ErrorProvider errorRegime;
        private System.Windows.Forms.ErrorProvider errorLevelSchooling;
        
    }
}