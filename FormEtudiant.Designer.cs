namespace tp_examc_
{
    partial class FormEtudiant
    {
        private System.ComponentModel.IContainer components = null;
        private ListView listViewNotes;
        private ColumnHeader columnMatiere;
        private ColumnHeader columnNote;

        private void InitializeComponent()
        {
            this.listViewNotes = new ListView();
            this.columnMatiere = new ColumnHeader();
            this.columnNote = new ColumnHeader();
            this.SuspendLayout();

            // listViewNotes
            this.listViewNotes.Columns.AddRange(new ColumnHeader[] {
                this.columnMatiere,
                this.columnNote
            });
            this.listViewNotes.Location = new System.Drawing.Point(20, 20);
            this.listViewNotes.Size = new System.Drawing.Size(340, 200);
            this.listViewNotes.View = View.Details;
            this.columnMatiere.Text = "Matière";
            this.columnMatiere.Width = 200;
            this.columnNote.Text = "Note";
            this.columnNote.Width = 100;

            // FormEtudiant
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.listViewNotes);
            this.Name = "FormEtudiant";
            this.Text = "Mes Notes";
            this.ResumeLayout(false);
        }
    }
}
