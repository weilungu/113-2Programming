namespace OXGame
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
            label1 = new Label();
            nextMarker = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(488, 88);
            label1.Name = "label1";
            label1.Size = new Size(126, 47);
            label1.TabIndex = 9;
            label1.Text = "Player";
            // 
            // nextMarker
            // 
            nextMarker.AutoSize = true;
            nextMarker.Font = new Font("Microsoft JhengHei UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 136);
            nextMarker.ForeColor = SystemColors.MenuHighlight;
            nextMarker.Location = new Point(502, 149);
            nextMarker.Name = "nextMarker";
            nextMarker.Size = new Size(96, 102);
            nextMarker.TabIndex = 10;
            nextMarker.Text = "X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(nextMarker);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic-Tac-Toe Game, By s1131375";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label nextMarker;
    }
}
