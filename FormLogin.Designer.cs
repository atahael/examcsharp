namespace tp_examc_
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblEmail;
        private Label lblPassword;

        private void InitializeComponent()
        {
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.lblEmail = new Label();
            this.lblPassword = new Label();
            this.SuspendLayout();

            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(20, 20);

            this.txtEmail.Location = new System.Drawing.Point(130, 20);
            this.txtEmail.Size = new System.Drawing.Size(200, 20);

            this.lblPassword.Text = "Mot de Passe:";
            this.lblPassword.Location = new System.Drawing.Point(20, 60);

            this.txtPassword.Location = new System.Drawing.Point(130, 60);
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.PasswordChar = '*';

            this.btnLogin.Text = "Connexion";
            this.btnLogin.Location = new System.Drawing.Point(130, 100);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.ClientSize = new System.Drawing.Size(380, 160);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
