namespace GameButton
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.value1 = new System.Windows.Forms.Label();
            this.value2 = new System.Windows.Forms.Label();
            this.buttonBig = new System.Windows.Forms.Button();
            this.buttonLittle = new System.Windows.Forms.Button();
            this.buttonEquel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(37, 15);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(825, 29);
            this.progressBar1.TabIndex = 24;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(353, 491);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(160, 58);
            this.buttonStart.TabIndex = 25;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 28;
            // 
            // value1
            // 
            this.value1.AutoSize = true;
            this.value1.Location = new System.Drawing.Point(212, 133);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(0, 20);
            this.value1.TabIndex = 29;
            // 
            // value2
            // 
            this.value2.AutoSize = true;
            this.value2.Location = new System.Drawing.Point(604, 133);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(0, 20);
            this.value2.TabIndex = 30;
            // 
            // buttonBig
            // 
            this.buttonBig.Location = new System.Drawing.Point(590, 242);
            this.buttonBig.Name = "buttonBig";
            this.buttonBig.Size = new System.Drawing.Size(81, 77);
            this.buttonBig.TabIndex = 31;
            this.buttonBig.Text = ">";
            this.buttonBig.UseVisualStyleBackColor = true;
            this.buttonBig.Click += new System.EventHandler(this.buttonBig_Click);
            // 
            // buttonLittle
            // 
            this.buttonLittle.Location = new System.Drawing.Point(205, 242);
            this.buttonLittle.Name = "buttonLittle";
            this.buttonLittle.Size = new System.Drawing.Size(81, 77);
            this.buttonLittle.TabIndex = 32;
            this.buttonLittle.Text = "<";
            this.buttonLittle.UseVisualStyleBackColor = true;
            this.buttonLittle.Click += new System.EventHandler(this.buttonLittle_Click);
            // 
            // buttonEquel
            // 
            this.buttonEquel.Location = new System.Drawing.Point(394, 338);
            this.buttonEquel.Name = "buttonEquel";
            this.buttonEquel.Size = new System.Drawing.Size(81, 77);
            this.buttonEquel.TabIndex = 33;
            this.buttonEquel.Text = "=";
            this.buttonEquel.UseVisualStyleBackColor = true;
            this.buttonEquel.Click += new System.EventHandler(this.buttonEquel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEquel);
            this.Controls.Add(this.buttonLittle);
            this.Controls.Add(this.buttonBig);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBar1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label value1;
        private System.Windows.Forms.Label value2;
        private System.Windows.Forms.Button buttonBig;
        private System.Windows.Forms.Button buttonLittle;
        private System.Windows.Forms.Button buttonEquel;
        private System.Windows.Forms.Label label2;
    }
}

