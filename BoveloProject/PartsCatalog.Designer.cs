﻿
namespace Bovelo
{
    partial class PartsCatalog
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
            this.partsCatalogGridView = new System.Windows.Forms.DataGridView();
            this.partSelected_Lbl = new System.Windows.Forms.Label();
            this.addPart_Btn = new System.Windows.Forms.Button();
            this.back_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsCatalogGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partsCatalogGridView
            // 
            this.partsCatalogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsCatalogGridView.Location = new System.Drawing.Point(112, 12);
            this.partsCatalogGridView.Name = "partsCatalogGridView";
            this.partsCatalogGridView.Size = new System.Drawing.Size(503, 513);
            this.partsCatalogGridView.TabIndex = 0;
            this.partsCatalogGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.partsCatalogGridView_MouseClick);
            // 
            // partSelected_Lbl
            // 
            this.partSelected_Lbl.AutoSize = true;
            this.partSelected_Lbl.Location = new System.Drawing.Point(12, 568);
            this.partSelected_Lbl.Name = "partSelected_Lbl";
            this.partSelected_Lbl.Size = new System.Drawing.Size(0, 13);
            this.partSelected_Lbl.TabIndex = 1;
            // 
            // addPart_Btn
            // 
            this.addPart_Btn.Location = new System.Drawing.Point(588, 551);
            this.addPart_Btn.Name = "addPart_Btn";
            this.addPart_Btn.Size = new System.Drawing.Size(135, 46);
            this.addPart_Btn.TabIndex = 2;
            this.addPart_Btn.Text = "Add part";
            this.addPart_Btn.UseVisualStyleBackColor = true;
            this.addPart_Btn.Click += new System.EventHandler(this.addPart_Btn_Click);
            // 
            // back_Btn
            // 
            this.back_Btn.Location = new System.Drawing.Point(436, 551);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.Size = new System.Drawing.Size(135, 46);
            this.back_Btn.TabIndex = 3;
            this.back_Btn.Text = "Back";
            this.back_Btn.UseVisualStyleBackColor = true;
            this.back_Btn.Click += new System.EventHandler(this.back_Btn_Click);
            // 
            // PartsCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 602);
            this.Controls.Add(this.back_Btn);
            this.Controls.Add(this.addPart_Btn);
            this.Controls.Add(this.partSelected_Lbl);
            this.Controls.Add(this.partsCatalogGridView);
            this.Name = "PartsCatalog";
            this.Text = "Parts Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.partsCatalogGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView partsCatalogGridView;
        private System.Windows.Forms.Label partSelected_Lbl;
        private System.Windows.Forms.Button addPart_Btn;
        private System.Windows.Forms.Button back_Btn;
    }
}