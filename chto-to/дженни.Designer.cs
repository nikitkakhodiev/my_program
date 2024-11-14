namespace chto_to
{
    partial class дженни
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(141, 341);
            label1.Name = "label1";
            label1.Size = new Size(847, 65);
            label1.TabIndex = 0;
            label1.Text = "link:https://www.mooks.ru/mods/jenny";
            // 
            // дженни
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 754);
            Controls.Add(label1);
            Cursor = Cursors.Cross;
            Name = "дженни";
            Text = "дженни";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}