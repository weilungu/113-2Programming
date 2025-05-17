namespace 計時器
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
            lb_displayTime = new Label();
            btn_start = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lb_displayTime
            // 
            lb_displayTime.AutoSize = true;
            lb_displayTime.BackColor = SystemColors.ActiveBorder;
            lb_displayTime.Font = new Font("Microsoft JhengHei UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lb_displayTime.Location = new Point(113, 46);
            lb_displayTime.Name = "lb_displayTime";
            lb_displayTime.Size = new Size(181, 102);
            lb_displayTime.TabIndex = 0;
            lb_displayTime.Text = "100";
            // 
            // btn_start
            // 
            btn_start.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btn_start.ForeColor = SystemColors.MenuHighlight;
            btn_start.Location = new Point(131, 277);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(149, 83);
            btn_start.TabIndex = 1;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 450);
            Controls.Add(btn_start);
            Controls.Add(lb_displayTime);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_displayTime;
        private Button btn_start;
        private System.Windows.Forms.Timer timer1;
    }
}
