namespace StockApp
{
    partial class FAddTool
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
            this.btApply = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTDics = new System.Windows.Forms.TextBox();
            this.mtbTCount = new System.Windows.Forms.MaskedTextBox();
            this.cbToolItem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbToolName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbToolModel = new System.Windows.Forms.TextBox();
            this.mtbTInvNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btApply
            // 
            this.btApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btApply.Location = new System.Drawing.Point(264, 385);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(82, 23);
            this.btApply.TabIndex = 1;
            this.btApply.Text = "Подтвердить";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(366, 385);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Отменить";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип инструмента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Инвентарный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Описание*";
            // 
            // tbTDics
            // 
            this.tbTDics.Location = new System.Drawing.Point(16, 221);
            this.tbTDics.Multiline = true;
            this.tbTDics.Name = "tbTDics";
            this.tbTDics.Size = new System.Drawing.Size(425, 148);
            this.tbTDics.TabIndex = 3;
            this.tbTDics.TextChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // mtbTCount
            // 
            this.mtbTCount.Location = new System.Drawing.Point(366, 153);
            this.mtbTCount.Mask = "00000";
            this.mtbTCount.Name = "mtbTCount";
            this.mtbTCount.Size = new System.Drawing.Size(75, 20);
            this.mtbTCount.TabIndex = 5;
            this.mtbTCount.ValidatingType = typeof(int);
            this.mtbTCount.TextChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // cbToolItem
            // 
            this.cbToolItem.FormattingEnabled = true;
            this.cbToolItem.Location = new System.Drawing.Point(165, 13);
            this.cbToolItem.Name = "cbToolItem";
            this.cbToolItem.Size = new System.Drawing.Size(276, 21);
            this.cbToolItem.TabIndex = 6;
            this.cbToolItem.SelectedIndexChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Название";
            // 
            // cbToolName
            // 
            this.cbToolName.FormattingEnabled = true;
            this.cbToolName.Location = new System.Drawing.Point(165, 51);
            this.cbToolName.Name = "cbToolName";
            this.cbToolName.Size = new System.Drawing.Size(276, 21);
            this.cbToolName.TabIndex = 6;
            this.cbToolName.SelectedIndexChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Модель";
            // 
            // tbToolModel
            // 
            this.tbToolModel.Location = new System.Drawing.Point(165, 86);
            this.tbToolModel.Name = "tbToolModel";
            this.tbToolModel.Size = new System.Drawing.Size(276, 20);
            this.tbToolModel.TabIndex = 7;
            // 
            // mtbTInvNumber
            // 
            this.mtbTInvNumber.Location = new System.Drawing.Point(366, 123);
            this.mtbTInvNumber.Mask = "000-00-0000";
            this.mtbTInvNumber.Name = "mtbTInvNumber";
            this.mtbTInvNumber.Size = new System.Drawing.Size(75, 20);
            this.mtbTInvNumber.TabIndex = 8;
            this.mtbTInvNumber.TextChanged += new System.EventHandler(this.Control_SelectedIndexChanged);
            // 
            // FAddTool
            // 
            this.AcceptButton = this.btApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(453, 420);
            this.Controls.Add(this.mtbTInvNumber);
            this.Controls.Add(this.tbToolModel);
            this.Controls.Add(this.cbToolName);
            this.Controls.Add(this.cbToolItem);
            this.Controls.Add(this.mtbTCount);
            this.Controls.Add(this.tbTDics);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btApply);
            this.Name = "FAddTool";
            this.Text = "Добавить инструмент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTDics;
        private System.Windows.Forms.MaskedTextBox mtbTCount;
        private System.Windows.Forms.ComboBox cbToolItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbToolName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbToolModel;
        private System.Windows.Forms.BindingSource tooltypenameBindingSource1;
        private System.Windows.Forms.MaskedTextBox mtbTInvNumber;
    }
}