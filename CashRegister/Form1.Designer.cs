namespace CashRegister
{
    partial class calulatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calulatorForm));
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.friesBox = new System.Windows.Forms.TextBox();
            this.drinkBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.tenderdLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // burgerBox
            // 
            this.burgerBox.Location = new System.Drawing.Point(96, 12);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(94, 20);
            this.burgerBox.TabIndex = 0;
            this.burgerBox.Text = "0";
            this.burgerBox.Click += new System.EventHandler(this.burgerBox_Click);
            // 
            // friesBox
            // 
            this.friesBox.Location = new System.Drawing.Point(96, 52);
            this.friesBox.Name = "friesBox";
            this.friesBox.Size = new System.Drawing.Size(94, 20);
            this.friesBox.TabIndex = 1;
            this.friesBox.Text = "0";
            this.friesBox.Click += new System.EventHandler(this.friesBox_Click);
            // 
            // drinkBox
            // 
            this.drinkBox.Location = new System.Drawing.Point(96, 89);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(94, 20);
            this.drinkBox.TabIndex = 2;
            this.drinkBox.Text = "0";
            this.drinkBox.Click += new System.EventHandler(this.drinkBox_Click);
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.White;
            this.goButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.goButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(21, 127);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(169, 34);
            this.goButton.TabIndex = 3;
            this.goButton.Text = "Calculate Total";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.BackColor = System.Drawing.Color.Transparent;
            this.burgerLabel.Location = new System.Drawing.Point(18, 19);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(65, 13);
            this.burgerLabel.TabIndex = 4;
            this.burgerLabel.Text = "# of Burgers";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.BackColor = System.Drawing.Color.Transparent;
            this.friesLabel.Location = new System.Drawing.Point(32, 55);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(51, 13);
            this.friesLabel.TabIndex = 5;
            this.friesLabel.Text = "# of Fries";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.drinkLabel.Location = new System.Drawing.Point(24, 92);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(59, 13);
            this.drinkLabel.TabIndex = 6;
            this.drinkLabel.Text = "# of Drinks";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.White;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(24, 164);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(166, 60);
            this.totalLabel.TabIndex = 7;
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(96, 230);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(94, 20);
            this.tenderedBox.TabIndex = 8;
            this.tenderedBox.Text = "0";
            this.tenderedBox.Click += new System.EventHandler(this.tenderedBox_Click);
            // 
            // tenderdLabel
            // 
            this.tenderdLabel.AutoSize = true;
            this.tenderdLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderdLabel.Location = new System.Drawing.Point(3, 237);
            this.tenderdLabel.Name = "tenderdLabel";
            this.tenderdLabel.Size = new System.Drawing.Size(92, 13);
            this.tenderdLabel.TabIndex = 9;
            this.tenderdLabel.Text = "Amount Tendered";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.changeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(27, 256);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(126, 21);
            this.changeButton.TabIndex = 10;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.White;
            this.changeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 280);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(172, 104);
            this.changeLabel.TabIndex = 11;
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.White;
            this.receiptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(15, 387);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(169, 34);
            this.receiptButton.TabIndex = 12;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Visible = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.White;
            this.newButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(318, 2);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(102, 25);
            this.newButton.TabIndex = 13;
            this.newButton.Text = "New Order";
            this.newButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Visible = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // calulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderdLabel);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.friesBox);
            this.Controls.Add(this.burgerBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calulatorForm";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox burgerBox;
        private System.Windows.Forms.TextBox friesBox;
        private System.Windows.Forms.TextBox drinkBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Label tenderdLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button newButton;
    }
}

