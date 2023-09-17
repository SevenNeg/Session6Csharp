namespace Shapes
{
    partial class Signedin
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
            Donebutton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Firstnametxt = new TextBox();
            cellphonetxt = new TextBox();
            lastnametxt = new TextBox();
            Backbutton = new Button();
            SuspendLayout();
            // 
            // Donebutton
            // 
            Donebutton.BackColor = Color.DeepSkyBlue;
            Donebutton.Location = new Point(568, 357);
            Donebutton.Name = "Donebutton";
            Donebutton.Size = new Size(130, 43);
            Donebutton.TabIndex = 0;
            Donebutton.Text = "Done";
            Donebutton.UseVisualStyleBackColor = false;
            Donebutton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 57);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 1;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 139);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 2;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 210);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 3;
            label3.Text = "Cellphone";
            // 
            // Firstnametxt
            // 
            Firstnametxt.Location = new Point(190, 61);
            Firstnametxt.Name = "Firstnametxt";
            Firstnametxt.Size = new Size(289, 39);
            Firstnametxt.TabIndex = 4;
            // 
            // cellphonetxt
            // 
            cellphonetxt.Location = new Point(190, 203);
            cellphonetxt.Name = "cellphonetxt";
            cellphonetxt.Size = new Size(289, 39);
            cellphonetxt.TabIndex = 5;
            // 
            // lastnametxt
            // 
            lastnametxt.Location = new Point(190, 136);
            lastnametxt.Name = "lastnametxt";
            lastnametxt.Size = new Size(289, 39);
            lastnametxt.TabIndex = 6;
            // 
            // Backbutton
            // 
            Backbutton.BackColor = SystemColors.ButtonShadow;
            Backbutton.Location = new Point(39, 357);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(130, 43);
            Backbutton.TabIndex = 7;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = false;
            // 
            // Signedin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Backbutton);
            Controls.Add(lastnametxt);
            Controls.Add(cellphonetxt);
            Controls.Add(Firstnametxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Donebutton);
            Name = "Signedin";
            Text = "Signedin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Donebutton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Firstnametxt;
        private TextBox cellphonetxt;
        private TextBox lastnametxt;
        private Button Backbutton;
    }
}