﻿namespace Bovelo
{
    partial class Form2
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
            this.validate = new System.Windows.Forms.Button();
            this.bike_list_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validate
            // 
            this.validate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validate.Location = new System.Drawing.Point(607, 370);
            this.validate.MaximumSize = new System.Drawing.Size(105, 23);
            this.validate.MinimumSize = new System.Drawing.Size(105, 23);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(105, 23);
            this.validate.TabIndex = 14;
            this.validate.Text = "Validate";
            this.validate.UseVisualStyleBackColor = true;
            // 
            // bike_list_label
            // 
            this.bike_list_label.AutoSize = true;
            this.bike_list_label.Location = new System.Drawing.Point(13, 13);
            this.bike_list_label.Name = "bike_list_label";
            this.bike_list_label.Size = new System.Drawing.Size(0, 13);
            this.bike_list_label.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 426);
            this.Controls.Add(this.bike_list_label);
            this.Controls.Add(this.validate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(762, 465);
            this.MinimumSize = new System.Drawing.Size(762, 465);
            this.Name = "Form2";
            this.Text = "Basket";
            this.Load += new System.EventHandler(this.BasketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Label bike_list_label;
    }
}