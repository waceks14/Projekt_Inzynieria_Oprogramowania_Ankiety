namespace _3_MiniPaint
{
    partial class Form1
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
            this.rysunek = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonColorLinii = new System.Windows.Forms.Button();
            this.radioLinia = new System.Windows.Forms.RadioButton();
            this.radioElipsa = new System.Windows.Forms.RadioButton();
            this.buttonColorWypelnienia = new System.Windows.Forms.Button();
            this.checkBoxCzyWypelnienie = new System.Windows.Forms.CheckBox();
            this.radioProstokat = new System.Windows.Forms.RadioButton();
            this.radioKrzywa = new System.Windows.Forms.RadioButton();
            this.groupaKsztalt = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGrubosc = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.rysunek)).BeginInit();
            this.groupaKsztalt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrubosc)).BeginInit();
            this.SuspendLayout();
            // 
            // rysunek
            // 
            this.rysunek.Location = new System.Drawing.Point(13, 13);
            this.rysunek.Name = "rysunek";
            this.rysunek.Size = new System.Drawing.Size(259, 237);
            this.rysunek.TabIndex = 0;
            this.rysunek.TabStop = false;
            this.rysunek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rysunek_MouseDown);
            this.rysunek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rysunek_MouseMove);
            this.rysunek.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rysunek_MouseUp);
            // 
            // buttonColorLinii
            // 
            this.buttonColorLinii.Location = new System.Drawing.Point(279, 13);
            this.buttonColorLinii.Name = "buttonColorLinii";
            this.buttonColorLinii.Size = new System.Drawing.Size(75, 23);
            this.buttonColorLinii.TabIndex = 1;
            this.buttonColorLinii.UseVisualStyleBackColor = true;
            this.buttonColorLinii.Click += new System.EventHandler(this.buttonColorLinii_Click);
            // 
            // radioLinia
            // 
            this.radioLinia.AutoSize = true;
            this.radioLinia.Location = new System.Drawing.Point(6, 44);
            this.radioLinia.Name = "radioLinia";
            this.radioLinia.Size = new System.Drawing.Size(47, 17);
            this.radioLinia.TabIndex = 2;
            this.radioLinia.TabStop = true;
            this.radioLinia.Text = "Linia";
            this.radioLinia.UseVisualStyleBackColor = true;
            // 
            // radioElipsa
            // 
            this.radioElipsa.AutoSize = true;
            this.radioElipsa.Location = new System.Drawing.Point(6, 67);
            this.radioElipsa.Name = "radioElipsa";
            this.radioElipsa.Size = new System.Drawing.Size(53, 17);
            this.radioElipsa.TabIndex = 3;
            this.radioElipsa.TabStop = true;
            this.radioElipsa.Text = "Elipsa";
            this.radioElipsa.UseVisualStyleBackColor = true;
            // 
            // buttonColorWypelnienia
            // 
            this.buttonColorWypelnienia.Location = new System.Drawing.Point(334, 27);
            this.buttonColorWypelnienia.Name = "buttonColorWypelnienia";
            this.buttonColorWypelnienia.Size = new System.Drawing.Size(75, 23);
            this.buttonColorWypelnienia.TabIndex = 4;
            this.buttonColorWypelnienia.UseVisualStyleBackColor = true;
            this.buttonColorWypelnienia.Click += new System.EventHandler(this.buttonColorWypelnienia_Click);
            // 
            // checkBoxCzyWypelnienie
            // 
            this.checkBoxCzyWypelnienie.AutoSize = true;
            this.checkBoxCzyWypelnienie.Location = new System.Drawing.Point(289, 107);
            this.checkBoxCzyWypelnienie.Name = "checkBoxCzyWypelnienie";
            this.checkBoxCzyWypelnienie.Size = new System.Drawing.Size(109, 17);
            this.checkBoxCzyWypelnienie.TabIndex = 5;
            this.checkBoxCzyWypelnienie.Text = "Czy wypełnienie?";
            this.checkBoxCzyWypelnienie.UseVisualStyleBackColor = true;
            // 
            // radioProstokat
            // 
            this.radioProstokat.AutoSize = true;
            this.radioProstokat.Location = new System.Drawing.Point(6, 90);
            this.radioProstokat.Name = "radioProstokat";
            this.radioProstokat.Size = new System.Drawing.Size(70, 17);
            this.radioProstokat.TabIndex = 6;
            this.radioProstokat.TabStop = true;
            this.radioProstokat.Text = "Prostokat";
            this.radioProstokat.UseVisualStyleBackColor = true;
            // 
            // radioKrzywa
            // 
            this.radioKrzywa.AutoSize = true;
            this.radioKrzywa.Location = new System.Drawing.Point(6, 21);
            this.radioKrzywa.Name = "radioKrzywa";
            this.radioKrzywa.Size = new System.Drawing.Size(59, 17);
            this.radioKrzywa.TabIndex = 7;
            this.radioKrzywa.TabStop = true;
            this.radioKrzywa.Text = "Krzywa";
            this.radioKrzywa.UseVisualStyleBackColor = true;
            // 
            // groupaKsztalt
            // 
            this.groupaKsztalt.Controls.Add(this.radioKrzywa);
            this.groupaKsztalt.Controls.Add(this.radioProstokat);
            this.groupaKsztalt.Controls.Add(this.radioElipsa);
            this.groupaKsztalt.Controls.Add(this.radioLinia);
            this.groupaKsztalt.Location = new System.Drawing.Point(289, 130);
            this.groupaKsztalt.Name = "groupaKsztalt";
            this.groupaKsztalt.Size = new System.Drawing.Size(98, 120);
            this.groupaKsztalt.TabIndex = 8;
            this.groupaKsztalt.TabStop = false;
            this.groupaKsztalt.Text = "Kształt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Grubość linii";
            // 
            // tbGrubosc
            // 
            this.tbGrubosc.Location = new System.Drawing.Point(360, 57);
            this.tbGrubosc.Name = "tbGrubosc";
            this.tbGrubosc.Size = new System.Drawing.Size(59, 45);
            this.tbGrubosc.TabIndex = 10;
            this.tbGrubosc.Scroll += new System.EventHandler(this.tbGrubosc_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 262);
            this.Controls.Add(this.tbGrubosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupaKsztalt);
            this.Controls.Add(this.checkBoxCzyWypelnienie);
            this.Controls.Add(this.buttonColorWypelnienia);
            this.Controls.Add(this.buttonColorLinii);
            this.Controls.Add(this.rysunek);
            this.Name = "Form1";
            this.Text = "MiniPaint";
            ((System.ComponentModel.ISupportInitialize)(this.rysunek)).EndInit();
            this.groupaKsztalt.ResumeLayout(false);
            this.groupaKsztalt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrubosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rysunek;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonColorLinii;
        private System.Windows.Forms.RadioButton radioLinia;
        private System.Windows.Forms.RadioButton radioElipsa;
        private System.Windows.Forms.Button buttonColorWypelnienia;
        private System.Windows.Forms.CheckBox checkBoxCzyWypelnienie;
        private System.Windows.Forms.RadioButton radioProstokat;
        private System.Windows.Forms.RadioButton radioKrzywa;
        private System.Windows.Forms.GroupBox groupaKsztalt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbGrubosc;
    }
}

