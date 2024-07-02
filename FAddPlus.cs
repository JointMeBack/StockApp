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
    public partial class FAddPlus : Form
    {
        Materials mat = new Materials();
        public FAddPlus()
        {
            InitializeComponent();
        }
        public void LoadData(Materials material)
        {
            mat = material;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DBManager.DBNonQuery("Update tmaterials set MCount = " + (mat.UnitCount + Convert.ToInt32(NUDPlus.Value)) + " where tmaterials.id = " + mat.Id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
