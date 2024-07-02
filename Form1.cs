using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockApp
{
    public partial class Form1 : Form
    {
        List<Materials> listM = new List<Materials>();
        List<Materials> listMSearch = new List<Materials>();
        List<Tools> listT = new List<Tools>();
        List<Tools> listTSearch = new List<Tools>();
        List<Tech> listTCH = new List<Tech>();
        List<Tech> listTCHSearch = new List<Tech>();
        string query;

        string[] materialArr = { "Материал", "Дата поставки", "Ед.измерения", "Кол-во", "Тип материала", "Дата изготовления", "Заказчик" };
        string[] toolArr = { "Тип инструмента", "Название", "Модель", "Инвентарный номер", "Кол-во", "Описание" };
        string[] techArr = { "Тип ТС", "Категория прав", "Марка", "Номер", "Состояние", "Год выпуска", "Описание" };

        public Form1()
        {

            Autorization auto = new Autorization();
            do
            {
                auto.ShowDialog();
            } while (!auto.IsClose);

            InitializeComponent();
            listM = Materials.LoadMaterials();
            listT = Tools.LoadTools();
            listTCH = Tech.LoadTech();
            FillGridViewMaterial(listM);
            cbSearch.Items.Clear();
            cbSearch.Items.AddRange(materialArr);
        }


        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            if (rbMaterial.Checked)
            {
                FAddMaterial fAddMaterial = new FAddMaterial();
                if (fAddMaterial.ShowDialog() == DialogResult.OK)
                {
                    Materials material = fAddMaterial.GetMaterial();
                    if (material.Save())
                        listM.Add(material);
                    FillGridViewMaterial(listM);
                }
            }
            if (rbTools.Checked)
            {
                FAddTool fAddTool = new FAddTool();
                if (fAddTool.ShowDialog() == DialogResult.OK)
                {
                    Tools tool = fAddTool.GetTools();
                    if (tool.Save())
                        listT.Add(tool);
                    FillGridViewTool(listT);
                }
            }
            if (rbTech.Checked)
            {
                FAddTech fAddTech = new FAddTech();
                if (fAddTech.ShowDialog() == DialogResult.OK)
                {
                    Tech tech = fAddTech.GetTech();
                    if (tech.Save())
                        listTCH.Add(tech);
                    FillGridViewTech(listTCH);
                }
            }

        }


        private void FillGridViewMaterial(List<Materials> listM)
        {
            dgvList.Rows.Clear();
            dgvList.Columns.Clear();
            if (listM.Count == 0)
            {
                return;
            }

            dgvList.RowCount = listM.Count;
            dgvList.ColumnCount = 7;
            dgvList.Columns[0].HeaderText = "Материал";
            dgvList.Columns[1].HeaderText = "Дата поставки";
            dgvList.Columns[2].HeaderText = "Ед.измерения";
            dgvList.Columns[3].HeaderText = "Кол-во";
            dgvList.Columns[4].HeaderText = "Тип материала";
            dgvList.Columns[5].HeaderText = "Дата изготовления";
            dgvList.Columns[6].HeaderText = "Заказчик";
            for (int i = 0; i < listM.Count; i++)
            {
                dgvList.Rows[i].Tag = listM[i];
                dgvList.Rows[i].Cells[0].Value = listM[i].MaterialName;
                dgvList.Rows[i].Cells[1].Value = listM[i].DeliveryDate.ToShortDateString();
                dgvList.Rows[i].Cells[2].Value = listM[i].MesurementUnit;
                dgvList.Rows[i].Cells[3].Value = listM[i].UnitCount;
                dgvList.Rows[i].Cells[4].Value = listM[i].TypeofMaterial;
                dgvList.Rows[i].Cells[5].Value = listM[i].ManufactureDate.ToShortDateString();
                dgvList.Rows[i].Cells[6].Value = listM[i].Contractor;
            }

        }

        private void FillGridViewTool(List<Tools> listT)
        {
            dgvList.Rows.Clear();
            dgvList.Columns.Clear();
            if (listT.Count == 0)
            {
                return;
            }


            dgvList.RowCount = listT.Count;
            dgvList.ColumnCount = 6;
            dgvList.Columns[0].HeaderText = "Тип инструмента";
            dgvList.Columns[1].HeaderText = "Название";
            dgvList.Columns[2].HeaderText = "Модель";
            dgvList.Columns[3].HeaderText = "Инвентарный номер";
            dgvList.Columns[4].HeaderText = "Кол-во";
            dgvList.Columns[5].HeaderText = "Описание";
            for (int i = 0; i < listT.Count; i++)
            {
                dgvList.Rows[i].Tag = listT[i];
                dgvList.Rows[i].Cells[0].Value = listT[i].ToolType;
                dgvList.Rows[i].Cells[1].Value = listT[i].ToolName;
                dgvList.Rows[i].Cells[2].Value = listT[i].Model;
                dgvList.Rows[i].Cells[3].Value = listT[i].InventoryNumber;
                dgvList.Rows[i].Cells[4].Value = listT[i].TCount;
                dgvList.Rows[i].Cells[5].Value = listT[i].Discription;
            }


        }

        private void FillGridViewTech(List<Tech> listTCH)
        {
            dgvList.Rows.Clear();
            dgvList.Columns.Clear();
            if (listTCH.Count == 0)
            {
                return;
            }


            dgvList.RowCount = listTCH.Count;
            dgvList.ColumnCount = 7;
            dgvList.Columns[0].HeaderText = "Тип ТС";
            dgvList.Columns[1].HeaderText = "Категория прав";
            dgvList.Columns[2].HeaderText = "Марка";
            dgvList.Columns[3].HeaderText = "Номер";
            dgvList.Columns[4].HeaderText = "Состояние";
            dgvList.Columns[5].HeaderText = "Год выпуска";
            dgvList.Columns[6].HeaderText = "Описание";
            for (int i = 0; i < listTCH.Count; i++)
            {

                dgvList.Rows[i].Tag = listTCH[i];
                dgvList.Rows[i].Cells[0].Value = listTCH[i].Model;
                dgvList.Rows[i].Cells[1].Value = listTCH[i].Category;
                dgvList.Rows[i].Cells[2].Value = listTCH[i].TechName;
                dgvList.Rows[i].Cells[3].Value = listTCH[i].TechNumber;
                dgvList.Rows[i].Cells[4].Value = listTCH[i].Condition();
                dgvList.Rows[i].Cells[5].Value = listTCH[i].IssueYear;
                dgvList.Rows[i].Cells[6].Value = listTCH[i].Discription;
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdBTN = (RadioButton)sender;
            if (!rdBTN.Checked) return;
            switch (rdBTN.Name)
            {
                case "rbMaterial":
                    cbSearch.Items.Clear();
                    cbSearch.Items.AddRange(materialArr);
                    TSMIPlus.Enabled = true;
                    FillGridViewMaterial(listM);
                    break;
                case "rbTech":
                    cbSearch.Items.Clear();
                    cbSearch.Items.AddRange(techArr);
                    TSMIPlus.Enabled = false;
                    FillGridViewTech(listTCH);
                    break;
                case "rbTools":
                    cbSearch.Items.Clear();
                    cbSearch.Items.AddRange(toolArr);
                    TSMIPlus.Enabled = false;
                    FillGridViewTool(listT);
                    break;


            }

        }

        private void TSExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization auto = new Autorization();
            do
            {
                auto.ShowDialog();
            } while (!auto.IsClose);
            listM = Materials.LoadMaterials();
            listT = Tools.LoadTools();
            listTCH = Tech.LoadTech();
            FillGridViewMaterial(listM);
            cbSearch.Items.Clear();
            cbSearch.Items.AddRange(materialArr);
            this.Show();
    }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count != 0)
            {
                DialogResult drD = MessageBox.Show("Вы уверены?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drD == DialogResult.Yes)
                {
                    if (rbMaterial.Checked)
                    {
                        Materials materials = ((Materials)dgvList.SelectedRows[0].Tag);
                        if (materials.Delete())
                            listM.Remove(materials);
                    }
                    if (rbTools.Checked)
                    {
                        Tools tools = ((Tools)dgvList.SelectedRows[0].Tag);
                        if (tools.Delete())
                            listT.Remove(tools);
                    }
                    if (rbTech.Checked)
                    {
                        Tech tech = ((Tech)dgvList.SelectedRows[0].Tag);
                        if (tech.Delete())
                            listTCH.Remove(tech);
                    }
                    dgvList.Rows.Remove(dgvList.SelectedRows[0]);
                }
            }
            else MessageBox.Show("Вы не выбрали строку для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btRed_Click(object sender, EventArgs e)
        {
            if (rbMaterial.Checked)
            {
                FAddMaterial fAddMaterial = new FAddMaterial();
                fAddMaterial.LoadData((Materials)dgvList.SelectedRows[0].Tag);
                listM.Remove((Materials)dgvList.SelectedRows[0].Tag);
                Materials material = new Materials();
                if (fAddMaterial.ShowDialog() == DialogResult.OK)
                {
                    if (material.Update())
                    {
                        material = fAddMaterial.GetMaterial();
                        listM.Add(material);
                    }
                    FillGridViewMaterial(listM);
                }
            }
            if (rbTools.Checked)
            {
                FAddTool fAddTool = new FAddTool();
                fAddTool.LoadData((Tools)dgvList.SelectedRows[0].Tag);

                Tools tool = new Tools();
                if (fAddTool.ShowDialog() == DialogResult.OK)
                {
                    if (tool.Update())
                    {
                        tool = fAddTool.GetTools();
                        listT.Remove((Tools)dgvList.SelectedRows[0].Tag);
                        listT.Add(tool);
                    }
                    FillGridViewTool(listT);
                }
            }
            if (rbTech.Checked)
            {
                FAddTech fAddTech = new FAddTech();
                fAddTech.LoadData((Tech)dgvList.SelectedRows[0].Tag);
                Tech tech = new Tech();
                if (fAddTech.ShowDialog() == DialogResult.OK)
                {
                    tech = fAddTech.GetTech();
                    listTCH.Remove((Tech)dgvList.SelectedRows[0].Tag);
                    listTCH.Add(tech);
                    FillGridViewTech(listTCH);
                }
            }
        }

        public bool TechOption(string text)
        {
            if (text.Trim().ToLower() == "исправна") return true;
            else return false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbMaterial.Checked)
            {
                if (cbSearch.SelectedIndex != -1 && tbSearch.Text.Trim().Length != 0)
                {
                    switch (cbSearch.SelectedIndex)
                    {
                        case 0:
                            query = "Select id, materialname, deliverydate, measurementunit, mcount, typeofmaterial, manufacturedate, contractor from tMaterials where materialname = '" + tbSearch.Text + "'";
                            listMSearch = Materials.LoadSearchedMaterials(query);
                            FillGridViewMaterial(listMSearch);
                            break;
                        case 1:
                            query = "Select id, materialname, deliverydate, measurementunit, mcount, typeofmaterial, manufacturedate, contractor from tMaterials where deliverydate = '" + tbSearch.Text + "'";
                            listMSearch = Materials.LoadSearchedMaterials(query);
                            FillGridViewMaterial(listMSearch);
                            break;
                        case 2:
                            query = "Select id, materialname, deliverydate, measurementunit, mcount, typeofmaterial, manufacturedate, contractor from tMaterials where measurementunit = '" + tbSearch.Text + "'";
                            listMSearch = Materials.LoadSearchedMaterials(query);
                            FillGridViewMaterial(listMSearch);
                            break;
                        case 3:
                            query = "Select id, materialname, deliverydate, measurementunit, mcount, typeofmaterial, manufacturedate, contractor from tMaterials where mcount = " + Convert.ToInt32(tbSearch.Text) + "";
                            listMSearch = Materials.LoadSearchedMaterials(query);
                            FillGridViewMaterial(listMSearch);
                            break;
                        case 4:
                            query = "Select id, materialname, deliverydate, measurementunit, mcount, typeofmaterial, manufacturedate, contractor from tMaterials where typeofmaterial = '" + tbSearch.Text + "'";
                            listMSearch = Materials.LoadSearchedMaterials(query);
                            FillGridViewMaterial(listMSearch);
                            break;
                        case 5:
                            query = "Select id, materialname, deliverydate, measurementunit, mcount, typeofmaterial, manufacturedate, contractor from tMaterials where manufacturedate = '" + tbSearch.Text + "'";
                            listMSearch = Materials.LoadSearchedMaterials(query);
                            FillGridViewMaterial(listMSearch);
                            break;
                        case 6:
                            query = "Select id, materialname, deliverydate, measurementunit, mcount, typeofmaterial, manufacturedate, contractor from tMaterials where contractor = '" + tbSearch.Text + "'";
                            listMSearch = Materials.LoadSearchedMaterials(query);
                            FillGridViewMaterial(listMSearch);
                            break;
                    }
                }
            }
            else if (rbTools.Checked)
            {
                if (cbSearch.SelectedIndex != -1 && tbSearch.Text.Trim().Length != 0)
                {
                    switch (cbSearch.SelectedIndex)
                    {
                        case 0:
                            query = "Select id, ToolType, ToolName, Model, InventoryNumber, TCount, Note from tTools where ToolType = '" + tbSearch.Text + "'";
                            listTSearch = Tools.LoadSearchedTools(query);
                            FillGridViewTool(listTSearch);
                            break;
                        case 1:
                            query = "Select id, ToolType, ToolName, Model, InventoryNumber, TCount, Note from tTools where ToolName = '" + tbSearch.Text + "'";
                            listTSearch = Tools.LoadSearchedTools(query);
                            FillGridViewTool(listTSearch);
                            break;
                        case 2:
                            query = "Select id, ToolType, ToolName, Model, InventoryNumber, TCount, Note from tTools where Model = '" + tbSearch.Text + "'";
                            listTSearch = Tools.LoadSearchedTools(query);
                            FillGridViewTool(listTSearch);
                            break;
                        case 3:
                            query = "Select id, ToolType, ToolName, Model, InventoryNumber, TCount, Note from tTools where InventoryNumber = '" + tbSearch.Text + "'";
                            listTSearch = Tools.LoadSearchedTools(query);
                            FillGridViewTool(listTSearch);
                            break;
                        case 4:
                            query = "Select id, ToolType, ToolName, Model, InventoryNumber, TCount, Note from tTools where TCount = " + Convert.ToInt32(tbSearch.Text) + "";
                            listTSearch = Tools.LoadSearchedTools(query);
                            FillGridViewTool(listTSearch);
                            break;
                        case 5:
                            query = "Select id, ToolType, ToolName, Model, InventoryNumber, TCount, Note from tTools where Note = '" + tbSearch.Text + "'";
                            listTSearch = Tools.LoadSearchedTools(query);
                            FillGridViewTool(listTSearch);
                            break;
                    }
                }

            }
            else if (rbTech.Checked)
            {
                if (cbSearch.SelectedIndex != -1 && tbSearch.Text.Trim().Length != 0)
                {
                    switch (cbSearch.SelectedIndex)
                    {
                        case 0:
                            query = "Select id, Model, Category, TechName, TechNumber, TechCondition, IssueYear, Note from tTech where  Model = '" + tbSearch.Text + "'";
                            listTCHSearch = Tech.LoadSearchedTech(query);
                            FillGridViewTech(listTCHSearch);
                            break;
                        case 1:
                            query = "Select id, Model, Category, TechName, TechNumber, TechCondition, IssueYear, Note from tTech where Category = '" + tbSearch.Text + "'";
                            listTCHSearch = Tech.LoadSearchedTech(query);
                            FillGridViewTech(listTCHSearch);
                            break;
                        case 2:
                            query = "Select id, Model, Category, TechName, TechNumber, TechCondition, IssueYear, Note from tTech where TechName = '" + tbSearch.Text + "'";
                            listTCHSearch = Tech.LoadSearchedTech(query);
                            FillGridViewTech(listTCHSearch);
                            break;
                        case 3:
                            query = "Select id, Model, Category, TechName, TechNumber, TechCondition, IssueYear, Note from tTech where TechNumber = '" + tbSearch.Text + "'";
                            listTCHSearch = Tech.LoadSearchedTech(query);
                            FillGridViewTech(listTCHSearch);
                            break;
                        case 4:
                            query = "Select id, Model, Category, TechName, TechNumber, TechCondition, IssueYear, Note from tTech where TechCondition = '" + TechOption(tbSearch.Text) + "'";
                            listTCHSearch = Tech.LoadSearchedTech(query);
                            FillGridViewTech(listTCHSearch);
                            break;
                        case 5:
                            query = "Select id, Model, Category, TechName, TechNumber, TechCondition, IssueYear, Note from tTech where IssueYear = " + Convert.ToInt32(tbSearch.Text) + "";
                            listTCHSearch = Tech.LoadSearchedTech(query);
                            FillGridViewTech(listTCHSearch);
                            break;
                        case 6:
                            query = "Select id, Model, Category, TechName, TechNumber, TechCondition, IssueYear, Note from tTech where Note = '" + tbSearch.Text + "'";
                            listTCHSearch = Tech.LoadSearchedTech(query);
                            FillGridViewTech(listTCHSearch);
                            break;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (rbMaterial.Checked)
            {
                FillGridViewMaterial(listM);
            }
            if (rbTools.Checked)
            {
                FillGridViewTool(listT);
            }
            if (rbTech.Checked)
            {
                FillGridViewTech(listTCH);
            }
        }

        private void TSProfile_Click(object sender, EventArgs e)
        {
            FProfile profile = new FProfile();
            profile.LoadData(Program.currentUser.Prof);
            if (profile.ShowDialog() == DialogResult.OK)
            {
                Program.currentUser.Prof = profile.GetProfile();
                Program.currentUser.Prof.Save();
            }
        }

        private void TSMIMinus_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count < 1) return;
            BaseItem item = ((BaseItem)dgvList.SelectedRows[0].Tag);
            FAddMinus min = new FAddMinus(item);
            if (min.ShowDialog() == DialogResult.OK)
            {
                switch (item.Type)
                {
                    case Defect.EnTypeDefect.Material:
                        listM = Materials.LoadMaterials();
                        FillGridViewMaterial(listM);
                        break;
                    case Defect.EnTypeDefect.Tool:
                        listT = Tools.LoadTools();
                        FillGridViewTool(listT);
                        break;
                    case Defect.EnTypeDefect.Tech:
                        listTCH = Tech.LoadTech();
                        FillGridViewTech(listTCH);
                        break;
                }
                
            }


        }

        private void TSMIPlus_Click(object sender, EventArgs e)
        {
            FAddPlus pl = new FAddPlus();
            pl.LoadData((Materials)dgvList.SelectedRows[0].Tag);
            if (pl.ShowDialog() == DialogResult.OK)
            {
                listM = Materials.LoadMaterials();
                FillGridViewMaterial(listM);
            }
        }

        private void RemToolbtn_Click(object sender, EventArgs e)
        {
            ViewDefect vD = new ViewDefect();
            if(vD.ShowDialog() == DialogResult.OK)
            {
                listTCH = Tech.LoadTech();
                FillGridViewTech(listTCH);
                listT = Tools.LoadTools();
                FillGridViewTool(listT);
            }
        }
    }
}
