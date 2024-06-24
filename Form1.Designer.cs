namespace InstallShieldWizard
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
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(205, 190);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(356, 23);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 319);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 316);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 64);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("새굴림", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(205, 34);
            label1.Name = "label1";
            label1.Size = new Size(145, 12);
            label1.TabIndex = 3;
            label1.Text = "Preparing to Install...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("굴림", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(205, 94);
            label2.Name = "label2";
            label2.Size = new Size(336, 36);
            label2.TabIndex = 4;
            label2.Text = "Install 11 Setup is preparing the Install Wizard, \r\nwhitch will guide you through the program setup process. \r\nPlease wait.";
            // 
            // button1
            // 
            button1.Location = new Point(462, 19);
            button1.Name = "button1";
            button1.Size = new Size(116, 28);
            button1.TabIndex = 0;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("굴림", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(205, 167);
            label3.Name = "label3";
            label3.Size = new Size(178, 12);
            label3.TabIndex = 5;
            label3.Text = "Extracting: InstallShield 11.msi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 380);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Install Wizard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}
