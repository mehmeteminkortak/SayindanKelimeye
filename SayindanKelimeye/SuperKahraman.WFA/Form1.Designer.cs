namespace SuperKahraman.WFA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLazer = new System.Windows.Forms.Button();
            this.btnIndir = new System.Windows.Forms.Button();
            this.btnUcur = new System.Windows.Forms.Button();
            this.lazerBar = new System.Windows.Forms.ProgressBar();
            this.gbSuperman = new System.Windows.Forms.GroupBox();
            this.rbSuperman = new System.Windows.Forms.RadioButton();
            this.rbClarkKent = new System.Windows.Forms.RadioButton();
            this.pbHero = new System.Windows.Forms.PictureBox();
            this.cmbKahramanlar = new System.Windows.Forms.ComboBox();
            this.heroResimler = new System.Windows.Forms.ImageList(this.components);
            this.gbSuperman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLazer
            // 
            this.btnLazer.Location = new System.Drawing.Point(181, 232);
            this.btnLazer.Name = "btnLazer";
            this.btnLazer.Size = new System.Drawing.Size(76, 56);
            this.btnLazer.TabIndex = 13;
            this.btnLazer.Text = "Lazer Çıkart";
            this.btnLazer.UseVisualStyleBackColor = true;
            this.btnLazer.Click += new System.EventHandler(this.btnLazer_Click);
            // 
            // btnIndir
            // 
            this.btnIndir.Location = new System.Drawing.Point(96, 232);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(76, 56);
            this.btnIndir.TabIndex = 12;
            this.btnIndir.Text = "İndir";
            this.btnIndir.UseVisualStyleBackColor = true;
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // btnUcur
            // 
            this.btnUcur.Location = new System.Drawing.Point(11, 232);
            this.btnUcur.Name = "btnUcur";
            this.btnUcur.Size = new System.Drawing.Size(76, 56);
            this.btnUcur.TabIndex = 11;
            this.btnUcur.Text = "Uçur";
            this.btnUcur.UseVisualStyleBackColor = true;
            this.btnUcur.Click += new System.EventHandler(this.btnUcur_Click);
            // 
            // lazerBar
            // 
            this.lazerBar.BackColor = System.Drawing.Color.Red;
            this.lazerBar.ForeColor = System.Drawing.Color.Red;
            this.lazerBar.Location = new System.Drawing.Point(12, 294);
            this.lazerBar.Name = "lazerBar";
            this.lazerBar.Size = new System.Drawing.Size(465, 33);
            this.lazerBar.Step = 1;
            this.lazerBar.TabIndex = 10;
            // 
            // gbSuperman
            // 
            this.gbSuperman.Controls.Add(this.rbSuperman);
            this.gbSuperman.Controls.Add(this.rbClarkKent);
            this.gbSuperman.Location = new System.Drawing.Point(12, 40);
            this.gbSuperman.Name = "gbSuperman";
            this.gbSuperman.Size = new System.Drawing.Size(196, 139);
            this.gbSuperman.TabIndex = 9;
            this.gbSuperman.TabStop = false;
            this.gbSuperman.Text = "Superman";
            this.gbSuperman.Visible = false;
            // 
            // rbSuperman
            // 
            this.rbSuperman.AutoSize = true;
            this.rbSuperman.Location = new System.Drawing.Point(17, 93);
            this.rbSuperman.Name = "rbSuperman";
            this.rbSuperman.Size = new System.Drawing.Size(73, 17);
            this.rbSuperman.TabIndex = 1;
            this.rbSuperman.TabStop = true;
            this.rbSuperman.Text = "Superman";
            this.rbSuperman.UseVisualStyleBackColor = true;
            // 
            // rbClarkKent
            // 
            this.rbClarkKent.AutoSize = true;
            this.rbClarkKent.Checked = true;
            this.rbClarkKent.Location = new System.Drawing.Point(17, 28);
            this.rbClarkKent.Name = "rbClarkKent";
            this.rbClarkKent.Size = new System.Drawing.Size(74, 17);
            this.rbClarkKent.TabIndex = 0;
            this.rbClarkKent.TabStop = true;
            this.rbClarkKent.Text = "Clark Kent";
            this.rbClarkKent.UseVisualStyleBackColor = true;
            // 
            // pbHero
            // 
            this.pbHero.Location = new System.Drawing.Point(287, 13);
            this.pbHero.Name = "pbHero";
            this.pbHero.Size = new System.Drawing.Size(190, 275);
            this.pbHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHero.TabIndex = 8;
            this.pbHero.TabStop = false;
            // 
            // cmbKahramanlar
            // 
            this.cmbKahramanlar.FormattingEnabled = true;
            this.cmbKahramanlar.Items.AddRange(new object[] {
            "Angel",
            "Cyclops",
            "Superman"});
            this.cmbKahramanlar.Location = new System.Drawing.Point(12, 12);
            this.cmbKahramanlar.Name = "cmbKahramanlar";
            this.cmbKahramanlar.Size = new System.Drawing.Size(196, 21);
            this.cmbKahramanlar.TabIndex = 7;
            this.cmbKahramanlar.SelectedIndexChanged += new System.EventHandler(this.cmbKahramanlar_SelectedIndexChanged);
            // 
            // heroResimler
            // 
            this.heroResimler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("heroResimler.ImageStream")));
            this.heroResimler.TransparentColor = System.Drawing.Color.Transparent;
            this.heroResimler.Images.SetKeyName(0, "angel.png");
            this.heroResimler.Images.SetKeyName(1, "cyclops.png");
            this.heroResimler.Images.SetKeyName(2, "superman.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 340);
            this.Controls.Add(this.btnLazer);
            this.Controls.Add(this.btnIndir);
            this.Controls.Add(this.btnUcur);
            this.Controls.Add(this.lazerBar);
            this.Controls.Add(this.gbSuperman);
            this.Controls.Add(this.pbHero);
            this.Controls.Add(this.cmbKahramanlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSuperman.ResumeLayout(false);
            this.gbSuperman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLazer;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.Button btnUcur;
        private System.Windows.Forms.ProgressBar lazerBar;
        private System.Windows.Forms.GroupBox gbSuperman;
        private System.Windows.Forms.RadioButton rbSuperman;
        private System.Windows.Forms.RadioButton rbClarkKent;
        private System.Windows.Forms.PictureBox pbHero;
        private System.Windows.Forms.ComboBox cmbKahramanlar;
        private System.Windows.Forms.ImageList heroResimler;
    }
}

