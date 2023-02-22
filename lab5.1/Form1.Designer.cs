namespace lab5._1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Button();
            this.extraSpaces = new System.Windows.Forms.Button();
            this.postalCode = new System.Windows.Forms.Button();
            this.deleteLetter = new System.Windows.Forms.Button();
            this.array = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the text to validate:";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(236, 45);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(385, 22);
            this.text.TabIndex = 1;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.Control;
            this.email.Location = new System.Drawing.Point(32, 94);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(117, 68);
            this.email.TabIndex = 2;
            this.email.Text = "Check E-mail";
            this.email.UseVisualStyleBackColor = false;
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // extraSpaces
            // 
            this.extraSpaces.BackColor = System.Drawing.SystemColors.Control;
            this.extraSpaces.Location = new System.Drawing.Point(150, 94);
            this.extraSpaces.Name = "extraSpaces";
            this.extraSpaces.Size = new System.Drawing.Size(117, 68);
            this.extraSpaces.TabIndex = 3;
            this.extraSpaces.Text = "Delete extra spaces";
            this.extraSpaces.UseVisualStyleBackColor = false;
            this.extraSpaces.Click += new System.EventHandler(this.extraSpaces_Click);
            // 
            // postalCode
            // 
            this.postalCode.BackColor = System.Drawing.SystemColors.Control;
            this.postalCode.Location = new System.Drawing.Point(268, 94);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(117, 68);
            this.postalCode.TabIndex = 4;
            this.postalCode.Text = "Validate Postal Code";
            this.postalCode.UseVisualStyleBackColor = false;
            this.postalCode.Click += new System.EventHandler(this.postalCode_Click);
            // 
            // deleteLetter
            // 
            this.deleteLetter.BackColor = System.Drawing.SystemColors.Control;
            this.deleteLetter.Location = new System.Drawing.Point(386, 94);
            this.deleteLetter.Name = "deleteLetter";
            this.deleteLetter.Size = new System.Drawing.Size(117, 68);
            this.deleteLetter.TabIndex = 5;
            this.deleteLetter.Text = "Delete letter a, b, c and d";
            this.deleteLetter.UseVisualStyleBackColor = false;
            this.deleteLetter.Click += new System.EventHandler(this.deleteLetter_Click);
            // 
            // array
            // 
            this.array.BackColor = System.Drawing.SystemColors.Control;
            this.array.Location = new System.Drawing.Point(504, 94);
            this.array.Name = "array";
            this.array.Size = new System.Drawing.Size(117, 68);
            this.array.TabIndex = 6;
            this.array.Text = "Create an array of words";
            this.array.UseVisualStyleBackColor = false;
            this.array.Click += new System.EventHandler(this.array_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(516, 195);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(105, 25);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 257);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.array);
            this.Controls.Add(this.deleteLetter);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.extraSpaces);
            this.Controls.Add(this.email);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button email;
        private System.Windows.Forms.Button extraSpaces;
        private System.Windows.Forms.Button postalCode;
        private System.Windows.Forms.Button deleteLetter;
        private System.Windows.Forms.Button array;
        private System.Windows.Forms.Button exit;
    }
}

