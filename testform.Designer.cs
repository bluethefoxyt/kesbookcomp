namespace COMPkesbook
{
    partial class testform
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
            this.mossieButton1 = new COMPkesbook.skins.flatui.MossieButton();
            this.roundButton1 = new COMPkesbook.skins.RoundButton();
            this.SuspendLayout();
            // 
            // mossieButton1
            // 
            this.mossieButton1.BackColor = System.Drawing.Color.Black;
            this.mossieButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.mossieButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mossieButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mossieButton1.ForeColor = System.Drawing.Color.White;
            this.mossieButton1.Location = new System.Drawing.Point(14, 9);
            this.mossieButton1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mossieButton1.MinimumSize = new System.Drawing.Size(100, 30);
            this.mossieButton1.Name = "mossieButton1";
            this.mossieButton1.Padding = new System.Windows.Forms.Padding(3);
            this.mossieButton1.Size = new System.Drawing.Size(160, 67);
            this.mossieButton1.TabIndex = 0;
            this.mossieButton1.Text = "mossieButton1";
            this.mossieButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton1
            // 
            this.roundButton1.Location = new System.Drawing.Point(182, 9);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(69, 67);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.Text = "ok";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // testform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 381);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.mossieButton1);
            this.Name = "testform";
            this.Text = "testform";
            this.ResumeLayout(false);

        }

        #endregion

        private skins.flatui.MossieButton mossieButton1;
        private skins.RoundButton roundButton1;
    }
}