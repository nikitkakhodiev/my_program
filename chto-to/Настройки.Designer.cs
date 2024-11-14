namespace chto_to
{
    partial class Настройки
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Настройки));
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            checkBox4 = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(12, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(332, 36);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Включить ратник от лаффа";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox2.Location = new Point(11, 58);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(218, 36);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Врубить вирусы)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox3.Location = new Point(11, 101);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(208, 36);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Отключить UAC";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = SystemColors.Control;
            checkBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox4.Location = new Point(10, 147);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(112, 36);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "chto-to";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 21F);
            checkBox5.Location = new Point(10, 189);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(321, 42);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Скинуть 100 рубликов";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 178);
            checkBox6.Location = new Point(10, 237);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(969, 90);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Подписатся на nedohackers lite";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox7.Location = new Point(11, 319);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(605, 51);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Подписатся на Stelx, Nikitakhodiev";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // Настройки
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 792);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Настройки";
            Text = "Настройки";
            Load += Настройки_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ErrorProvider errorProvider1;
        private CheckBox checkBox4;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
    }
}