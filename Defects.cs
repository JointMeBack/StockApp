using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static StockApp.Defect;

namespace StockApp
{
    public class Defect
    {
        public EnTypeDefect Type {  get; set; }
        public int Id { get; set; }
        public string Name { get; set; }


        public Defect(int id, string name, EnTypeDefect type)
        {
            Id = id;
            Name = name;
            Type = type;
        }


        public static List<Defect> GetListDefects(EnTypeDefect type)
        {   

            DataTable dt = DBManager.DBSelect("select id, DefectName from " + GetNameTableByType(type));
            List <Defect> list = new List<Defect>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Defect(Convert.ToInt32(dr["id"].ToString()), dr["DefectName"].ToString(), type));
            }
            return list;
        }

        public static string GetNameTableByType(EnTypeDefect type)
        {
            string nameTable = "";
            switch (type)
            {
                case EnTypeDefect.Material:
                    nameTable = "tMaterialDefects";
                    break;
                case EnTypeDefect.Tool:
                    nameTable = "tToolDefects";
                    break;
                case EnTypeDefect.Tech:
                    nameTable = "tTechDefects";
                    break;
            }
            return nameTable;
        }
        public override string ToString()
        {
            return Name;
        }
        public enum EnTypeDefect
        {
            Material,
            Tool,
            Tech
        }

    }
    public class MaterialToDefect
    {
        public Materials Material { get; set; }
        public string Status { get; set; }
        public int DefectCount { get; set; }
        public string CurrentDate { get; set; }
        public Defect def { get; set; }

        public MaterialToDefect()
        {
            Material = null;
            Status = "";
            DefectCount = 0;
            CurrentDate = DateTime.Now.ToShortDateString().ToString();
        }

        public void Save()
        {
            try
            {
                DBManager.DBNonQuery("INSERT INTO materialtodefect (idMaterial, Status, mDefectCount, CurrentDate) " +
                "VALUES (" + Material.Id + ",'" + Status + "', " + DefectCount + ",'" + CurrentDate + "')");
                DBManager.DBNonQuery("Update tmaterials set MCount = " + (Material.UnitCount - DefectCount) + " where id = " + Material.Id);

            }
            catch (Exception)
            {

            }
        }

        public void SaveWithDef()
        {
            try
            {
                DBManager.DBNonQuery("INSERT INTO materialtodefect (idMaterial, idMDefect, Status, mDefectCount, CurrentDate) " +
                "VALUES (" + Material.Id + ", " + def.Id + ",'" + Status + "', " + DefectCount + ",'" + CurrentDate + "')");
                DBManager.DBNonQuery("Update tmaterials set MCount = " + (Material.UnitCount - DefectCount) + " where id = " + Material.Id);

            }
            catch (Exception)
            {

            }
        }
    }

    public class ToolsToDefect
    {
        public Tools Tool { get; set; }
        public string Status { get; set; }
        public string CurrentDate { get; set; }
        public Defect Tdef { get; set; }

        public void SaveT()
        {
            try
            {
                DBManager.DBNonQuery("INSERT INTO tooltodefect (idTool, Status, CurrentDate, idtDefect) " +
                "VALUES (" + Tool.Id + ",'" + Status + "', '" + DateTime.Now.ToShortDateString() + "'," + Tdef.Id+ ")");
                DBManager.DBNonQuery("Update ttools set ToolCondition = " + false + ", Note = '" + Tool.Discription + "'  where id = " + Tool.Id);
            }
            catch (Exception)
            {

            }
        }
    }

    public class TechToDefect
    {
        public Tech Tech { get; set; }
        public string Status { get; set; }
        public string CurrentDate { get; set; }
        public Defect TCHdef { get; set; }

        public void SaveTCH()
        {
            try
            {
                DBManager.DBNonQuery("INSERT INTO techtodefect (idTech, Status, CurrentDate, idtchDefect) " +
                "VALUES (" + Tech.Id + ",'" + Status + "', '" + DateTime.Now.ToShortDateString() + "'," + TCHdef.Id + ")");
                DBManager.DBNonQuery("Update ttech set TechCondition = " + false + ", Note = '" + Tech.Discription + "' where id = " + Tech.Id);
            }
            catch (Exception)
            {

            }
        }

    }

}

