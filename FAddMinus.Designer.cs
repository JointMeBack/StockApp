namespace StockApp
{
    partial class FAddMinus
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
            this.PanelMCount = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NUMcount = new System.Windows.Forms.NumericUpDown();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBComm = new System.Windows.Forms.TextBox();
            this.CBDef = new System.Windows.Forms.ComboBox();
            this.ApplBut = new System.Windows.Forms.Button();
            this.CenclBut = new System.Windows.Forms.Button();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelMCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMcount)).BeginInit();
            this.PanelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMCount
            // 
            this.PanelMCount.BackColor = System.Drawing.SystemColors.Control;
            this.PanelMCount.Controls.Add(this.label1);
            this.PanelMCount.Controls.Add(this.NUMcount);
            this.PanelMCount.Location = new System.Drawing.Point(15, 42);
            this.PanelMCount.Name = "PanelMCount";
            this.PanelMCount.Size = new System.Drawing.Size(237, 48);
            this.PanelMCount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во";
            // 
            // NUMcount
            // 
            this.NUMcount.Location = new System.Drawing.Point(88, 13);
            this.NUMcount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NUMcount.Name = "NUMcount";
            this.NUMcount.Size = new System.Drawing.Size(149, 20);
            this.NUMcount.TabIndex = 0;
            this.NUMcount.ValueChanged += new System.EventHandler(this.MinusControl_SelectedIndexChanged);
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackColor = System.Drawing.SystemColors.Control;
            this.PanelStatus.Controls.Add(this.CBStatus);
            this.PanelStatus.Controls.Add(this.label2);
            this.PanelStatus.Location = new System.Drawing.Point(15, 42);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(237, 41);
            this.PanelStatus.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дефект";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Комментарий";
            // 
            // TBComm
            // 
            this.TBComm.Location = new System.Drawing.Point(15, 182);
            this.TBComm.Multiline = true;
            this.TBComm.Name = "TBComm";
            this.TBComm.Size = new System.Drawing.Size(237, 120);
            this.TBComm.TabIndex = 3;
            this.TBComm.TextChanged += new System.EventHandler(this.MinusControl_SelectedIndexChanged);
            // 
            // CBDef
            // 
            this.CBDef.DropDownWidth = 350;
            this.CBDef.FormattingEnabled = true;
            this.CBDef.Location = new System.Drawing.Point(103, 134);
            this.CBDef.Name = "CBDef";
            this.CBDef.Size = new System.Drawing.Size(149, 21);
            this.CBDef.TabIndex = 4;
            this.CBDef.SelectedIndexChanged += new System.EventHandler(this.MinusControl_SelectedIndexChanged);
            // 
            // ApplBut
            // 
            this.ApplBut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ApplBut.Location = new System.Drawing.Point(15, 308);
            this.ApplBut.Name = "ApplBut";
            this.ApplBut.Size = new System.Drawing.Size(75, 23);
            this.ApplBut.TabIndex = 5;
            this.ApplBut.Text = "ОК";
            this.ApplBut.UseVisualStyleBackColor = true;
            this.ApplBut.Click += new System.EventHandler(this.ApplBut_Click);
            // 
            // CenclBut
            // 
            this.CenclBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CenclBut.Location = new System.Drawing.Point(177, 308);
            this.CenclBut.Name = "CenclBut";
            this.CenclBut.Size = new System.Drawing.Size(75, 23);
            this.CenclBut.TabIndex = 5;
            this.CenclBut.Text = "Отмена";
            this.CenclBut.UseVisualStyleBackColor = true;
            this.CenclBut.Click += new System.EventHandler(this.CenclBut_Click);
            // 
            // CBType
            // 
            this.CBType.FormattingEnabled = true;
            this.CBType.Items.AddRange(new object[] {
            "Выработка",
            "Дефект"});
            this.CBType.Location = new System.Drawing.Point(103, 96);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(149, 21);
            this.CBType.TabIndex = 6;
            this.CBType.SelectedIndexChanged += new System.EventHandler(this.MinusControl_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Тип списания";
            // 
            // CBStatus
            // 
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Исправен",
            "Не исправен"});
            this.CBStatus.Location = new System.Drawing.Point(88, 10);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(149, 21);
            this.CBStatus.TabIndex = 3;
            this.CBStatus.SelectedIndexChanged += new System.EventHandler(this.MinusControl_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Статус";
            // 
            // FAddMinus
            // 
            this.AcceptButton = this.ApplBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CenclBut;
            this.ClientSize = new System.Drawing.Size(281, 349);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PanelStatus);
            this.Controls.Add(this.CenclBut);
            this.Controls.Add(this.ApplBut);
            this.Controls.Add(this.CBDef);
            this.Controls.Add(this.TBComm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelMCount);
            this.Name = "FAddMinus";
            this.Text = "Списание";
            this.PanelMCount.ResumeLayout(false);
            this.PanelMCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMcount)).EndInit();
            this.PanelStatus.ResumeLayout(false);
            this.PanelStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUMcount;
        private System.Windows.Forms.Panel PanelStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBComm;
        private System.Windows.Forms.ComboBox CBDef;
        private System.Windows.Forms.Button ApplBut;
        private System.Windows.Forms.Button CenclBut;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Label label2;
    }
}