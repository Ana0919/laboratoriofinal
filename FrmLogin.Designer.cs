namespace ApplicationInterface
{
    partial class FrmLogin
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnInitSession = new System.Windows.Forms.Button();
            this.errorUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblMenssage = new System.Windows.Forms.Label();
            this.LblOffices = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(11, 52);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(11, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña:";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(92, 49);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(120, 23);
            this.TxtUser.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(92, 82);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(120, 23);
            this.TxtPassword.TabIndex = 3;
            // 
            // BtnInitSession
            // 
            this.BtnInitSession.Location = new System.Drawing.Point(92, 123);
            this.BtnInitSession.Name = "BtnInitSession";
            this.BtnInitSession.Size = new System.Drawing.Size(120, 23);
            this.BtnInitSession.TabIndex = 4;
            this.BtnInitSession.Text = "Ingresar";
            this.BtnInitSession.UseVisualStyleBackColor = true;
            this.BtnInitSession.Click += new System.EventHandler(this.BtnInitSession_Click);
            // 
            // errorUserName
            // 
            this.errorUserName.ContainerControl = this;
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // LblMenssage
            // 
            this.LblMenssage.AutoSize = true;
            this.LblMenssage.ForeColor = System.Drawing.Color.Red;
            this.LblMenssage.Location = new System.Drawing.Point(23, 157);
            this.LblMenssage.Name = "LblMenssage";
            this.LblMenssage.Size = new System.Drawing.Size(60, 15);
            this.LblMenssage.TabIndex = 5;
            this.LblMenssage.Text = "Menssage";
            this.LblMenssage.Visible = false;
            // 
            // LblOffices
            // 
            this.LblOffices.AutoSize = true;
            this.LblOffices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOffices.Location = new System.Drawing.Point(58, 9);
            this.LblOffices.Name = "LblOffices";
            this.LblOffices.Size = new System.Drawing.Size(128, 21);
            this.LblOffices.TabIndex = 6;
            this.LblOffices.Text = "Inicio de sesión";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(243, 185);
            this.Controls.Add(this.LblOffices);
            this.Controls.Add(this.LblMenssage);
            this.Controls.Add(this.BtnInitSession);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnInitSession;
        private System.Windows.Forms.ErrorProvider errorUserName;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.Label LblMenssage;
        private System.Windows.Forms.Label LblOffices;
    }
}