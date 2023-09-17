namespace Shapes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fNamelabel = new Label();
            FnametextBox = new TextBox();
            Lastnamelabel = new Label();
            cellphonelabel = new Label();
            IsAdminlabel = new Label();
            Lastnametextbox = new TextBox();
            CellphonetextBox = new TextBox();
            RoleNamelabel = new Label();
            AdmincheckBox = new CheckBox();
            Signupbutton = new Button();
            Genderlabel = new Label();
            AccessIDlabel = new Label();
            AccessIDtextBox = new TextBox();
            RateLabel = new Label();
            domainUpDown1 = new DomainUpDown();
            GenderComboBox = new ComboBox();
            RoleComboBox = new ComboBox();
            SuspendLayout();
            // 
            // fNamelabel
            // 
            fNamelabel.AutoSize = true;
            fNamelabel.Location = new Point(12, 57);
            fNamelabel.Name = "fNamelabel";
            fNamelabel.Size = new Size(134, 32);
            fNamelabel.TabIndex = 0;
            fNamelabel.Text = "First Name:";
            // 
            // FnametextBox
            // 
            FnametextBox.Location = new Point(203, 57);
            FnametextBox.Name = "FnametextBox";
            FnametextBox.Size = new Size(644, 39);
            FnametextBox.TabIndex = 1;
            // 
            // Lastnamelabel
            // 
            Lastnamelabel.AutoSize = true;
            Lastnamelabel.Location = new Point(12, 130);
            Lastnamelabel.Name = "Lastnamelabel";
            Lastnamelabel.Size = new Size(131, 32);
            Lastnamelabel.TabIndex = 2;
            Lastnamelabel.Text = "Last Name:";
            // 
            // cellphonelabel
            // 
            cellphonelabel.AutoSize = true;
            cellphonelabel.Location = new Point(12, 209);
            cellphonelabel.Name = "cellphonelabel";
            cellphonelabel.Size = new Size(128, 32);
            cellphonelabel.TabIndex = 3;
            cellphonelabel.Text = "Cellphone:";
            // 
            // IsAdminlabel
            // 
            IsAdminlabel.AutoSize = true;
            IsAdminlabel.Location = new Point(12, 367);
            IsAdminlabel.Name = "IsAdminlabel";
            IsAdminlabel.Size = new Size(105, 32);
            IsAdminlabel.TabIndex = 4;
            IsAdminlabel.Text = "IsAdmin:";
            // 
            // Lastnametextbox
            // 
            Lastnametextbox.Location = new Point(203, 123);
            Lastnametextbox.Name = "Lastnametextbox";
            Lastnametextbox.Size = new Size(644, 39);
            Lastnametextbox.TabIndex = 5;
            // 
            // CellphonetextBox
            // 
            CellphonetextBox.Location = new Point(203, 206);
            CellphonetextBox.Name = "CellphonetextBox";
            CellphonetextBox.Size = new Size(644, 39);
            CellphonetextBox.TabIndex = 6;
            // 
            // RoleNamelabel
            // 
            RoleNamelabel.AutoSize = true;
            RoleNamelabel.Enabled = false;
            RoleNamelabel.Location = new Point(12, 448);
            RoleNamelabel.Name = "RoleNamelabel";
            RoleNamelabel.Size = new Size(136, 32);
            RoleNamelabel.TabIndex = 8;
            RoleNamelabel.Text = "Role Name:";
            RoleNamelabel.EnabledChanged += AdmincheckBox_CheckedChanged;
            // 
            // AdmincheckBox
            // 
            AdmincheckBox.AutoSize = true;
            AdmincheckBox.BackColor = SystemColors.Highlight;
            AdmincheckBox.Location = new Point(203, 367);
            AdmincheckBox.Name = "AdmincheckBox";
            AdmincheckBox.Size = new Size(28, 27);
            AdmincheckBox.TabIndex = 9;
            AdmincheckBox.UseVisualStyleBackColor = false;
            AdmincheckBox.CheckedChanged += AdmincheckBox_CheckedChanged;
            AdmincheckBox.EnabledChanged += Signupbutton_Click;
            // 
            // Signupbutton
            // 
            Signupbutton.BackColor = SystemColors.ButtonShadow;
            Signupbutton.Location = new Point(660, 519);
            Signupbutton.Name = "Signupbutton";
            Signupbutton.Size = new Size(202, 77);
            Signupbutton.TabIndex = 10;
            Signupbutton.Text = "Sign Up";
            Signupbutton.UseVisualStyleBackColor = false;
            Signupbutton.Click += Signupbutton_Click;
            // 
            // Genderlabel
            // 
            Genderlabel.AutoSize = true;
            Genderlabel.Location = new Point(12, 295);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.Size = new Size(92, 32);
            Genderlabel.TabIndex = 11;
            Genderlabel.Text = "Gender";
            // 
            // AccessIDlabel
            // 
            AccessIDlabel.AutoSize = true;
            AccessIDlabel.Enabled = false;
            AccessIDlabel.Location = new Point(12, 506);
            AccessIDlabel.Name = "AccessIDlabel";
            AccessIDlabel.Size = new Size(119, 32);
            AccessIDlabel.TabIndex = 13;
            AccessIDlabel.Text = "Access ID:";
            AccessIDlabel.EnabledChanged += AdmincheckBox_CheckedChanged;
            // 
            // AccessIDtextBox
            // 
            AccessIDtextBox.Enabled = false;
            AccessIDtextBox.Location = new Point(203, 506);
            AccessIDtextBox.Name = "AccessIDtextBox";
            AccessIDtextBox.Size = new Size(259, 39);
            AccessIDtextBox.TabIndex = 14;
            AccessIDtextBox.EnabledChanged += AdmincheckBox_CheckedChanged;
            // 
            // RateLabel
            // 
            RateLabel.AutoSize = true;
            RateLabel.Location = new Point(12, 579);
            RateLabel.Name = "RateLabel";
            RateLabel.Size = new Size(153, 32);
            RateLabel.TabIndex = 15;
            RateLabel.Text = "Rate our site:";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("0");
            domainUpDown1.Items.Add("0.5");
            domainUpDown1.Items.Add("1");
            domainUpDown1.Items.Add("1.5");
            domainUpDown1.Items.Add("2");
            domainUpDown1.Items.Add("2.5");
            domainUpDown1.Items.Add("3");
            domainUpDown1.Items.Add("3.5");
            domainUpDown1.Items.Add("4");
            domainUpDown1.Items.Add("4.5");
            domainUpDown1.Items.Add("5");
            domainUpDown1.Location = new Point(203, 572);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(259, 39);
            domainUpDown1.TabIndex = 16;
            domainUpDown1.Text = "Choose";
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Location = new Point(203, 287);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(325, 40);
            GenderComboBox.TabIndex = 17;
            // 
            // RoleComboBox
            // 
            RoleComboBox.Enabled = false;
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Location = new Point(203, 440);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(325, 40);
            RoleComboBox.TabIndex = 18;
            RoleComboBox.EnabledChanged += AdmincheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 671);
            Controls.Add(RoleComboBox);
            Controls.Add(GenderComboBox);
            Controls.Add(domainUpDown1);
            Controls.Add(RateLabel);
            Controls.Add(AccessIDtextBox);
            Controls.Add(AccessIDlabel);
            Controls.Add(Genderlabel);
            Controls.Add(Signupbutton);
            Controls.Add(AdmincheckBox);
            Controls.Add(RoleNamelabel);
            Controls.Add(CellphonetextBox);
            Controls.Add(Lastnametextbox);
            Controls.Add(IsAdminlabel);
            Controls.Add(cellphonelabel);
            Controls.Add(Lastnamelabel);
            Controls.Add(FnametextBox);
            Controls.Add(fNamelabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fNamelabel;
        private TextBox FnametextBox;
        private Label Lastnamelabel;
        private Label cellphonelabel;
        private Label IsAdminlabel;
        private TextBox Lastnametextbox;
        private TextBox CellphonetextBox;
        private Label RoleNamelabel;
        private CheckBox AdmincheckBox;
        private Button Signupbutton;
        private Label Genderlabel;
        private Label AccessIDlabel;
        private TextBox AccessIDtextBox;
        private Label RateLabel;
        private DomainUpDown domainUpDown1;
        private ComboBox GenderComboBox;
        private ComboBox RoleComboBox;
    }
}