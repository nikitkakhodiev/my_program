namespace chto_to
{
    partial class антивирус
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(антивирус));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(588, 411);
            button1.Name = "button1";
            button1.Size = new Size(193, 108);
            button1.TabIndex = 1;
            button1.Text = "Запустить сканирование";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(523, 256);
            label1.Name = "label1";
            label1.Size = new Size(333, 41);
            label1.TabIndex = 2;
            label1.Text = "Антивирус";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(609, 356);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 3;
            label2.Text = "Проверяется: C:\\Windws\\";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(634, 371);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 4;
            label3.Text = "Проверяется: C:\\";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(588, 546);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(185, 42);
            progressBar1.TabIndex = 5;
            progressBar1.Value = 3;
            progressBar1.Click += progressBar1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // антивирус
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 751);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "антивирус";
            Text = "антивирус";
            Load += антивирус_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private OpenFileDialog openFileDialog1;
    }
}