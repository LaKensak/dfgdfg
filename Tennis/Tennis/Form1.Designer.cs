namespace Tennis
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
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_jouer = new Button();
            btn_quitter = new Button();
            btn_reset = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(124, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 285);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_jouer
            // 
            btn_jouer.Location = new Point(203, 326);
            btn_jouer.Name = "btn_jouer";
            btn_jouer.Size = new Size(75, 23);
            btn_jouer.TabIndex = 1;
            btn_jouer.Text = "Jouer";
            btn_jouer.UseVisualStyleBackColor = true;
            btn_jouer.Click += btn_jouer_Click;
            // 
            // btn_quitter
            // 
            btn_quitter.Location = new Point(538, 326);
            btn_quitter.Name = "btn_quitter";
            btn_quitter.Size = new Size(75, 23);
            btn_quitter.TabIndex = 2;
            btn_quitter.Text = "Quitter";
            btn_quitter.UseVisualStyleBackColor = true;
            btn_quitter.Click += btn_quitter_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(374, 326);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 0;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(868, 450);
            Controls.Add(btn_reset);
            Controls.Add(btn_quitter);
            Controls.Add(btn_jouer);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_jouer;
        private Button btn_quitter;
        private Button btn_reset;
    }
}
