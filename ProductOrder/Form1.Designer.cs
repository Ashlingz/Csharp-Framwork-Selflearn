namespace ProductOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.product3 = new ProductOrder.Product();
            this.product2 = new ProductOrder.Product();
            this.product1 = new ProductOrder.Product();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // product3
            // 
            this.product3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.product3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product3.ID = 0;
            this.product3.Location = new System.Drawing.Point(661, 131);
            this.product3.Margin = new System.Windows.Forms.Padding(4);
            this.product3.Name = "product3";
            this.product3.Photo = global::ProductOrder.Properties.Resources.A4;
            this.product3.PName = "ពងទា";
            this.product3.Price = 5D;
            this.product3.Qty = 0;
            this.product3.Size = new System.Drawing.Size(292, 425);
            this.product3.TabIndex = 2;
            // 
            // product2
            // 
            this.product2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.product2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product2.ID = 0;
            this.product2.Location = new System.Drawing.Point(337, 131);
            this.product2.Margin = new System.Windows.Forms.Padding(4);
            this.product2.Name = "product2";
            this.product2.Photo = global::ProductOrder.Properties.Resources.bay;
            this.product2.PName = "បាយឆា";
            this.product2.Price = 3D;
            this.product2.Qty = 0;
            this.product2.Size = new System.Drawing.Size(292, 425);
            this.product2.TabIndex = 1;
            // 
            // product1
            // 
            this.product1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.product1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product1.ID = 0;
            this.product1.Location = new System.Drawing.Point(16, 131);
            this.product1.Margin = new System.Windows.Forms.Padding(4);
            this.product1.Name = "product1";
            this.product1.Photo = global::ProductOrder.Properties.Resources.A2;
            this.product1.PName = "បុកល្ហុង";
            this.product1.Price = 2D;
            this.product1.Qty = 0;
            this.product1.Size = new System.Drawing.Size(292, 425);
            this.product1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProductOrder.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(970, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.product3);
            this.Controls.Add(this.product2);
            this.Controls.Add(this.product1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Product product1;
        private Product product2;
        private Product product3;
        private System.Windows.Forms.Label label1;
    }
}

