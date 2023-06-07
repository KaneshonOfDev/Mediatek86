namespace MediaTek86.views
{
    partial class AddStaffForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.ComboBox serviceCb;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox emailText;
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
            this.serviceCb = new System.Windows.Forms.ComboBox();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // First Name Label
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.firstNameLabel.Location = new System.Drawing.Point(25, 25);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(100, 19);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "Prenom :";

            // Name Label
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nameLabel.Location = new System.Drawing.Point(25, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 20);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Nom :";

            // Phone Label
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.phoneLabel.Location = new System.Drawing.Point(25, 75);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(100, 19);
            this.phoneLabel.TabIndex = 16;
            this.phoneLabel.Text = "Téléphone :";

            // Email Label
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.emailLabel.Location = new System.Drawing.Point(25, 100);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 19);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "Mail :";

            // Service Label
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.serviceLabel.Location = new System.Drawing.Point(25, 125);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(100, 20);
            this.serviceLabel.TabIndex = 23;
            this.serviceLabel.Text = "Service :";

            // Service Cb
            this.serviceCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.serviceCb.FormattingEnabled = true;
            this.serviceCb.Location = new System.Drawing.Point(125, 125);
            this.serviceCb.Name = "serviceCb";
            this.serviceCb.Size = new System.Drawing.Size(125, 20);
            this.serviceCb.TabIndex = 9;
            this.serviceCb.DisplayMember = "nom";

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

            // Phone Text
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.phoneText.Location = new System.Drawing.Point(125, 75);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(125, 20);
            this.phoneText.TabIndex = 3;

            // Email Text
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.emailText.Location = new System.Drawing.Point(125, 100);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(125, 20);
            this.emailText.TabIndex = 4;

            // Button Cancel
            this.buttonCancel.Location = new System.Drawing.Point(25, 180);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 20);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.handleCancel);

            // Button Add
            this.buttonAdd.Location = new System.Drawing.Point(150, 180);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 20);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.handleAddStaff);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 225);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.serviceCb);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddStaffForm";
            this.Text = "Ajouter au personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}