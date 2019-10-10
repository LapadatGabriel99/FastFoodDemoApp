namespace FastFoodAppDemo
{
    partial class Basket
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
            this.BasketList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BasketList
            // 
            this.BasketList.FormattingEnabled = true;
            this.BasketList.Location = new System.Drawing.Point(27, 20);
            this.BasketList.Name = "BasketList";
            this.BasketList.Size = new System.Drawing.Size(388, 199);
            this.BasketList.TabIndex = 0;
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BasketList);
            this.Name = "Basket";
            this.Size = new System.Drawing.Size(836, 497);
            this.Load += new System.EventHandler(this.Basket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BasketList;
    }
}
