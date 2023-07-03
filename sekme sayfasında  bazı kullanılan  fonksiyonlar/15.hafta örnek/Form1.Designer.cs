namespace _15.hafta_örnek
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            button2 = new Button();
            tabPage2 = new TabPage();
            label1 = new Label();
            button1 = new Button();
            tabPage3 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            button3 = new Button();
            tabPage4 = new TabPage();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            tabPage5 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(769, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(539, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "fontDialog";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 149);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "font dialog değitşir";
            // 
            // button2
            // 
            button2.Location = new Point(95, 128);
            button2.Name = "button2";
            button2.Size = new Size(107, 57);
            button2.TabIndex = 0;
            button2.Text = "font Değiştir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(539, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "colordialog";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 134);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "örn metin";
            // 
            // button1
            // 
            button1.Location = new Point(251, 130);
            button1.Name = "button1";
            button1.Size = new Size(98, 23);
            button1.TabIndex = 0;
            button1.Text = "renk değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(button3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(539, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "folder browser dialog";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 150);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 149);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 1;
            label3.Text = "seçilen klasör:";
            // 
            // button3
            // 
            button3.Location = new Point(85, 118);
            button3.Name = "button3";
            button3.Size = new Size(127, 69);
            button3.TabIndex = 0;
            button3.Text = "klasör seç";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(button4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(761, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "openFileDialog";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 139);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(220, 139);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 4;
            label6.Text = "seçilen dosya:";
            // 
            // button4
            // 
            button4.Location = new Point(75, 107);
            button4.Name = "button4";
            button4.Size = new Size(127, 69);
            button4.TabIndex = 3;
            button4.Text = "dosya seç";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(761, 422);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "saveFile Dialog";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Button button1;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private Label label2;
        private Button button2;
        private TabPage tabPage3;
        private Label label3;
        private Button button3;
        private Label label4;
        private FolderBrowserDialog folderBrowserDialog1;
        private TabPage tabPage4;
        private OpenFileDialog openFileDialog1;
        private Label label5;
        private Label label6;
        private Button button4;
        private TabPage tabPage5;
    }
}