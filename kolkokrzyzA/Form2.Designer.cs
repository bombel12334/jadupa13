using System.ComponentModel;

namespace kolkokrzyzA
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.zwyciezcaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRATULACJE WYGRAŁ:";
            // 
            // zwyciezcaLabel
            // 
            this.zwyciezcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.zwyciezcaLabel.Location = new System.Drawing.Point(83, 70);
            this.zwyciezcaLabel.Name = "zwyciezcaLabel";
            this.zwyciezcaLabel.Size = new System.Drawing.Size(437, 122);
            this.zwyciezcaLabel.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 221);
            this.Controls.Add(this.zwyciezcaLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Shown += new System.EventHandler(this.PokaZwyciezce);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label zwyciezcaLabel;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}