namespace tp_examc_
{
    partial class FormAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private ComboBox cbRole;
        private Button btnAjouter;
        private Label lblNom;
        private Label lblPrenom;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblRole;

        private void InitializeComponent()
        {
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            cbRole = new ComboBox();
            btnAjouter = new Button();
            lblNom = new Label();
            lblPrenom = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(130, 20);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 27);
            txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(130, 60);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(100, 27);
            txtPrenom.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(130, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 27);
            txtPassword.TabIndex = 7;
            // 
            // cbRole
            // 
            cbRole.Items.AddRange(new object[] { "Etudiant", "Enseignant" });
            cbRole.Location = new Point(130, 180);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(121, 28);
            cbRole.TabIndex = 9;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(130, 220);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 10;
            btnAjouter.Text = "Ajouter";
            btnAjouter.Click += btnAjouter_Click;
            // 
            // lblNom
            // 
            lblNom.Location = new Point(20, 20);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(100, 23);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom:";
            // 
            // lblPrenom
            // 
            lblPrenom.Location = new Point(20, 60);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(100, 23);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Prénom:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(20, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(20, 140);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Mot de Passe:";
            // 
            // lblRole
            // 
            lblRole.Location = new Point(20, 180);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 23);
            lblRole.TabIndex = 8;
            lblRole.Text = "Rôle:";
            // 
            // FormAdmin
            // 
            ClientSize = new Size(350, 280);
            Controls.Add(lblNom);
            Controls.Add(txtNom);
            Controls.Add(lblPrenom);
            Controls.Add(txtPrenom);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(cbRole);
            Controls.Add(btnAjouter);
            Name = "FormAdmin";
            Text = "Ajout Utilisateur";
            Load += FormAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
