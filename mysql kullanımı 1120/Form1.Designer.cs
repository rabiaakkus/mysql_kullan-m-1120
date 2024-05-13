namespace mysql_kullanımı_1120
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
            this.btnElestiriler = new System.Windows.Forms.Button();
            this.btnFilmElestiri = new System.Windows.Forms.Button();
            this.dgw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // btnElestiriler
            // 
            this.btnElestiriler.Location = new System.Drawing.Point(37, 72);
            this.btnElestiriler.Name = "btnElestiriler";
            this.btnElestiriler.Size = new System.Drawing.Size(75, 23);
            this.btnElestiriler.TabIndex = 0;
            this.btnElestiriler.Text = "eleştiriler";
            this.btnElestiriler.UseVisualStyleBackColor = true;
            this.btnElestiriler.Click += new System.EventHandler(this.btnElestiriler_Click);
            // 
            // btnFilmElestiri
            // 
            this.btnFilmElestiri.Location = new System.Drawing.Point(142, 84);
            this.btnFilmElestiri.Name = "btnFilmElestiri";
            this.btnFilmElestiri.Size = new System.Drawing.Size(75, 23);
            this.btnFilmElestiri.TabIndex = 1;
            this.btnFilmElestiri.Text = "film elestiri";
            this.btnFilmElestiri.UseVisualStyleBackColor = true;
            this.btnFilmElestiri.Click += new System.EventHandler(this.btnFilmElestiri_Click);
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(71, 220);
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.Size = new System.Drawing.Size(487, 182);
            this.dgw.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.btnFilmElestiri);
            this.Controls.Add(this.btnElestiriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElestiriler;
        private System.Windows.Forms.Button btnFilmElestiri;
        private System.Windows.Forms.DataGridView dgw;
    }
}

