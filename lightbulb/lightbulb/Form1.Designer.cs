namespace lightbulb
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
            this.LightON = new System.Windows.Forms.PictureBox();
            this.LightOff = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LightON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightOff)).BeginInit();
            this.SuspendLayout();
            // 
            // LightON
            // 
            this.LightON.Image = global::lightbulb.Properties.Resources.Lighton;
            this.LightON.Location = new System.Drawing.Point(0, 0);
            this.LightON.Name = "LightON";
            this.LightON.Size = new System.Drawing.Size(436, 355);
            this.LightON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LightON.TabIndex = 0;
            this.LightON.TabStop = false;
            this.LightON.Visible = false;
            // 
            // LightOff
            // 
            this.LightOff.Image = global::lightbulb.Properties.Resources.Lightoff;
            this.LightOff.Location = new System.Drawing.Point(0, 0);
            this.LightOff.Name = "LightOff";
            this.LightOff.Size = new System.Drawing.Size(436, 355);
            this.LightOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LightOff.TabIndex = 1;
            this.LightOff.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(572, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "OFF";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(510, 288);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(75, 23);
            this.buttonOn.TabIndex = 3;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(614, 288);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(75, 23);
            this.buttonOff.TabIndex = 4;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LightOff);
            this.Controls.Add(this.LightON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LightON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox LightON;
        private PictureBox LightOff;
        private Label label1;
        private Button buttonOn;
        private Button buttonOff;
    }
}