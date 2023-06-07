namespace MediaTek86.views
{
    partial class EditAbsenceForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label motifLabel;
        private System.Windows.Forms.ComboBox motifCb;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;

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
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.motifLabel = new System.Windows.Forms.Label();
            this.motifCb = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Start Date Label
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.startDateLabel.Location = new System.Drawing.Point(25, 25);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(100, 20);
            this.startDateLabel.TabIndex = 31;
            this.startDateLabel.Text = "Date de début :";
           
            // End Date Label
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.endDateLabel.Location = new System.Drawing.Point(250, 25);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(100, 20);
            this.endDateLabel.TabIndex = 32;
            this.endDateLabel.Text = "Date de fin :";
           
            // Motif Label
            this.motifLabel.AutoSize = true;
            this.motifLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.motifLabel.Location = new System.Drawing.Point(25, 90);
            this.motifLabel.Name = "motifLabel";
            this.motifLabel.Size = new System.Drawing.Size(100, 20);
            this.motifLabel.TabIndex = 33;
            this.motifLabel.Text = "Motif :";

            // Motif Cb
            this.motifCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.motifCb.FormattingEnabled = true;
            this.motifCb.Location = new System.Drawing.Point(100, 90);
            this.motifCb.Name = "motifCb";
            this.motifCb.Size = new System.Drawing.Size(150, 20);
            this.motifCb.TabIndex = 3;
            this.motifCb.DisplayMember = "libelle";

            // Dtp Start Date
            this.dtpStartDate.Location = new System.Drawing.Point(25, 50);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 1;

            // Dtp End Date
            this.dtpEndDate.Location = new System.Drawing.Point(250, 50);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 2;

            // Button Cancel
            this.buttonCancel.Location = new System.Drawing.Point(25, 150);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 20);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.handleCancel);

            // Button Save
            this.buttonSave.Location = new System.Drawing.Point(275, 150);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 20);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Enregistrer";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.handleEditAbsence);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.motifLabel);
            this.Controls.Add(this.motifCb);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "EditAbsenceView";
            this.Text = "Editer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}