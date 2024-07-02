using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StockApp.Defect;

namespace StockApp
{
    public partial class FAddMinus : Form
    {
        BaseItem currentItem;
        public FAddMinus(BaseItem item)
        {
            InitializeComponent();
            currentItem = item;
            label3.Visible = false;
            CBDef.Visible = false;
            ApplBut.Enabled = false;
            FillControlsDefects(currentItem.Type);

        }


        private void FillControlsDefects(EnTypeDefect type)
        {
            switch (type)
            {
                case EnTypeDefect.Material:
                    PanelMCount.Visible = true;
                    PanelStatus.Visible = false;
                    break;
                case EnTypeDefect.Tool:
                case EnTypeDefect.Tech:
                    PanelMCount.Visible = false;
                    PanelStatus.Visible = true;
                    break;
            }
            CBDef.Items.Clear();
            List<Defect> defects = Defect.GetListDefects(type);
            foreach (Defect def in defects)
                CBDef.Items.Add(def);
        }

        private bool GetStatus()
        {
            if (CBStatus.SelectedIndex == 0)
                return true;
            else return false;
        }

        bool[] ctr = new bool[3];
        private void MinusControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            if (PanelMCount.Visible == false)
            {
                switch (ct.Name)
                {
                    case "CBStatus":
                        ctr[0] = ((ComboBox)sender).SelectedIndex != -1;
                        break;
                    case "CBType":
                    case "CBDef":
                        ctr[1] = ((ComboBox)sender).SelectedIndex != -1;
                        if (CBType.Text == "Дефект")
                        {
                            label3.Visible = true;
                            CBDef.Visible = true;
                        }
                        if (CBType.Text == "Выработка")
                        {
                            label3.Visible = false;
                            CBDef.Visible = false;
                        }
                        break;
                    //case "CBDef":
                    //    ctr[2] = ((ComboBox)sender).SelectedIndex != -1;
                    //    break;
                    case "TBComm":
                        ctr[2] = ((TextBox)sender).Text.Trim().Length != 0;
                        break;
                }
                ApplBut.Enabled = ctr[0] && ctr[1] && ctr[2];
            }
            else
            {
                switch (ct.Name)
                {
                    case "NUMcount":
                        ctr[0] = ((NumericUpDown)sender).Value > 0;
                        break;
                    case "CBType":
                    case "CBDef":
                        ctr[1] = ((ComboBox)sender).SelectedIndex != -1;
                        if (CBType.Text == "Дефект")
                        {
                            label3.Visible = true;
                            CBDef.Visible = true;
                        }
                        if (CBType.Text == "Выработка")
                        {
                            label3.Visible = false;
                            CBDef.Visible = false;
                        }
                        break;
                    //case "CBDef":
                    //    ctr[2] = ((ComboBox)sender).SelectedIndex != -1;
                    //    break;
                    case "TBComm":
                        ctr[2] = ((TextBox)sender).Text.Trim().Length != 0;
                        break;
                }
                ApplBut.Enabled = ctr[0] && ctr[1] && ctr[2];
            }

        }
        

        private void ApplBut_Click(object sender, EventArgs e)
        {
            Defect def;
            if (currentItem == null) return;
            switch (currentItem.Type)
            {
                case EnTypeDefect.Material:
                    MaterialToDefect mtd = new MaterialToDefect();
                    mtd.Material = (Materials)currentItem;
                    mtd.Status = CBType.Text;
                    mtd.DefectCount = Convert.ToInt32(NUMcount.Value);
                    DataTable dt = DBManager.DBSelect("select id, DefectName from tMaterialDefects");
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["DefectName"].ToString() == CBDef.Text)
                        {
                            def = new Defect(Convert.ToInt32(dr["id"].ToString()), dr["DefectName"].ToString(), EnTypeDefect.Material);
                            mtd.def = def;
                        }

                    }
                    if (GetStat() == "Выработка")
                        mtd.Save();
                    else
                        mtd.SaveWithDef();
                    break;
                case EnTypeDefect.Tool:
                    ToolsToDefect ttd = new ToolsToDefect();
                    ttd.Tool = (Tools)currentItem;
                    ttd.Status = CBType.Text;
                    DataTable ddt = DBManager.DBSelect("select id, DefectName from tToolDefects");
                    foreach (DataRow dr in ddt.Rows)
                    {
                        if (dr["DefectName"].ToString() == CBDef.Text)
                        {
                            def = new Defect(Convert.ToInt32(dr["id"].ToString()), dr["DefectName"].ToString(), EnTypeDefect.Tool);
                            ttd.Tdef = def;
                            break;
                        }

                    }
                    ttd.Tool.Discription = TBComm.Text;
                    ttd.SaveT();
                    break;
                case EnTypeDefect.Tech:
                    TechToDefect tttd = new TechToDefect();
                    tttd.Tech = (Tech)currentItem;
                    tttd.Status = CBType.Text;
                    DataTable dddt = DBManager.DBSelect("select id, DefectName from tTechDefects");
                    foreach (DataRow dr in dddt.Rows)
                    {
                        if (dr["DefectName"].ToString() == CBDef.Text)
                        {
                            def = new Defect(Convert.ToInt32(dr["id"].ToString()), dr["DefectName"].ToString(), EnTypeDefect.Tech);
                            tttd.TCHdef = def;
                        }

                    }
                    tttd.Tech.Discription = TBComm.Text;
                    tttd.SaveTCH();
                    break;
            }
                    
        }

        public string GetStat()
        {
            return CBType.Text;
        }

        private void CenclBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
