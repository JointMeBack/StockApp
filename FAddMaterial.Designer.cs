namespace StockApp
{
    partial class FAddMaterial
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
            this.tbMaterial = new System.Windows.Forms.TextBox();
            this.btApply = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.mtbDeliveryDate = new System.Windows.Forms.MaskedTextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbMUnit = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbManufDate = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbContr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Материал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата доставки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Единица измерения";
            // 
            // tbMaterial
            // 
            this.tbMaterial.Location = new System.Drawing.Point(169, 6);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Size = new System.Drawing.Size(100, 20);
            this.tbMaterial.TabIndex = 1;
            this.tbMaterial.TextChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // btApply
            // 
            this.btApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btApply.Location = new System.Drawing.Point(15, 259);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(75, 23);
            this.btApply.TabIndex = 2;
            this.btApply.Text = "Применить";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(194, 259);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // mtbDeliveryDate
            // 
            this.mtbDeliveryDate.Location = new System.Drawing.Point(207, 39);
            this.mtbDeliveryDate.Mask = "00/00/0000";
            this.mtbDeliveryDate.Name = "mtbDeliveryDate";
            this.mtbDeliveryDate.Size = new System.Drawing.Size(62, 20);
            this.mtbDeliveryDate.TabIndex = 3;
            this.mtbDeliveryDate.ValidatingType = typeof(System.DateTime);
            this.mtbDeliveryDate.TextChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "штука",
            "упаковка"});
            this.cbUnit.Location = new System.Drawing.Point(148, 72);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(121, 21);
            this.cbUnit.TabIndex = 4;
            this.cbUnit.SelectedIndexChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Кол-во";
            // 
            // mtbMUnit
            // 
            this.mtbMUnit.Location = new System.Drawing.Point(169, 106);
            this.mtbMUnit.Mask = "00000";
            this.mtbMUnit.Name = "mtbMUnit";
            this.mtbMUnit.Size = new System.Drawing.Size(100, 20);
            this.mtbMUnit.TabIndex = 5;
            this.mtbMUnit.ValidatingType = typeof(int);
            this.mtbMUnit.TextChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Тип материала";
            // 
            // cbMType
            // 
            this.cbMType.FormattingEnabled = true;
            this.cbMType.Items.AddRange(new object[] {
            "Дерево",
            "Металл",
            "Другое"});
            this.cbMType.Location = new System.Drawing.Point(148, 144);
            this.cbMType.Name = "cbMType";
            this.cbMType.Size = new System.Drawing.Size(121, 21);
            this.cbMType.TabIndex = 6;
            this.cbMType.SelectedIndexChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Дата изготовления";
            // 
            // mtbManufDate
            // 
            this.mtbManufDate.Location = new System.Drawing.Point(207, 176);
            this.mtbManufDate.Mask = "00/00/0000";
            this.mtbManufDate.Name = "mtbManufDate";
            this.mtbManufDate.Size = new System.Drawing.Size(62, 20);
            this.mtbManufDate.TabIndex = 3;
            this.mtbManufDate.ValidatingType = typeof(System.DateTime);
            this.mtbManufDate.TextChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Заказчик";
            // 
            // tbContr
            // 
            this.tbContr.Location = new System.Drawing.Point(169, 209);
            this.tbContr.Name = "tbContr";
            this.tbContr.Size = new System.Drawing.Size(100, 20);
            this.tbContr.TabIndex = 1;
            this.tbContr.TextChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // FAddMaterial
            // 
            this.AcceptButton = this.btApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(290, 294);
            this.Controls.Add(this.cbMType);
            this.Controls.Add(this.mtbMUnit);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.mtbManufDate);
            this.Controls.Add(this.mtbDeliveryDate);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.tbContr);
            this.Controls.Add(this.tbMaterial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAddMaterial";
            this.Text = "Добавить материал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaterial;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.MaskedTextBox mtbDeliveryDate;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbMUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbManufDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbContr;
    }
}