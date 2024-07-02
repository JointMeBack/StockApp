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
    public partial class FAddMaterial : Form
    {
        Materials currentMaterial = null;
        public FAddMaterial()
        {
            InitializeComponent();
            btApply.Enabled = false;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadData(Materials material)
        {
            currentMaterial = material;
            tbMaterial.Text = material.MaterialName;
            mtbDeliveryDate.Text = material.DeliveryDate.ToString();
            cbUnit.Text = material.MesurementUnit;
            mtbMUnit.Text = material.UnitCount.ToString();
            cbMType.Text = material.TypeofMaterial;
            mtbManufDate.Text = material.ManufactureDate.ToString();
            tbContr.Text = material.Contractor;
        }
        private void btApply_Click(object sender, EventArgs e)
        {
            if (currentMaterial == null)
            {
                currentMaterial = new Materials(tbMaterial.Text, DateTime.Parse(mtbDeliveryDate.Text), cbUnit.Text, Int32.Parse(mtbMUnit.Text), cbMType.Text, DateTime.Parse(mtbManufDate.Text), tbContr.Text);
            }
            else
            {
                currentMaterial.MaterialName = tbMaterial.Text;
                currentMaterial.DeliveryDate = DateTime.Parse(mtbDeliveryDate.Text);
                currentMaterial.MesurementUnit = cbUnit.Text;
                currentMaterial.UnitCount = Int32.Parse(mtbMUnit.Text);
                currentMaterial.TypeofMaterial = cbMType.Text;
                currentMaterial.ManufactureDate = DateTime.Parse(mtbManufDate.Text);
                currentMaterial.Contractor = tbContr.Text;
                currentMaterial.Update();
            }
        }

        bool[] ctr = new bool[7];
        private void Control_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            switch (ct.Name)
            {
                case "tbMaterial":
                    ctr[0] = ((TextBox)sender).Text.Trim().Length != 0;
                    break;
                case "mtbDeliveryDate":
                    ctr[1] = ((MaskedTextBox)sender).Text.Trim().Length != 0;
                    break;
                case "cbUnit":
                    ctr[2] = ((ComboBox)sender).SelectedIndex != -1;
                    break;
                case "mtbMUnit":
                    ctr[3] = ((MaskedTextBox)sender).Text.Trim().Length != 0;
                    break;
                case "cbMType":
                    ctr[4] = ((ComboBox)sender).SelectedIndex != -1;
                    break;
                case "mtbManufDate":
                    ctr[5] = ((MaskedTextBox)sender).Text.Trim().Length != 0;
                    break;
                case "tbContr":
                    ctr[6] = ((TextBox)sender).Text.Trim().Length != 0;
                    break;
            }
            btApply.Enabled = ctr[0] && ctr[1] && ctr[2] && ctr[3] && ctr[4] && ctr[5] && ctr[6];
        }
        public Materials GetMaterial()
        {
            return currentMaterial;
        }
    }
}
