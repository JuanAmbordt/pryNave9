namespace pryNave9
{
    partial class Form2
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
            pctNavePrincipal = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pctNavePrincipal).BeginInit();
            SuspendLayout();
            // 
            // pctNavePrincipal
            // 
            pctNavePrincipal.BackColor = Color.Transparent;
            pctNavePrincipal.Image = Properties.Resources.navePrincipal;
            pctNavePrincipal.Location = new Point(448, 385);
            pctNavePrincipal.Name = "pctNavePrincipal";
            pctNavePrincipal.Size = new Size(74, 85);
            pctNavePrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            pctNavePrincipal.TabIndex = 0;
            pctNavePrincipal.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1208374691_612x612;
            ClientSize = new Size(1069, 509);
            Controls.Add(pctNavePrincipal);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pctNavePrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctNavePrincipal;
        private System.Windows.Forms.Timer timer1;
    }
}