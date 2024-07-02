namespace StockApp
{
    partial class FAddTech
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTechDisc = new System.Windows.Forms.TextBox();
            this.btTechApply = new System.Windows.Forms.Button();
            this.btTechCencel = new System.Windows.Forms.Button();
            this.mtbIssueYear = new System.Windows.Forms.MaskedTextBox();
            this.cbTechType = new System.Windows.Forms.ComboBox();
            this.cbTechCategory = new System.Windows.Forms.ComboBox();
            this.cbTechModel = new System.Windows.Forms.ComboBox();
            this.tbTechNum = new System.Windows.Forms.TextBox();
            this.cbTechStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип технического средства";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Категория прав";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Марка/Модель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Номер ТС";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Состояние транспортного средства";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Год выпуска";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Примечание*";
            // 
            // tbTechDisc
            // 
            this.tbTechDisc.Location = new System.Drawing.Point(15, 235);
            this.tbTechDisc.Multiline = true;
            this.tbTechDisc.Name = "tbTechDisc";
            this.tbTechDisc.Size = new System.Drawing.Size(420, 145);
            this.tbTechDisc.TabIndex = 1;
            // 
            // btTechApply
            // 
            this.btTechApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btTechApply.Location = new System.Drawing.Point(254, 397);
            this.btTechApply.Name = "btTechApply";
            this.btTechApply.Size = new System.Drawing.Size(75, 23);
            this.btTechApply.TabIndex = 2;
            this.btTechApply.Text = "Применить";
            this.btTechApply.UseVisualStyleBackColor = true;
            this.btTechApply.Click += new System.EventHandler(this.btTechApply_Click);
            // 
            // btTechCencel
            // 
            this.btTechCencel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btTechCencel.Location = new System.Drawing.Point(357, 397);
            this.btTechCencel.Name = "btTechCencel";
            this.btTechCencel.Size = new System.Drawing.Size(75, 23);
            this.btTechCencel.TabIndex = 2;
            this.btTechCencel.Text = "Отменить";
            this.btTechCencel.UseVisualStyleBackColor = true;
            this.btTechCencel.Click += new System.EventHandler(this.btTechCencel_Click);
            // 
            // mtbIssueYear
            // 
            this.mtbIssueYear.Location = new System.Drawing.Point(341, 180);
            this.mtbIssueYear.Mask = "0000";
            this.mtbIssueYear.Name = "mtbIssueYear";
            this.mtbIssueYear.Size = new System.Drawing.Size(94, 20);
            this.mtbIssueYear.TabIndex = 3;
            this.mtbIssueYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbIssueYear.ValidatingType = typeof(int);
            this.mtbIssueYear.TextChanged += new System.EventHandler(this.TechControl_SelectedIndexChanged);
            // 
            // cbTechType
            // 
            this.cbTechType.FormattingEnabled = true;
            this.cbTechType.Location = new System.Drawing.Point(201, 18);
            this.cbTechType.Name = "cbTechType";
            this.cbTechType.Size = new System.Drawing.Size(234, 21);
            this.cbTechType.TabIndex = 4;
            this.cbTechType.SelectedIndexChanged += new System.EventHandler(this.TechControl_SelectedIndexChanged);
            // 
            // cbTechCategory
            // 
            this.cbTechCategory.FormattingEnabled = true;
            this.cbTechCategory.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "-"});
            this.cbTechCategory.Location = new System.Drawing.Point(363, 50);
            this.cbTechCategory.Name = "cbTechCategory";
            this.cbTechCategory.Size = new System.Drawing.Size(72, 21);
            this.cbTechCategory.TabIndex = 4;
            this.cbTechCategory.SelectedIndexChanged += new System.EventHandler(this.TechControl_SelectedIndexChanged);
            // 
            // cbTechModel
            // 
            this.cbTechModel.FormattingEnabled = true;
            this.cbTechModel.Location = new System.Drawing.Point(201, 83);
            this.cbTechModel.Name = "cbTechModel";
            this.cbTechModel.Size = new System.Drawing.Size(234, 21);
            this.cbTechModel.TabIndex = 4;
            this.cbTechModel.SelectedIndexChanged += new System.EventHandler(this.TechControl_SelectedIndexChanged);
            // 
            // tbTechNum
            // 
            this.tbTechNum.Location = new System.Drawing.Point(341, 115);
            this.tbTechNum.Name = "tbTechNum";
            this.tbTechNum.Size = new System.Drawing.Size(94, 20);
            this.tbTechNum.TabIndex = 5;
            this.tbTechNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTechNum.TextChanged += new System.EventHandler(this.TechControl_SelectedIndexChanged);
            // 
            // cbTechStatus
            // 
            this.cbTechStatus.FormattingEnabled = true;
            this.cbTechStatus.Items.AddRange(new object[] {
            "Исправен",
            "Не исправен"});
            this.cbTechStatus.Location = new System.Drawing.Point(341, 147);
            this.cbTechStatus.Name = "cbTechStatus";
            this.cbTechStatus.Size = new System.Drawing.Size(94, 21);
            this.cbTechStatus.TabIndex = 4;
            this.cbTechStatus.SelectedIndexChanged += new System.EventHandler(this.TechControl_SelectedIndexChanged);
            // 
            // FAddTech
            // 
            this.AcceptButton = this.btTechApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btTechCencel;
            this.ClientSize = new System.Drawing.Size(447, 432);
            this.Controls.Add(this.tbTechNum);
            this.Controls.Add(this.cbTechModel);
            this.Controls.Add(this.cbTechStatus);
            this.Controls.Add(this.cbTechCategory);
            this.Controls.Add(this.cbTechType);
            this.Controls.Add(this.mtbIssueYear);
            this.Controls.Add(this.btTechCencel);
            this.Controls.Add(this.btTechApply);
            this.Controls.Add(this.tbTechDisc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAddTech";
            this.Text = "Добавить технику";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTechDisc;
        private System.Windows.Forms.Button btTechApply;
        private System.Windows.Forms.Button btTechCencel;
        private System.Windows.Forms.MaskedTextBox mtbIssueYear;
        private System.Windows.Forms.ComboBox cbTechType;
        private System.Windows.Forms.ComboBox cbTechCategory;
        private System.Windows.Forms.ComboBox cbTechModel;
        private System.Windows.Forms.TextBox tbTechNum;
        private System.Windows.Forms.ComboBox cbTechStatus;
    }
}