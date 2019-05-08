namespace ContainerSchip
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
            this.GenerateShip = new System.Windows.Forms.Button();
            this.Length = new System.Windows.Forms.NumericUpDown();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NbWeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbType = new System.Windows.Forms.ComboBox();
            this.AddContainer = new System.Windows.Forms.Button();
            this.LbContainers = new System.Windows.Forms.ListBox();
            this.Sort = new System.Windows.Forms.Button();
            this.LbWeight = new System.Windows.Forms.Label();
            this.loadPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateShip
            // 
            this.GenerateShip.Location = new System.Drawing.Point(112, 64);
            this.GenerateShip.Name = "GenerateShip";
            this.GenerateShip.Size = new System.Drawing.Size(75, 23);
            this.GenerateShip.TabIndex = 0;
            this.GenerateShip.Text = "Create Ship";
            this.GenerateShip.UseVisualStyleBackColor = true;
            this.GenerateShip.Click += new System.EventHandler(this.GenerateShip_Click);
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(67, 12);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(120, 20);
            this.Length.TabIndex = 1;
            // 
            // Width
            // 
            this.Width.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Width.Location = new System.Drawing.Point(67, 38);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(120, 20);
            this.Width.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // NbWeight
            // 
            this.NbWeight.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NbWeight.Location = new System.Drawing.Point(67, 126);
            this.NbWeight.Maximum = new decimal(new int[] {
            24000,
            0,
            0,
            0});
            this.NbWeight.Name = "NbWeight";
            this.NbWeight.Size = new System.Drawing.Size(120, 20);
            this.NbWeight.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type";
            // 
            // CbType
            // 
            this.CbType.FormattingEnabled = true;
            this.CbType.Location = new System.Drawing.Point(66, 152);
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(121, 21);
            this.CbType.TabIndex = 8;
            // 
            // AddContainer
            // 
            this.AddContainer.Location = new System.Drawing.Point(112, 179);
            this.AddContainer.Name = "AddContainer";
            this.AddContainer.Size = new System.Drawing.Size(75, 23);
            this.AddContainer.TabIndex = 9;
            this.AddContainer.Text = "Add Container";
            this.AddContainer.UseVisualStyleBackColor = true;
            this.AddContainer.Click += new System.EventHandler(this.AddContainer_Click);
            // 
            // LbContainers
            // 
            this.LbContainers.FormattingEnabled = true;
            this.LbContainers.Location = new System.Drawing.Point(27, 219);
            this.LbContainers.Name = "LbContainers";
            this.LbContainers.Size = new System.Drawing.Size(160, 199);
            this.LbContainers.TabIndex = 10;
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(237, 126);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 82);
            this.Sort.TabIndex = 11;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // LbWeight
            // 
            this.LbWeight.AutoSize = true;
            this.LbWeight.Location = new System.Drawing.Point(234, 231);
            this.LbWeight.Name = "LbWeight";
            this.LbWeight.Size = new System.Drawing.Size(41, 13);
            this.LbWeight.TabIndex = 12;
            this.LbWeight.Text = "Weight";
            // 
            // loadPercentage
            // 
            this.loadPercentage.AutoSize = true;
            this.loadPercentage.Location = new System.Drawing.Point(234, 257);
            this.loadPercentage.Name = "loadPercentage";
            this.loadPercentage.Size = new System.Drawing.Size(42, 13);
            this.loadPercentage.TabIndex = 13;
            this.loadPercentage.Text = "Load %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadPercentage);
            this.Controls.Add(this.LbWeight);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.LbContainers);
            this.Controls.Add(this.AddContainer);
            this.Controls.Add(this.CbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NbWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.GenerateShip);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateShip;
        private System.Windows.Forms.NumericUpDown Length;
        private System.Windows.Forms.NumericUpDown Width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NbWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbType;
        private System.Windows.Forms.Button AddContainer;
        private System.Windows.Forms.ListBox LbContainers;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Label LbWeight;
        private System.Windows.Forms.Label loadPercentage;
    }
}

