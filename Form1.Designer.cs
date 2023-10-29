namespace DegreeOfHarm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            lblResult = new Label();
            btnAnalyze = new Button();
            txtDiagnoses = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 51, 107);
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(btnAnalyze);
            panel1.Controls.Add(txtDiagnoses);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 587);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(12, 540);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(303, 24);
            lblResult.TabIndex = 4;
            lblResult.Text = " Степень вреда здоровью - ";
            // 
            // btnAnalyze
            // 
            btnAnalyze.BackColor = Color.FromArgb(124, 116, 194);
            btnAnalyze.Cursor = Cursors.Hand;
            btnAnalyze.FlatAppearance.BorderColor = Color.White;
            btnAnalyze.FlatAppearance.BorderSize = 2;
            btnAnalyze.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 91, 148);
            btnAnalyze.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 116, 163);
            btnAnalyze.FlatStyle = FlatStyle.Flat;
            btnAnalyze.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnalyze.ForeColor = SystemColors.ButtonHighlight;
            btnAnalyze.Location = new Point(883, 279);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(146, 54);
            btnAnalyze.TabIndex = 5;
            btnAnalyze.Text = "OK";
            btnAnalyze.UseVisualStyleBackColor = false;
            btnAnalyze.Click += button1_Click;
            // 
            // txtDiagnoses
            // 
            txtDiagnoses.BackColor = Color.White;
            txtDiagnoses.BorderStyle = BorderStyle.FixedSingle;
            txtDiagnoses.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiagnoses.ForeColor = Color.Black;
            txtDiagnoses.Location = new Point(12, 217);
            txtDiagnoses.Multiline = true;
            txtDiagnoses.Name = "txtDiagnoses";
            txtDiagnoses.Size = new Size(1017, 36);
            txtDiagnoses.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(12, 171);
            label3.Name = "label3";
            label3.Size = new Size(532, 29);
            label3.TabIndex = 1;
            label3.Text = "Введите диагнозы пациента через \" ; \" без пробелов";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(139, 150, 204);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1041, 100);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(124, 116, 194);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1020, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 24);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(124, 116, 194);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1041, 100);
            label1.TabIndex = 0;
            label1.Text = "Медицинские критерии степени вреда здоровью";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 162, 237);
            ClientSize = new Size(1041, 587);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Degree";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtDiagnoses;
        private Label lblResult;
        private Button btnAnalyze;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private FileSystemWatcher fileSystemWatcher1;
    }
}