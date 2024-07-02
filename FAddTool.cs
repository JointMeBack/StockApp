using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp
{
    public partial class FAddTool : Form
    {
        Tools currentTool = null;

        public FAddTool()
        {
            InitializeComponent();
            FillControls();
            btApply.Enabled = false;
        }

        public void LoadData(Tools tool)
        {
            currentTool = tool;
            cbToolItem.SelectedItem = tool.ToolType;
            cbToolName.SelectedItem = tool.ToolName;
            tbToolModel.Text = tool.Model;
            mtbTInvNumber.Text = tool.InventoryNumber;
            mtbTCount.Text = tool.TCount.ToString();
            tbTDics.Text = tool.Discription;
        }


        private void btApply_Click(object sender, EventArgs e)
        {
            if (currentTool == null)
            {
                currentTool = new Tools(cbToolItem.Text, cbToolName.Text, tbToolModel.Text, mtbTInvNumber.Text, Int32.Parse(mtbTCount.Text), tbTDics.Text);
            }
            else
            {
                currentTool.ToolType = cbToolItem.Text;
                currentTool.ToolName = cbToolName.Text;
                currentTool.Model = tbToolModel.Text;
                currentTool.InventoryNumber = (string)mtbTInvNumber.Text;
                currentTool.TCount = Int32.Parse(mtbTCount.Text);
                currentTool.Discription = tbTDics.Text;
                currentTool.Update();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Tools GetTools()
        {
            return currentTool;
        }

        public void FillControls()
        {
            cbToolItem.Items.Clear();
            DataTable db = DBManager.DBSelect("Select id, TypeName from ToolTypeName");
            foreach (DataRow dr in db.Rows)
            {
                ComboItem cbi = new ComboItem(Convert.ToInt32(dr["id"]), dr["TypeName"].ToString());
                cbToolItem.Items.Add(cbi);
            }
            cbToolItem.SelectedIndex = 0;
        }

        public void FillToolRefs()
        {
            cbToolName.Items.Clear();
            if (cbToolItem.SelectedIndex < 0) return;
            ComboItem toolItem = (ComboItem)cbToolItem.SelectedItem;
            DataTable db = DBManager.DBSelect("Select idType, Tools from ToolTypeRef Where idType = " + toolItem.Id);
            foreach (DataRow dr in db.Rows)
            {
                ComboItem cbi = new ComboItem(Convert.ToInt32(dr["idType"]), dr["Tools"].ToString());
                cbToolName.Items.Add(cbi);
            }
            cbToolName.SelectedIndex = 0;
        }

        bool[] ctr = new bool[4];
        private void Control_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
                switch (ct.Name)
                {
                    case "cbToolItem":
                        FillToolRefs();
                        ctr[0] = ((ComboBox)sender).SelectedIndex != -1;
                        break;
                    case "mtbTInvNumber":
                        ctr[1] = ((MaskedTextBox)sender).Text.Trim().Length != 0;
                        break;
                    case "mtbTCount":
                        ctr[2] = ((MaskedTextBox)sender).Text.Trim().Length != 0;
                        break;
                    case "tbTDics":
                        ctr[3] = ((TextBox)sender).Text.Trim().Length != 0;
                        break;
                }
           btApply.Enabled = ctr[0] && ctr[1] && ctr[2] && ctr[3];
        }

    }
}
