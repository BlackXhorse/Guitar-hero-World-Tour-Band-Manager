
namespace GHWT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.vocalstring = new System.Windows.Forms.Label();
            this.guitarstring = new System.Windows.Forms.Label();
            this.bassstring = new System.Windows.Forms.Label();
            this.drumstring = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Band Manager";
            // 
            // vocalstring
            // 
            this.vocalstring.AutoSize = true;
            this.vocalstring.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vocalstring.Location = new System.Drawing.Point(40, 51);
            this.vocalstring.Name = "vocalstring";
            this.vocalstring.Size = new System.Drawing.Size(73, 23);
            this.vocalstring.TabIndex = 1;
            this.vocalstring.Text = "Vocalist";
            // 
            // guitarstring
            // 
            this.guitarstring.AutoSize = true;
            this.guitarstring.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guitarstring.Location = new System.Drawing.Point(40, 84);
            this.guitarstring.Name = "guitarstring";
            this.guitarstring.Size = new System.Drawing.Size(85, 23);
            this.guitarstring.TabIndex = 2;
            this.guitarstring.Text = "Guitarrist";
            // 
            // bassstring
            // 
            this.bassstring.AutoSize = true;
            this.bassstring.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bassstring.Location = new System.Drawing.Point(40, 119);
            this.bassstring.Name = "bassstring";
            this.bassstring.Size = new System.Drawing.Size(84, 23);
            this.bassstring.TabIndex = 3;
            this.bassstring.Text = "Bassman";
            // 
            // drumstring
            // 
            this.drumstring.AutoSize = true;
            this.drumstring.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drumstring.Location = new System.Drawing.Point(40, 156);
            this.drumstring.Name = "drumstring";
            this.drumstring.Size = new System.Drawing.Size(85, 23);
            this.drumstring.TabIndex = 4;
            this.drumstring.Text = "Drummer";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.drumstring);
            this.panel1.Controls.Add(this.vocalstring);
            this.panel1.Controls.Add(this.bassstring);
            this.panel1.Controls.Add(this.guitarstring);
            this.panel1.Location = new System.Drawing.Point(67, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 303);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(55, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Game Folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guitar Hero World Tour Band Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vocalstring;
        private System.Windows.Forms.Label guitarstring;
        private System.Windows.Forms.Label bassstring;
        private System.Windows.Forms.Label drumstring;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

