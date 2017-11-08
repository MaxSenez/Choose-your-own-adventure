namespace Choose_your_own_adventure
{
    partial class adventureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adventureForm));
            this.outputLabel = new System.Windows.Forms.Label();
            this.wLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.outputLabel.Location = new System.Drawing.Point(12, 16);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(454, 191);
            this.outputLabel.TabIndex = 0;
            // 
            // wLabel
            // 
            this.wLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.wLabel.Location = new System.Drawing.Point(17, 236);
            this.wLabel.Name = "wLabel";
            this.wLabel.Size = new System.Drawing.Size(220, 34);
            this.wLabel.TabIndex = 6;
            this.wLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aLabel
            // 
            this.aLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.aLabel.Location = new System.Drawing.Point(234, 236);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(220, 34);
            this.aLabel.TabIndex = 7;
            this.aLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dLabel
            // 
            this.dLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dLabel.Location = new System.Drawing.Point(235, 273);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(220, 34);
            this.dLabel.TabIndex = 9;
            this.dLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sLabel
            // 
            this.sLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.sLabel.Location = new System.Drawing.Point(18, 273);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(220, 34);
            this.sLabel.TabIndex = 8;
            this.sLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adventureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.wLabel);
            this.Controls.Add(this.outputLabel);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adventureForm";
            this.Text = "Kayak Hell";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adventureForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label wLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label sLabel;
    }
}

