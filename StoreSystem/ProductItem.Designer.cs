namespace StoreSystem
{
    partial class ProductItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PriceProductItem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NameProductItem = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameProductItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PriceProductItem, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PriceProductItem
            // 
            this.PriceProductItem.AutoSize = true;
            this.PriceProductItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceProductItem.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PriceProductItem.Location = new System.Drawing.Point(464, 1);
            this.PriceProductItem.Name = "PriceProductItem";
            this.PriceProductItem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PriceProductItem.Size = new System.Drawing.Size(147, 48);
            this.PriceProductItem.TabIndex = 1;
            this.PriceProductItem.Text = "999 kr";
            this.PriceProductItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(620, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lägg till";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NameProductItem
            // 
            this.NameProductItem.AutoSize = true;
            this.NameProductItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameProductItem.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.NameProductItem.Location = new System.Drawing.Point(4, 1);
            this.NameProductItem.Name = "NameProductItem";
            this.NameProductItem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.NameProductItem.Size = new System.Drawing.Size(453, 48);
            this.NameProductItem.TabIndex = 0;
            this.NameProductItem.Text = "Name";
            this.NameProductItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(770, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PriceProductItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameProductItem;
    }
}
