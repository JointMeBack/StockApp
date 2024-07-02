using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp
{
    public partial class FAddTech : Form
    {
        Tech currentTech = null;
        public FAddTech()
        {
            InitializeComponent();
            FillControls();
            btTechApply.Enabled = false;
        }

        public bool getStatus()
        {
            if(cbTechStatus.SelectedIndex == 0)
            {
                return true;
            }
            else return false;
        }

        public void LoadData(Tech tech)
        {
            currentTech = tech;
            cbTechType.Text = tech.Model;
            cbTechCategory.Text = tech.Category;
            cbTechModel.Text = tech.TechName;
            tbTechNum.Text = tech.TechNumber;
            if(tech.TechCondition == true)
            {
                cbTechStatus.SelectedIndex = 0;
            }
            if(tech.TechCondition == false)
            {
                cbTechStatus.SelectedIndex = 1;
            }
            mtbIssueYear.Text = tech.IssueYear.ToString();
            tbTechDisc.Text = tech.Discription;
        }

        public void FillControls()
        {
            cbTechType.Items.Clear();
            DataTable db = DBManager.DBSelect("Select id, ModelType from TechModelType");
            foreach (DataRow dr in db.Rows)
            {
                ComboItem cbi = new ComboItem(Convert.ToInt32(dr["id"]), dr["ModelType"].ToString());
                cbTechType.Items.Add(cbi);
            }
        }

        public void FillTechRefs()
        {
            cbTechModel.Items.Clear();
            if (cbTechType.SelectedIndex < 0) return;
            ComboItem techItem = (ComboItem)cbTechType.SelectedItem;
            DataTable db = DBManager.DBSelect("Select idModel, ModelName from TechTypeRef Where idModel = " + techItem.Id);
            foreach (DataRow dr in db.Rows)
            {
                ComboItem cbi = new ComboItem(Convert.ToInt32(dr["idModel"]), dr["ModelName"].ToString());
                cbTechModel.Items.Add(cbi);
            }
        }

        private void btTechApply_Click(object sender, EventArgs e)
        {
            if(currentTech == null)
            {
                currentTech = new Tech(cbTechType.Text, cbTechCategory.Text, cbTechModel.Text, tbTechNum.Text, getStatus(), Int32.Parse(mtbIssueYear.Text), tbTechDisc.Text);
            }
            else
            {

                currentTech.Model = cbTechType.Text;
                currentTech.Category = cbTechCategory.Text;
                currentTech.TechName = cbTechModel.Text;
                currentTech.TechNumber = tbTechNum.Text;
                if (cbTechStatus.SelectedIndex == 0)
                {
                    currentTech.TechCondition = true;
                }
                if (cbTechStatus.SelectedIndex == 1)
                {
                    currentTech.TechCondition = false;
                }
                currentTech.IssueYear = Int32.Parse(mtbIssueYear.Text);
                currentTech.Discription = tbTechDisc.Text;
                currentTech.Update();
            }
        }

        private void btTechCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Tech GetTech()
        {
            return currentTech;
        }

        bool[] ctr = new bool[6];
        private void TechControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            switch (ct.Name)
            {
                case "cbTechType":
                    FillTechRefs();
                    ctr[0] = ((ComboBox)sender).SelectedIndex != -1;
                    break;
                case "cbTechCategory":
                    ctr[1] = ((ComboBox)sender).SelectedIndex != -1;
                    break;
                case "cbTechModel":
                    ctr[2] = ((ComboBox)sender).SelectedIndex != -1;
                    break;
                case "tbTechNum":
                    ctr[3] = ((TextBox)sender).Text.Trim().Length != 0;
                    break;
                case "cbTechStatus":
                    ctr[4] = ((ComboBox)sender).SelectedIndex != -1;
                    break;
                case "mtbIssueYear":
                    ctr[5] = ((MaskedTextBox)sender).Text.Trim().Length != 0;
                    break;
                
            }
            btTechApply.Enabled = ctr[0] && ctr[1] && ctr[2] && ctr[3] && ctr[4] && ctr[5];
        }
    }
}
