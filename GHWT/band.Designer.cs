
namespace GHWT
{
    partial class band
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
            this.vocal = new System.Windows.Forms.Button();
            this.guitar = new System.Windows.Forms.Button();
            this.bass = new System.Windows.Forms.Button();
            this.drum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vocal
            // 
            this.vocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vocal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vocal.Location = new System.Drawing.Point(153, 30);
            this.vocal.Name = "vocal";
            this.vocal.Size = new System.Drawing.Size(201, 72);
            this.vocal.TabIndex = 0;
            this.vocal.Text = "Vocal";
            this.vocal.UseVisualStyleBackColor = true;
            this.vocal.Click += new System.EventHandler(this.vocal_Click);
            // 
            // guitar
            // 
            this.guitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guitar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guitar.Location = new System.Drawing.Point(153, 119);
            this.guitar.Name = "guitar";
            this.guitar.Size = new System.Drawing.Size(201, 72);
            this.guitar.TabIndex = 1;
            this.guitar.Text = "Guitar";
            this.guitar.UseVisualStyleBackColor = true;
            this.guitar.Click += new System.EventHandler(this.guitar_Click);
            // 
            // bass
            // 
            this.bass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bass.Location = new System.Drawing.Point(153, 206);
            this.bass.Name = "bass";
            this.bass.Size = new System.Drawing.Size(201, 72);
            this.bass.TabIndex = 2;
            this.bass.Text = "Bass";
            this.bass.UseVisualStyleBackColor = true;
            this.bass.Click += new System.EventHandler(this.bass_Click);
            // 
            // drum
            // 
            this.drum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drum.Location = new System.Drawing.Point(153, 295);
            this.drum.Name = "drum";
            this.drum.Size = new System.Drawing.Size(201, 72);
            this.drum.TabIndex = 3;
            this.drum.Text = "Drum";
            this.drum.UseVisualStyleBackColor = true;
            this.drum.Click += new System.EventHandler(this.drum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select The Character ini FIle (.ini)";
            // 
            // band
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(504, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drum);
            this.Controls.Add(this.bass);
            this.Controls.Add(this.guitar);
            this.Controls.Add(this.vocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "band";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Band Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vocal;
        private System.Windows.Forms.Button guitar;
        private System.Windows.Forms.Button bass;
        private System.Windows.Forms.Button drum;
        private System.Windows.Forms.Label label1;
    }
}