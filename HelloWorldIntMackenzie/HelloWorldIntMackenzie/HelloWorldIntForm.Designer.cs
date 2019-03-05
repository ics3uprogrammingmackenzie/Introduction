namespace HelloWorldIntMackenzie
{
    partial class frmHelloWorldInt
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
            this.grbLanguage = new System.Windows.Forms.GroupBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.radEng = new System.Windows.Forms.RadioButton();
            this.radDutch = new System.Windows.Forms.RadioButton();
            this.radKorean = new System.Windows.Forms.RadioButton();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.grbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLanguage
            // 
            this.grbLanguage.Controls.Add(this.radGerman);
            this.grbLanguage.Controls.Add(this.radKorean);
            this.grbLanguage.Controls.Add(this.radDutch);
            this.grbLanguage.Controls.Add(this.radEng);
            this.grbLanguage.Location = new System.Drawing.Point(75, 249);
            this.grbLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbLanguage.Name = "grbLanguage";
            this.grbLanguage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbLanguage.Size = new System.Drawing.Size(612, 240);
            this.grbLanguage.TabIndex = 0;
            this.grbLanguage.TabStop = false;
            this.grbLanguage.Text = "language";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Swis721 BlkEx BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(237, 124);
            this.lblGreeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(304, 39);
            this.lblGreeting.TabIndex = 2;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // radEng
            // 
            this.radEng.AutoSize = true;
            this.radEng.Location = new System.Drawing.Point(60, 117);
            this.radEng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radEng.Name = "radEng";
            this.radEng.Size = new System.Drawing.Size(82, 24);
            this.radEng.TabIndex = 0;
            this.radEng.TabStop = true;
            this.radEng.Text = "English";
            this.radEng.UseVisualStyleBackColor = true;
            this.radEng.CheckedChanged += new System.EventHandler(this.radEng_CheckedChanged);
            // 
            // radDutch
            // 
            this.radDutch.AutoSize = true;
            this.radDutch.Location = new System.Drawing.Point(60, 205);
            this.radDutch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radDutch.Name = "radDutch";
            this.radDutch.Size = new System.Drawing.Size(72, 24);
            this.radDutch.TabIndex = 1;
            this.radDutch.TabStop = true;
            this.radDutch.Text = "Dutch";
            this.radDutch.UseVisualStyleBackColor = true;
            this.radDutch.CheckedChanged += new System.EventHandler(this.radDutch_CheckedChanged);
            // 
            // radKorean
            // 
            this.radKorean.AutoSize = true;
            this.radKorean.Location = new System.Drawing.Point(436, 205);
            this.radKorean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radKorean.Name = "radKorean";
            this.radKorean.Size = new System.Drawing.Size(80, 24);
            this.radKorean.TabIndex = 2;
            this.radKorean.TabStop = true;
            this.radKorean.Text = "Korean";
            this.radKorean.UseVisualStyleBackColor = true;
            this.radKorean.CheckedChanged += new System.EventHandler(this.radKorean_CheckedChanged);
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Location = new System.Drawing.Point(436, 117);
            this.radGerman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(87, 24);
            this.radGerman.TabIndex = 3;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "German";
            this.radGerman.UseVisualStyleBackColor = true;
            this.radGerman.CheckedChanged += new System.EventHandler(this.radGerman_CheckedChanged);
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 571);
            this.Controls.Add(this.grbLanguage);
            this.Controls.Add(this.lblGreeting);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World Internationl By Mackenzie";
            this.grbLanguage.ResumeLayout(false);
            this.grbLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLanguage;
        private System.Windows.Forms.RadioButton radGerman;
        private System.Windows.Forms.RadioButton radKorean;
        private System.Windows.Forms.RadioButton radDutch;
        private System.Windows.Forms.RadioButton radEng;
        private System.Windows.Forms.Label lblGreeting;
    }
}

