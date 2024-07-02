using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp
{
    public partial class ViewDefect : Form
    {

        public ViewDefect()
        {
            InitializeComponent();
            object_changed(TabControl, new EventArgs());
        }

        string query;
        string[] headers = { "Материал", "Ед.измерения", "Кол-во", "Тип", "Статус", "Дата списания" };
        string[] headersT = { "Тип инструмента", "Название", "Модель", "Инвентарный номер", "Статус", "Дата списания", "Id" };
        string[] headersTCH = { "Модель", "Категория прав", "Название", "Гос. номер", "Год выпуска", "Статус", "Дата списания", "Id" };
        private void object_changed(object sender, EventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    ResBut.Enabled = false;
                    delBut.Enabled = false;
                    query = "select materialname, measurementunit, mdefectcount, typeofmaterial, " +
                "status, currentdate from tmaterials join materialtodefect on materialtodefect.idmaterial = tmaterials.id join UserToMaterial on tMaterials.id = UserToMaterial.idMaterial where idUser = " + Program.currentUser.Id + "";

                    DataTable dt = DBManager.DBSelect(query);
                    dgvMDef.DataSource = dt;
                    if(dt.Rows.Count > 0 )
                    {
                        for (int i = 0; i < headers.Length; i++)
                            dgvMDef.Columns[i].HeaderText = headers[i];
                    }
                    
                    break;
                case 1:
                    ResBut.Enabled = true;
                    delBut.Enabled = true;
                    query = "select tooltype, toolname, Model, InventoryNumber, " +
                "status, currentdate, ttools.id from ttools join tooltodefect on tooltodefect.idtool = ttools.id join UserToTool on tTools.id = UserToTool.idTool where idUser = " + Program.currentUser.Id + "";

                    DataTable ddt = DBManager.DBSelect(query);
                    dgvTCHDef.DataSource = ddt;
                    if (ddt.Rows.Count > 0)
                    {
                        for (int i = 0; i < headersT.Length; i++)
                            dgvTCHDef.Columns[i].HeaderText = headersT[i];
                    }
                        
                    break;
                case 2:
                    ResBut.Enabled = true;
                    delBut.Enabled = true;
                    query = "select model, category, techname, technumber, issueyear, status, currentdate, ttech.id from ttech join techtodefect on techtodefect.idtech = ttech.id join UserToTech on tTech.id = UserToTech.idTech where idUser = " + Program.currentUser.Id + "";

                    DataTable dddt = DBManager.DBSelect(query);
                    dgvTDef.DataSource = dddt;
                    if(dddt.Rows.Count > 0)
                    {
                        for (int i = 0; i < headersTCH.Length; i++)
                            dgvTDef.Columns[i].HeaderText = headersTCH[i];
                    }
                    
                    break;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResBut_Click(object sender, EventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 1:

                    DBManager.DBNonQuery("Update tTools set ToolCondition = " + true + " where id = " + Convert.ToInt32(dgvTCHDef.SelectedCells[6].Value));
                    DBManager.DBNonQuery("Delete from ToolToDefect where idTool = " + Convert.ToInt32(dgvTCHDef.SelectedCells[6].Value));
                    query = "select tooltype, toolname, Model, InventoryNumber, " +
               "status, currentdate, ttools.id from ttools join tooltodefect on tooltodefect.idtool = ttools.id";

                    DataTable ddt = DBManager.DBSelect(query);
                    dgvTCHDef.DataSource = ddt;
                    if (ddt.Rows.Count > 0)
                    {
                        for (int i = 0; i < headersT.Length; i++)
                            dgvTCHDef.Columns[i].HeaderText = headersT[i];
                    }
                    break;
                case 2:

                    DBManager.DBNonQuery("Update tTech set TechCondition = " + true + " where id = " + Convert.ToInt32(dgvTDef.SelectedCells[7].Value));
                    DBManager.DBNonQuery("Delete from TechToDefect where idTech = " + Convert.ToInt32(dgvTDef.SelectedCells[7].Value));
                    query = "select model, category, techname, technumber, issueyear, status, currentdate, ttech.id from ttech join techtodefect on techtodefect.idtech = ttech.id";

                    DataTable dddt = DBManager.DBSelect(query);
                    dgvTDef.DataSource = dddt;
                    if (dddt.Rows.Count > 0)
                    {
                        for (int i = 0; i < headersTCH.Length; i++)
                            dgvTDef.Columns[i].HeaderText = headersTCH[i];
                    }
                    break;
            }
            
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 1:

                    DBManager.DBNonQuery("Delete from ToolToDefect where idTool = " + Convert.ToInt32(dgvTCHDef.SelectedCells[6].Value));
                    DBManager.DBNonQuery("Delete from tTools where id = " + Convert.ToInt32(dgvTCHDef.SelectedCells[6].Value));
                    query = "select tooltype, toolname, Model, InventoryNumber, " +
               "status, currentdate, ttools.id from ttools join tooltodefect on tooltodefect.idtool = ttools.id";

                    DataTable ddt = DBManager.DBSelect(query);
                    dgvTCHDef.DataSource = ddt;
                    if (ddt.Rows.Count > 0)
                    {
                        for (int i = 0; i < headersT.Length; i++)
                            dgvTCHDef.Columns[i].HeaderText = headersT[i];
                    }
                    break;
                case 2:

                    DBManager.DBNonQuery("Delete from TechToDefect where idTech = " + Convert.ToInt32(dgvTDef.SelectedCells[7].Value));
                    DBManager.DBNonQuery("Delete from tTech where id = " + Convert.ToInt32(dgvTDef.SelectedCells[7].Value));
                    query = "select model, category, techname, technumber, issueyear, status, currentdate, ttech.id from ttech join techtodefect on techtodefect.idtech = ttech.id";
                    DataTable dddt = DBManager.DBSelect(query);
                    dgvTDef.DataSource = dddt;
                    if (dddt.Rows.Count > 0)
                    {
                        for (int i = 0; i < headersTCH.Length; i++)
                            dgvTDef.Columns[i].HeaderText = headersTCH[i];
                    }
                    break;
            }
        }
    }
}
