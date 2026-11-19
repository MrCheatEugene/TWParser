namespace TWParser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fnInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.endings = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fnOut = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalEndings = new System.Windows.Forms.Label();
            this.succParsed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fnInput
            // 
            this.fnInput.Location = new System.Drawing.Point(12, 27);
            this.fnInput.Name = "fnInput";
            this.fnInput.Size = new System.Drawing.Size(286, 20);
            this.fnInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к файлу с юзернеймами";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(304, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // endings
            // 
            this.endings.AutoSize = true;
            this.endings.Location = new System.Drawing.Point(12, 94);
            this.endings.Name = "endings";
            this.endings.Size = new System.Drawing.Size(178, 17);
            this.endings.TabIndex = 3;
            this.endings.Text = "Так же чекать с окончаниями";
            this.endings.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(93, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Стоп";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(304, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Выбрать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Путь к выходному файлу";
            // 
            // fnOut
            // 
            this.fnOut.Location = new System.Drawing.Point(12, 71);
            this.fnOut.Name = "fnOut";
            this.fnOut.Size = new System.Drawing.Size(286, 20);
            this.fnOut.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 143);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(364, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Всего юзов/c окончаниями";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Спаршено успешно";
            // 
            // totalEndings
            // 
            this.totalEndings.AutoSize = true;
            this.totalEndings.Location = new System.Drawing.Point(344, 114);
            this.totalEndings.Name = "totalEndings";
            this.totalEndings.Size = new System.Drawing.Size(13, 13);
            this.totalEndings.TabIndex = 12;
            this.totalEndings.Text = "0";
            // 
            // succParsed
            // 
            this.succParsed.AutoSize = true;
            this.succParsed.Location = new System.Drawing.Point(344, 127);
            this.succParsed.Name = "succParsed";
            this.succParsed.Size = new System.Drawing.Size(13, 13);
            this.succParsed.TabIndex = 13;
            this.succParsed.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(391, 172);
            this.Controls.Add(this.succParsed);
            this.Controls.Add(this.totalEndings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fnOut);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.endings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TWParser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox endings;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnOut;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalEndings;
        private System.Windows.Forms.Label succParsed;
    }
}

