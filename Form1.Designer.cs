namespace StockApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSExit = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.приходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьРасчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContent = new System.Windows.Forms.Panel();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMIEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIDel = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIPlus = new System.Windows.Forms.ToolStripMenuItem();
            this.btDel = new System.Windows.Forms.Button();
            this.btRed = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RemToolbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbTools = new System.Windows.Forms.RadioButton();
            this.rbTech = new System.Windows.Forms.RadioButton();
            this.rbMaterial = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.CMS.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкиToolStripMenuItem,
            this.справкиToolStripMenuItem1,
            this.складToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSProfile,
            this.TSExit});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.справкиToolStripMenuItem.Text = "Файл";
            // 
            // TSProfile
            // 
            this.TSProfile.Name = "TSProfile";
            this.TSProfile.Size = new System.Drawing.Size(185, 22);
            this.TSProfile.Text = "Настроить профиль";
            this.TSProfile.Click += new System.EventHandler(this.TSProfile_Click);
            // 
            // TSExit
            // 
            this.TSExit.Name = "TSExit";
            this.TSExit.Size = new System.Drawing.Size(185, 22);
            this.TSExit.Text = "Выход";
            this.TSExit.Click += new System.EventHandler(this.TSExit_Click);
            // 
            // справкиToolStripMenuItem1
            // 
            this.справкиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приходToolStripMenuItem,
            this.расходToolStripMenuItem,
            this.сформироватьРасчетToolStripMenuItem});
            this.справкиToolStripMenuItem1.Name = "справкиToolStripMenuItem1";
            this.справкиToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.справкиToolStripMenuItem1.Text = "Справки";
            // 
            // приходToolStripMenuItem
            // 
            this.приходToolStripMenuItem.Name = "приходToolStripMenuItem";
            this.приходToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.приходToolStripMenuItem.Text = "Наличие материала";
            // 
            // расходToolStripMenuItem
            // 
            this.расходToolStripMenuItem.Name = "расходToolStripMenuItem";
            this.расходToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.расходToolStripMenuItem.Text = "Наличие техники";
            // 
            // сформироватьРасчетToolStripMenuItem
            // 
            this.сформироватьРасчетToolStripMenuItem.Name = "сформироватьРасчетToolStripMenuItem";
            this.сформироватьРасчетToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.сформироватьРасчетToolStripMenuItem.Text = "Наличие инструмента";
            // 
            // складToolStripMenuItem1
            // 
            this.складToolStripMenuItem1.Name = "складToolStripMenuItem1";
            this.складToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.складToolStripMenuItem1.Text = "Склад";
            this.складToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelContent.Controls.Add(this.cbSearch);
            this.panelContent.Controls.Add(this.tbSearch);
            this.panelContent.Controls.Add(this.btnClear);
            this.panelContent.Controls.Add(this.btnSearch);
            this.panelContent.Controls.Add(this.dgvList);
            this.panelContent.Controls.Add(this.btDel);
            this.panelContent.Controls.Add(this.btRed);
            this.panelContent.Controls.Add(this.btAdd);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(152, 24);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(930, 570);
            this.panelContent.TabIndex = 1;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.ItemHeight = 13;
            this.cbSearch.Location = new System.Drawing.Point(702, 16);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 21);
            this.cbSearch.TabIndex = 5;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(585, 16);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 21);
            this.tbSearch.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(843, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(487, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.ContextMenuStrip = this.CMS;
            this.dgvList.Location = new System.Drawing.Point(0, 43);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(930, 527);
            this.dgvList.TabIndex = 2;
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIEdit,
            this.TSMIDel,
            this.TSMIMinus,
            this.TSMIPlus});
            this.CMS.Name = "contextMenuStrip1";
            this.CMS.Size = new System.Drawing.Size(155, 92);
            // 
            // TSMIEdit
            // 
            this.TSMIEdit.Name = "TSMIEdit";
            this.TSMIEdit.Size = new System.Drawing.Size(154, 22);
            this.TSMIEdit.Text = "Редактировать";
            this.TSMIEdit.Click += new System.EventHandler(this.btRed_Click);
            // 
            // TSMIDel
            // 
            this.TSMIDel.Name = "TSMIDel";
            this.TSMIDel.Size = new System.Drawing.Size(154, 22);
            this.TSMIDel.Text = "Удалить";
            this.TSMIDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // TSMIMinus
            // 
            this.TSMIMinus.Name = "TSMIMinus";
            this.TSMIMinus.Size = new System.Drawing.Size(154, 22);
            this.TSMIMinus.Text = "Списание";
            this.TSMIMinus.Click += new System.EventHandler(this.TSMIMinus_Click);
            // 
            // TSMIPlus
            // 
            this.TSMIPlus.Name = "TSMIPlus";
            this.TSMIPlus.Size = new System.Drawing.Size(154, 22);
            this.TSMIPlus.Text = "Пополнение";
            this.TSMIPlus.Click += new System.EventHandler(this.TSMIPlus_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(254, 10);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(71, 27);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btRed
            // 
            this.btRed.Location = new System.Drawing.Point(129, 10);
            this.btRed.Name = "btRed";
            this.btRed.Size = new System.Drawing.Size(102, 27);
            this.btRed.TabIndex = 1;
            this.btRed.Text = "Редактировать";
            this.btRed.UseVisualStyleBackColor = true;
            this.btRed.Click += new System.EventHandler(this.btRed_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(30, 10);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(71, 27);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.RemToolbtn);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(152, 570);
            this.panelMenu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Списания/Расход";
            // 
            // RemToolbtn
            // 
            this.RemToolbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RemToolbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemToolbtn.BackgroundImage")));
            this.RemToolbtn.Location = new System.Drawing.Point(26, 203);
            this.RemToolbtn.Name = "RemToolbtn";
            this.RemToolbtn.Size = new System.Drawing.Size(98, 96);
            this.RemToolbtn.TabIndex = 1;
            this.RemToolbtn.UseVisualStyleBackColor = false;
            this.RemToolbtn.Click += new System.EventHandler(this.RemToolbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rbTools);
            this.panel1.Controls.Add(this.rbTech);
            this.panel1.Controls.Add(this.rbMaterial);
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 128);
            this.panel1.TabIndex = 0;
            // 
            // rbTools
            // 
            this.rbTools.AutoSize = true;
            this.rbTools.Location = new System.Drawing.Point(9, 94);
            this.rbTools.Name = "rbTools";
            this.rbTools.Size = new System.Drawing.Size(94, 17);
            this.rbTools.TabIndex = 0;
            this.rbTools.Text = "Инструменты";
            this.rbTools.UseVisualStyleBackColor = true;
            this.rbTools.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbTech
            // 
            this.rbTech.AutoSize = true;
            this.rbTech.Location = new System.Drawing.Point(9, 50);
            this.rbTech.Name = "rbTech";
            this.rbTech.Size = new System.Drawing.Size(67, 17);
            this.rbTech.TabIndex = 0;
            this.rbTech.Text = "Техника";
            this.rbTech.UseVisualStyleBackColor = true;
            this.rbTech.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMaterial
            // 
            this.rbMaterial.AutoSize = true;
            this.rbMaterial.Checked = true;
            this.rbMaterial.Location = new System.Drawing.Point(9, 12);
            this.rbMaterial.Name = "rbMaterial";
            this.rbMaterial.Size = new System.Drawing.Size(83, 17);
            this.rbMaterial.TabIndex = 0;
            this.rbMaterial.TabStop = true;
            this.rbMaterial.Text = "Материалы";
            this.rbMaterial.UseVisualStyleBackColor = true;
            this.rbMaterial.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1082, 594);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "АИС склад";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.CMS.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSExit;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem приходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьРасчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbTools;
        private System.Windows.Forms.RadioButton rbTech;
        private System.Windows.Forms.RadioButton rbMaterial;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btRed;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ToolStripMenuItem TSProfile;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem TSMIEdit;
        private System.Windows.Forms.ToolStripMenuItem TSMIDel;
        private System.Windows.Forms.ToolStripMenuItem TSMIMinus;
        private System.Windows.Forms.ToolStripMenuItem TSMIPlus;
        private System.Windows.Forms.Button RemToolbtn;
        private System.Windows.Forms.Label label1;
    }
}

