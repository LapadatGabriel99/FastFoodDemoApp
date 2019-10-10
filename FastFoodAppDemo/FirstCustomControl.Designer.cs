namespace FastFoodAppDemo
{
    partial class FirstCustomControl
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
            System.Windows.Forms.Label burgerPrice_label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstCustomControl));
            this.OnlyChesseburgerPrice_label = new System.Windows.Forms.Label();
            this.Cheeseburger_label = new System.Windows.Forms.Label();
            this.CheeseburgerWithOTB_label = new System.Windows.Forms.Label();
            this.CheeseburgerDescription_label = new System.Windows.Forms.Label();
            this.OrderCheeseburger_Button = new System.Windows.Forms.Button();
            this.Cheeseburger_PictureBox = new System.Windows.Forms.PictureBox();
            burgerPrice_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cheeseburger_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // burgerPrice_label
            // 
            burgerPrice_label.AutoSize = true;
            burgerPrice_label.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            burgerPrice_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            burgerPrice_label.Location = new System.Drawing.Point(90, 48);
            burgerPrice_label.Name = "burgerPrice_label";
            burgerPrice_label.Size = new System.Drawing.Size(239, 123);
            burgerPrice_label.TabIndex = 8;
            burgerPrice_label.Text = "$19";
            // 
            // OnlyChesseburgerPrice_label
            // 
            this.OnlyChesseburgerPrice_label.AutoSize = true;
            this.OnlyChesseburgerPrice_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyChesseburgerPrice_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.OnlyChesseburgerPrice_label.Location = new System.Drawing.Point(64, 48);
            this.OnlyChesseburgerPrice_label.Name = "OnlyChesseburgerPrice_label";
            this.OnlyChesseburgerPrice_label.Size = new System.Drawing.Size(43, 18);
            this.OnlyChesseburgerPrice_label.TabIndex = 2;
            this.OnlyChesseburgerPrice_label.Text = "Only";
            // 
            // Cheeseburger_label
            // 
            this.Cheeseburger_label.AutoSize = true;
            this.Cheeseburger_label.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cheeseburger_label.Location = new System.Drawing.Point(87, 165);
            this.Cheeseburger_label.Name = "Cheeseburger_label";
            this.Cheeseburger_label.Size = new System.Drawing.Size(217, 36);
            this.Cheeseburger_label.TabIndex = 3;
            this.Cheeseburger_label.Text = "Cheeseburger";
            // 
            // CheeseburgerWithOTB_label
            // 
            this.CheeseburgerWithOTB_label.AutoSize = true;
            this.CheeseburgerWithOTB_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheeseburgerWithOTB_label.Location = new System.Drawing.Point(97, 209);
            this.CheeseburgerWithOTB_label.Name = "CheeseburgerWithOTB_label";
            this.CheeseburgerWithOTB_label.Size = new System.Drawing.Size(300, 21);
            this.CheeseburgerWithOTB_label.TabIndex = 4;
            this.CheeseburgerWithOTB_label.Text = "With fresh onions,tomatos and bacon";
            // 
            // CheeseburgerDescription_label
            // 
            this.CheeseburgerDescription_label.AutoSize = true;
            this.CheeseburgerDescription_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheeseburgerDescription_label.Location = new System.Drawing.Point(97, 245);
            this.CheeseburgerDescription_label.Name = "CheeseburgerDescription_label";
            this.CheeseburgerDescription_label.Size = new System.Drawing.Size(356, 85);
            this.CheeseburgerDescription_label.TabIndex = 5;
            this.CheeseburgerDescription_label.Text = resources.GetString("CheeseburgerDescription_label.Text");
            // 
            // OrderCheeseburger_Button
            // 
            this.OrderCheeseburger_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.OrderCheeseburger_Button.FlatAppearance.BorderSize = 0;
            this.OrderCheeseburger_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderCheeseburger_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCheeseburger_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderCheeseburger_Button.Location = new System.Drawing.Point(98, 361);
            this.OrderCheeseburger_Button.Name = "OrderCheeseburger_Button";
            this.OrderCheeseburger_Button.Size = new System.Drawing.Size(325, 42);
            this.OrderCheeseburger_Button.TabIndex = 6;
            this.OrderCheeseburger_Button.Text = "Order Now";
            this.OrderCheeseburger_Button.UseVisualStyleBackColor = false;
            this.OrderCheeseburger_Button.Click += new System.EventHandler(this.OrderCheeseburger_Button_Click);
            // 
            // Cheeseburger_PictureBox
            // 
            this.Cheeseburger_PictureBox.Image = global::FastFoodAppDemo.Properties.Resources.Cheeseburger_PNG_1;
            this.Cheeseburger_PictureBox.Location = new System.Drawing.Point(462, 136);
            this.Cheeseburger_PictureBox.Name = "Cheeseburger_PictureBox";
            this.Cheeseburger_PictureBox.Size = new System.Drawing.Size(381, 237);
            this.Cheeseburger_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cheeseburger_PictureBox.TabIndex = 7;
            this.Cheeseburger_PictureBox.TabStop = false;
            // 
            // FirstCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OnlyChesseburgerPrice_label);
            this.Controls.Add(burgerPrice_label);
            this.Controls.Add(this.Cheeseburger_PictureBox);
            this.Controls.Add(this.OrderCheeseburger_Button);
            this.Controls.Add(this.CheeseburgerDescription_label);
            this.Controls.Add(this.CheeseburgerWithOTB_label);
            this.Controls.Add(this.Cheeseburger_label);
            this.Name = "FirstCustomControl";
            this.Size = new System.Drawing.Size(860, 459);
            this.Load += new System.EventHandler(this.FirstCustomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cheeseburger_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label OnlyChesseburgerPrice_label;
        private System.Windows.Forms.Label Cheeseburger_label;
        private System.Windows.Forms.Label CheeseburgerWithOTB_label;
        private System.Windows.Forms.Label CheeseburgerDescription_label;
        private System.Windows.Forms.Button OrderCheeseburger_Button;
        private System.Windows.Forms.PictureBox Cheeseburger_PictureBox;
    }
}
