namespace Boodschappen_lijst
{
    partial class AddBoodschap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBoodschap));
            this.btDone = new System.Windows.Forms.Button();
            this.LSBItems = new System.Windows.Forms.ListBox();
            this.TBProduct = new System.Windows.Forms.TextBox();
            this.TBUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTAddProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTWijzig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDone
            // 
            this.btDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDone.Location = new System.Drawing.Point(12, 356);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(197, 40);
            this.btDone.TabIndex = 0;
            this.btDone.Text = "Klaar";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // LSBItems
            // 
            this.LSBItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSBItems.FormattingEnabled = true;
            this.LSBItems.ItemHeight = 25;
            this.LSBItems.Location = new System.Drawing.Point(256, 12);
            this.LSBItems.Name = "LSBItems";
            this.LSBItems.Size = new System.Drawing.Size(468, 329);
            this.LSBItems.TabIndex = 1;
            // 
            // TBProduct
            // 
            this.TBProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProduct.Location = new System.Drawing.Point(22, 41);
            this.TBProduct.Name = "TBProduct";
            this.TBProduct.Size = new System.Drawing.Size(197, 30);
            this.TBProduct.TabIndex = 2;
            // 
            // TBUnit
            // 
            this.TBUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUnit.Location = new System.Drawing.Point(22, 102);
            this.TBUnit.Name = "TBUnit";
            this.TBUnit.Size = new System.Drawing.Size(197, 30);
            this.TBUnit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eenheid";
            // 
            // BTAddProduct
            // 
            this.BTAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAddProduct.Location = new System.Drawing.Point(22, 138);
            this.BTAddProduct.Name = "BTAddProduct";
            this.BTAddProduct.Size = new System.Drawing.Size(197, 41);
            this.BTAddProduct.TabIndex = 6;
            this.BTAddProduct.Text = "Voeg product toe";
            this.BTAddProduct.UseVisualStyleBackColor = true;
            this.BTAddProduct.Click += new System.EventHandler(this.BTAddProduct_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(491, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Verwijder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTWijzig
            // 
            this.BTWijzig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTWijzig.Location = new System.Drawing.Point(256, 356);
            this.BTWijzig.Name = "BTWijzig";
            this.BTWijzig.Size = new System.Drawing.Size(229, 41);
            this.BTWijzig.TabIndex = 8;
            this.BTWijzig.Text = "Wijzig";
            this.BTWijzig.UseVisualStyleBackColor = true;
            this.BTWijzig.Click += new System.EventHandler(this.BTWijzig_Click);
            // 
            // AddBoodschap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 413);
            this.Controls.Add(this.BTWijzig);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTAddProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBUnit);
            this.Controls.Add(this.TBProduct);
            this.Controls.Add(this.LSBItems);
            this.Controls.Add(this.btDone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBoodschap";
            this.Text = "Boodschap Beheer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBoodschap_FormClosing);
            this.Load += new System.EventHandler(this.AddBoodschap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDone;
        private System.Windows.Forms.ListBox LSBItems;
        private System.Windows.Forms.TextBox TBProduct;
        private System.Windows.Forms.TextBox TBUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTAddProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTWijzig;
    }
}