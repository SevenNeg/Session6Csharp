namespace Shapes
{
    partial class First_Page
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
            Labelwelcome = new Label();
            choseetextBox = new TextBox();
            SignInbutton = new Button();
            SignUpbutton = new Button();
            SuspendLayout();
            // 
            // Labelwelcome
            // 
            Labelwelcome.AutoSize = true;
            Labelwelcome.Font = new Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point);
            Labelwelcome.Location = new Point(231, 32);
            Labelwelcome.Name = "Labelwelcome";
            Labelwelcome.Size = new Size(437, 55);
            Labelwelcome.TabIndex = 1;
            Labelwelcome.Text = "Welcome to our form!";
            // 
            // choseetextBox
            // 
            choseetextBox.BackColor = SystemColors.ActiveBorder;
            choseetextBox.Location = new Point(247, 168);
            choseetextBox.Multiline = true;
            choseetextBox.Name = "choseetextBox";
            choseetextBox.Size = new Size(421, 76);
            choseetextBox.TabIndex = 2;
            choseetextBox.Text = "Choose one of the options below to continue:";
            // 
            // SignInbutton
            // 
            SignInbutton.BackColor = Color.CadetBlue;
            SignInbutton.Location = new Point(293, 295);
            SignInbutton.Name = "SignInbutton";
            SignInbutton.Size = new Size(306, 42);
            SignInbutton.TabIndex = 3;
            SignInbutton.Text = "Sign In";
            SignInbutton.UseVisualStyleBackColor = false;
            SignInbutton.Click += SignInbutton_Click;
            // 
            // SignUpbutton
            // 
            SignUpbutton.BackColor = Color.SkyBlue;
            SignUpbutton.Location = new Point(293, 370);
            SignUpbutton.Name = "SignUpbutton";
            SignUpbutton.Size = new Size(306, 42);
            SignUpbutton.TabIndex = 4;
            SignUpbutton.Text = "Sign Up";
            SignUpbutton.UseVisualStyleBackColor = false;
            SignUpbutton.Click += SignUpbutton_Click;
            // 
            // First_Page
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(962, 536);
            Controls.Add(SignUpbutton);
            Controls.Add(SignInbutton);
            Controls.Add(choseetextBox);
            Controls.Add(Labelwelcome);
            Name = "First_Page";
            Text = "First_Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Labelwelcome;
        private TextBox choseetextBox;
        private Button SignInbutton;
        private Button SignUpbutton;
    }
}