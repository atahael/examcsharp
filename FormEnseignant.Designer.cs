namespace tp_examc_
{
    partial class FormEnseignant
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cbEtudiants;
        private ComboBox cbModules;
        private TextBox txtNote;
        private Button btnAjouterNote;
        private Label lblEtudiant;
        private Label lblModule;
        private Label lblNote;

        private void InitializeComponent()
        {
            this.cbEtudiants = new ComboBox();
            this.cbModules = new ComboBox();
            this.txtNote = new TextBox();
            this.btnAjouterNote = new Button();
            this.lblEtudiant = new Label();
            this.lblModule = new Label();
            this.lblNote = new Label();
            this.SuspendLayout();

            this.lblEtudiant.Text = "Étudiant:";
            this.lblEtudiant.Location = new System.Drawing.Point(20, 20);

            this.cbEtudiants.Location = new System.Drawing.Point(130, 20);
            this.cbEtudiants.Size = new System.Drawing.Size(200, 20);

            this.lblModule.Text = "Module:";
            this.lblModule.Location = new System.Drawing.Point(20, 60);

            this.cbModules.Location = new System.Drawing.Point(130, 60);
            this.cbModules.Size = new System.Drawing.Size(200, 20);

            this.lblNote.Text = "Note:";
            this.lblNote.Location = new System.Drawing.Point(20, 100);

            this.txtNote.Location = new System.Drawing.Point(130, 100);
            this.txtNote.Size = new System.Drawing.Size(200, 20);

            this.btnAjouterNote.Text = "Ajouter Note";
            this.btnAjouterNote.Location = new System.Drawing.Point(130, 140);
            this.btnAjouterNote.Click += new System.EventHandler(this.btnAjouterNote_Click);

            this.ClientSize = new System.Drawing.Size(380, 200);
            this.Controls.Add(this.lblEtudiant);
            this.Controls.Add(this.cbEtudiants);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.cbModules);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnAjouterNote);
            this.Name = "FormEnseignant";
            this.Text = "Ajout de Notes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
