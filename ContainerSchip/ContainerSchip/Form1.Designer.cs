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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.libUnplaced = new System.Windows.Forms.ListBox();
            this.lbLoad = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnVaar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbWeight)).BeginInit();
            this.SuspendLayout();
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
            this.LbContainers.Location = new System.Drawing.Point(27, 231);
            this.LbContainers.Name = "LbContainers";
            this.LbContainers.Size = new System.Drawing.Size(160, 225);
            this.LbContainers.TabIndex = 10;
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(27, 583);
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
            this.LbWeight.Location = new System.Drawing.Point(108, 592);
            this.LbWeight.Name = "LbWeight";
            this.LbWeight.Size = new System.Drawing.Size(41, 13);
            this.LbWeight.TabIndex = 12;
            this.LbWeight.Text = "Weight";
            // 
            // loadPercentage
            // 
            this.loadPercentage.AutoSize = true;
            this.loadPercentage.Location = new System.Drawing.Point(108, 618);
            this.loadPercentage.Name = "loadPercentage";
            this.loadPercentage.Size = new System.Drawing.Size(42, 13);
            this.loadPercentage.TabIndex = 13;
            this.loadPercentage.Text = "Load %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Container Stack";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Unplaced Containers";
            // 
            // libUnplaced
            // 
            this.libUnplaced.FormattingEnabled = true;
            this.libUnplaced.Location = new System.Drawing.Point(27, 484);
            this.libUnplaced.Name = "libUnplaced";
            this.libUnplaced.Size = new System.Drawing.Size(160, 82);
            this.libUnplaced.TabIndex = 15;
            // 
            // lbLoad
            // 
            this.lbLoad.AutoSize = true;
            this.lbLoad.Location = new System.Drawing.Point(108, 641);
            this.lbLoad.Name = "lbLoad";
            this.lbLoad.Size = new System.Drawing.Size(42, 13);
            this.lbLoad.TabIndex = 17;
            this.lbLoad.Text = "Load %";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(27, 674);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 56);
            this.BtnReset.TabIndex = 18;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnVaar
            // 
            this.BtnVaar.Location = new System.Drawing.Point(108, 675);
            this.BtnVaar.Name = "BtnVaar";
            this.BtnVaar.Size = new System.Drawing.Size(75, 56);
            this.BtnVaar.TabIndex = 19;
            this.BtnVaar.Text = "Vaar weg! ";
            this.BtnVaar.UseVisualStyleBackColor = true;
            this.BtnVaar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1346, 742);
            this.Controls.Add(this.BtnVaar);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.lbLoad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.libUnplaced);
            this.Controls.Add(this.label5);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox libUnplaced;
        private System.Windows.Forms.Label lbLoad;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnVaar;
    }
}

