namespace MediaTek86.views
{
    partial class AddAbsenceForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label motifLabel;
        private System.Windows.Forms.ComboBox motifCb;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.motifLabel = new System.Windows.Forms.Label();
            this.motifCb = new System.Windows.Forms.ComboBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // First Name Label
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font =new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.firstNameLabel.Location = new System.Drawing.Point(25, 25);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(100, 19);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "Prenom :";

            // Name Label
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font =new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nameLabel.Location = new System.Drawing.Point(25, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 20);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Nom :";

            // Start Date Label
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font =new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.startDateLabel.Location = new System.Drawing.Point(25, 75);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(100, 20);
            this.startDateLabel.TabIndex = 31;
            this.startDateLabel.Text = "Date de début :";
           
            // End Date Label
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.endDateLabel.Location = new System.Drawing.Point(250, 75);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(100, 20);
            this.endDateLabel.TabIndex = 32;
            this.endDateLabel.Text = "Date de fin :";

            // Motif Label
            this.motifLabel.AutoSize = true;
            this.motifLabel.Font =new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.motifLabel.Location = new System.Drawing.Point(25, 125);
            this.motifLabel.Name = "motifLabel";
            this.motifLabel.Size = new System.Drawing.Size(100, 20);
            this.motifLabel.TabIndex = 23;
            this.motifLabel.Text = "Motif :";

            // Service Cb
            this.motifCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.motifCb.FormattingEnabled = true;
            this.motifCb.Location = new System.Drawing.Point(125, 125);
            this.motifCb.Name = "motifCb";
            this.motifCb.Size = new System.Drawing.Size(125, 20);
            this.motifCb.TabIndex = 5;
            this.motifCb.DisplayMember = "libelle";

            // First Name Text
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.firstNameText.Location = new System.Drawing.Point(125, 50);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(125, 20);
            this.firstNameText.TabIndex = 2;

            // Name Text
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nameText.Location = new System.Drawing.Point(125, 25);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(125, 20);
            this.nameText.TabIndex = 1;

            // Dtp Start Date
            this.dtpStartDate.Location = new System.Drawing.Point(25, 100);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 1;

            // Dtp End Date
            this.dtpEndDate.Location = new System.Drawing.Point(250, 100);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 2;

             // Button Cancel
            this.buttonCancel.Location = new System.Drawing.Point(25, 180);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 20);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;

            // Button Add
            this.buttonAdd.Location = new System.Drawing.Point(275, 180);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 20);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 225);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.motifCb);
            this.Controls.Add(this.motifLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddAbsenceForm";
            this.Text = "Ajouter une absence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}