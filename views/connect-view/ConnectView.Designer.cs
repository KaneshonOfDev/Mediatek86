namespace MediaTek86.views
{
    partial class ConnectForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button button;

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
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();

            /// Login Label
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.loginLabel.Location = new System.Drawing.Point(25, 20);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(100, 20);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login :";

            /// Login Text
            this.loginText.Location = new System.Drawing.Point(125, 20);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(100, 20);
            this.loginText.TabIndex = 1;

            /// Password Label
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.passwordLabel.Location = new System.Drawing.Point(25, 50);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 20);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Mot de passe :";

            /// Password Text
            this.passwordText.Location = new System.Drawing.Point(125, 50);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 2;

            // Button
            this.button.Location = new System.Drawing.Point(75, 85);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 20);
            this.button.TabIndex = 3;
            this.button.Text = "Se Connecter";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.handleLogin);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 125);
            this.Controls.Add(this.button);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "ConnectForm";
            this.Text = "Se Connecter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}