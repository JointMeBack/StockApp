namespace StockApp
{
    partial class ViewDefect
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Материалы = new System.Windows.Forms.TabPage();
            this.dgvMDef = new System.Windows.Forms.DataGridView();
            this.Инструменты = new System.Windows.Forms.TabPage();
            this.dgvTCHDef = new System.Windows.Forms.DataGridView();
            this.Техника = new System.Windows.Forms.TabPage();
            this.dgvTDef = new System.Windows.Forms.DataGridView();
            this.ResBut = new System.Windows.Forms.Button();
            this.delBut = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.Материалы.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMDef)).BeginInit();
            this.Инструменты.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTCHDef)).BeginInit();
            this.Техника.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDef)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Материалы);
            this.TabControl.Controls.Add(this.Инструменты);
            this.TabControl.Controls.Add(this.Техника);
            this.TabControl.Location = new System.Drawing.Point(-1, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(805, 391);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.object_changed);
            // 
            // Материалы
            // 
            this.Материалы.Controls.Add(this.dgvMDef);
            this.Материалы.Location = new System.Drawing.Point(4, 22);
            this.Материалы.Name = "Материалы";
            this.Материалы.Padding = new System.Windows.Forms.Padding(3);
            this.Материалы.Size = new System.Drawing.Size(797, 365);
            this.Материалы.TabIndex = 0;
            this.Материалы.Text = "Материалы";
            this.Материалы.UseVisualStyleBackColor = true;
            // 
            // dgvMDef
            // 
            this.dgvMDef.AllowUserToAddRows = false;
            this.dgvMDef.AllowUserToDeleteRows = false;
            this.dgvMDef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMDef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMDef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMDef.Location = new System.Drawing.Point(3, 3);
            this.dgvMDef.Name = "dgvMDef";
            this.dgvMDef.Size = new System.Drawing.Size(791, 359);
            this.dgvMDef.TabIndex = 0;
            // 
            // Инструменты
            // 
            this.Инструменты.Controls.Add(this.dgvTCHDef);
            this.Инструменты.Location = new System.Drawing.Point(4, 22);
            this.Инструменты.Name = "Инструменты";
            this.Инструменты.Padding = new System.Windows.Forms.Padding(3);
            this.Инструменты.Size = new System.Drawing.Size(797, 365);
            this.Инструменты.TabIndex = 1;
            this.Инструменты.Text = "Инструменты";
            this.Инструменты.UseVisualStyleBackColor = true;
            // 
            // dgvTCHDef
            // 
            this.dgvTCHDef.AllowUserToAddRows = false;
            this.dgvTCHDef.AllowUserToDeleteRows = false;
            this.dgvTCHDef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTCHDef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTCHDef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTCHDef.Location = new System.Drawing.Point(3, 3);
            this.dgvTCHDef.Name = "dgvTCHDef";
            this.dgvTCHDef.Size = new System.Drawing.Size(791, 359);
            this.dgvTCHDef.TabIndex = 1;
            // 
            // Техника
            // 
            this.Техника.Controls.Add(this.dgvTDef);
            this.Техника.Location = new System.Drawing.Point(4, 22);
            this.Техника.Name = "Техника";
            this.Техника.Padding = new System.Windows.Forms.Padding(3);
            this.Техника.Size = new System.Drawing.Size(797, 365);
            this.Техника.TabIndex = 2;
            this.Техника.Text = "Техника";
            this.Техника.UseVisualStyleBackColor = true;
            // 
            // dgvTDef
            // 
            this.dgvTDef.AllowUserToAddRows = false;
            this.dgvTDef.AllowUserToDeleteRows = false;
            this.dgvTDef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTDef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTDef.Location = new System.Drawing.Point(3, 3);
            this.dgvTDef.Name = "dgvTDef";
            this.dgvTDef.Size = new System.Drawing.Size(791, 359);
            this.dgvTDef.TabIndex = 0;
            // 
            // ResBut
            // 
            this.ResBut.Location = new System.Drawing.Point(357, 409);
            this.ResBut.Name = "ResBut";
            this.ResBut.Size = new System.Drawing.Size(100, 23);
            this.ResBut.TabIndex = 1;
            this.ResBut.Text = "Восстановить";
            this.ResBut.UseVisualStyleBackColor = true;
            this.ResBut.Click += new System.EventHandler(this.ResBut_Click);
            // 
            // delBut
            // 
            this.delBut.Location = new System.Drawing.Point(12, 409);
            this.delBut.Name = "delBut";
            this.delBut.Size = new System.Drawing.Size(75, 23);
            this.delBut.TabIndex = 1;
            this.delBut.Text = "Удалить";
            this.delBut.UseVisualStyleBackColor = true;
            this.delBut.Click += new System.EventHandler(this.delBut_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(713, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewDefect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delBut);
            this.Controls.Add(this.ResBut);
            this.Controls.Add(this.TabControl);
            this.Name = "ViewDefect";
            this.Text = "Дефекты/Списания";
            this.TabControl.ResumeLayout(false);
            this.Материалы.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMDef)).EndInit();
            this.Инструменты.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTCHDef)).EndInit();
            this.Техника.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDef)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Материалы;
        private System.Windows.Forms.TabPage Инструменты;
        private System.Windows.Forms.TabPage Техника;
        private System.Windows.Forms.DataGridView dgvMDef;
        private System.Windows.Forms.DataGridView dgvTCHDef;
        private System.Windows.Forms.Button ResBut;
        private System.Windows.Forms.Button delBut;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvTDef;
    }
}