namespace IntergerCalc
{
    partial class InigerCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InigerCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Zahl1 = new System.Windows.Forms.TextBox();
            this.textBox_Zahl2 = new System.Windows.Forms.TextBox();
            this.textBox_Ergebnis = new System.Windows.Forms.TextBox();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_Durch = new System.Windows.Forms.Button();
            this.button_Mod = new System.Windows.Forms.Button();
            this.button_Mal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zahl1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zahl2:";
            // 
            // textBox_Zahl1
            // 
            this.textBox_Zahl1.Location = new System.Drawing.Point(103, 18);
            this.textBox_Zahl1.Name = "textBox_Zahl1";
            this.textBox_Zahl1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Zahl1.TabIndex = 2;
            this.textBox_Zahl1.Text = "0";
            // 
            // textBox_Zahl2
            // 
            this.textBox_Zahl2.Location = new System.Drawing.Point(103, 55);
            this.textBox_Zahl2.Name = "textBox_Zahl2";
            this.textBox_Zahl2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Zahl2.TabIndex = 3;
            this.textBox_Zahl2.Text = "0";
            // 
            // textBox_Ergebnis
            // 
            this.textBox_Ergebnis.Location = new System.Drawing.Point(103, 93);
            this.textBox_Ergebnis.Name = "textBox_Ergebnis";
            this.textBox_Ergebnis.ReadOnly = true;
            this.textBox_Ergebnis.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ergebnis.TabIndex = 4;
            // 
            // button_Plus
            // 
            this.button_Plus.Location = new System.Drawing.Point(220, 15);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(45, 30);
            this.button_Plus.TabIndex = 5;
            this.button_Plus.Tag = "1";
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button_Minus
            // 
            this.button_Minus.Location = new System.Drawing.Point(271, 15);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(45, 30);
            this.button_Minus.TabIndex = 5;
            this.button_Minus.Tag = "2";
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button_Durch
            // 
            this.button_Durch.Location = new System.Drawing.Point(220, 87);
            this.button_Durch.Name = "button_Durch";
            this.button_Durch.Size = new System.Drawing.Size(45, 30);
            this.button_Durch.TabIndex = 5;
            this.button_Durch.Tag = "4";
            this.button_Durch.Text = "/";
            this.button_Durch.UseVisualStyleBackColor = true;
            this.button_Durch.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button_Mod
            // 
            this.button_Mod.Location = new System.Drawing.Point(271, 87);
            this.button_Mod.Name = "button_Mod";
            this.button_Mod.Size = new System.Drawing.Size(45, 30);
            this.button_Mod.TabIndex = 5;
            this.button_Mod.Tag = "5";
            this.button_Mod.Text = "%";
            this.button_Mod.UseVisualStyleBackColor = true;
            this.button_Mod.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button_Mal
            // 
            this.button_Mal.Location = new System.Drawing.Point(220, 51);
            this.button_Mal.Name = "button_Mal";
            this.button_Mal.Size = new System.Drawing.Size(45, 30);
            this.button_Mal.TabIndex = 5;
            this.button_Mal.Tag = "3";
            this.button_Mal.Text = "*";
            this.button_Mal.UseVisualStyleBackColor = true;
            this.button_Mal.Click += new System.EventHandler(this.ButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ergebnis";
            // 
            // InigerCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 131);
            this.Controls.Add(this.button_Mod);
            this.Controls.Add(this.button_Minus);
            this.Controls.Add(this.button_Durch);
            this.Controls.Add(this.button_Mal);
            this.Controls.Add(this.button_Plus);
            this.Controls.Add(this.textBox_Ergebnis);
            this.Controls.Add(this.textBox_Zahl2);
            this.Controls.Add(this.textBox_Zahl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InigerCalculator";
            this.Text = "IntigerCalculator";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Zahl1;
        private System.Windows.Forms.TextBox textBox_Zahl2;
        private System.Windows.Forms.TextBox textBox_Ergebnis;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_Durch;
        private System.Windows.Forms.Button button_Mod;
        private System.Windows.Forms.Button button_Mal;
        private System.Windows.Forms.Label label3;
    }
}

