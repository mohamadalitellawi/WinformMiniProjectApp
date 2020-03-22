namespace WinformMiniProject
{
    partial class PersonEntry
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
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.listBoxAdressesList = new System.Windows.Forms.ListBox();
            this.lbAdresses = new System.Windows.Forms.Label();
            this.btAddAdress = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(22, 26);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(101, 24);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(160, 23);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(231, 28);
            this.tbFirstName.TabIndex = 1;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(22, 80);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(99, 24);
            this.lbLastName.TabIndex = 0;
            this.lbLastName.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(160, 78);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(231, 28);
            this.tbLastName.TabIndex = 2;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(160, 134);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(15, 14);
            this.cbIsActive.TabIndex = 3;
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Location = new System.Drawing.Point(22, 126);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(61, 24);
            this.lbIsActive.TabIndex = 0;
            this.lbIsActive.Text = "Active";
            // 
            // listBoxAdressesList
            // 
            this.listBoxAdressesList.FormattingEnabled = true;
            this.listBoxAdressesList.ItemHeight = 22;
            this.listBoxAdressesList.Location = new System.Drawing.Point(27, 226);
            this.listBoxAdressesList.Name = "listBoxAdressesList";
            this.listBoxAdressesList.Size = new System.Drawing.Size(364, 224);
            this.listBoxAdressesList.TabIndex = 3;
            this.listBoxAdressesList.TabStop = false;
            // 
            // lbAdresses
            // 
            this.lbAdresses.AutoSize = true;
            this.lbAdresses.Location = new System.Drawing.Point(22, 185);
            this.lbAdresses.Name = "lbAdresses";
            this.lbAdresses.Size = new System.Drawing.Size(89, 24);
            this.lbAdresses.TabIndex = 0;
            this.lbAdresses.Text = "Adresses";
            // 
            // btAddAdress
            // 
            this.btAddAdress.Location = new System.Drawing.Point(307, 178);
            this.btAddAdress.Name = "btAddAdress";
            this.btAddAdress.Size = new System.Drawing.Size(83, 43);
            this.btAddAdress.TabIndex = 4;
            this.btAddAdress.Text = "ADD";
            this.btAddAdress.UseVisualStyleBackColor = true;
            this.btAddAdress.Click += new System.EventHandler(this.btAddAdress_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(64, 456);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(283, 46);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // PersonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 533);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btAddAdress);
            this.Controls.Add(this.listBoxAdressesList);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbAdresses);
            this.Controls.Add(this.lbIsActive);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PersonEntry";
            this.Text = "Person Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.ListBox listBoxAdressesList;
        private System.Windows.Forms.Label lbAdresses;
        private System.Windows.Forms.Button btAddAdress;
        private System.Windows.Forms.Button btSave;
    }
}

