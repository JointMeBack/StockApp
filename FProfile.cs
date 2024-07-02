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
    public partial class FProfile : Form
    {
        Profile currentProfile;
        public FProfile()
        {
            InitializeComponent();
            FillControls();
        }

        public void FillControls()
        {
            cbDistNum.Items.Clear();
            for (int i = 1; i < 31; i++)
            {
                cbDistNum.Items.Add(new ComboItem(i, "Цех №" + i));
            }
            cbDistNum.SelectedIndex = 0;
        }

        public void LoadData(Profile profile)
        {
            currentProfile = profile;
            tbFN.Text = profile.FirstName;
            tbMN.Text = profile.MiddleName;
            tbSN.Text = profile.SecondName;
            tbWP.Text = profile.WorkPhone;
            tbPh.Text = profile.Phone;
            for (int i = 0; i < cbDistNum.Items.Count; i++)
            {
                if (((ComboItem)cbDistNum.Items[i]).Id == profile.DistrictNumber)
                    cbDistNum.SelectedIndex = i;
            }
            tbAdress.Text = profile.Adress;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (currentProfile == null)
            {
                currentProfile = new Profile(tbFN.Text, tbMN.Text, tbSN.Text, tbWP.Text, tbPh.Text, cbDistNum.SelectedIndex + 1, tbAdress.Text);
            }
            else
            {
                currentProfile.FirstName = tbFN.Text;
                currentProfile.MiddleName = tbMN.Text;
                currentProfile.SecondName = tbSN.Text;
                currentProfile.WorkPhone = tbWP.Text;
                currentProfile.Phone = tbPh.Text;
                currentProfile.DistrictNumber = ((ComboItem)cbDistNum.SelectedItem).Id;
                currentProfile.Adress = tbAdress.Text;
                currentProfile.Update();
            }
        }

        public Profile GetProfile()
        {
            return currentProfile;
        }
    }
}
