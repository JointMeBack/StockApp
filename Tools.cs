using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StockApp.Defect;

namespace StockApp
{
    [Serializable]
    public class Tools: BaseItem
    {
        private int id;
        private string toolType;
        private string toolName;
        private string model;
        private int tCount;
        private bool toolCondition;
        private string inventoryNumber;
        private string discription;


        public string ToolType { get => toolType; set => toolType = value; }
        public string ToolName { get => toolName; set => toolName = value; }
        public string Model { get => model; set => model = value; }
        public string InventoryNumber { get => inventoryNumber; set => inventoryNumber = value; }
        public int TCount { get => tCount; set => tCount = value; }
        public string Discription { get => discription; set => discription = value; }
        public int Id { get => id; set => id = value; }
        public bool ToolCondition { get => toolCondition; set => toolCondition = value; }

        public Tools()
        {
            ToolType = "-";
            ToolName = "-";
            Model = "-";
            TCount = 0;
            InventoryNumber = "-";
            Discription = "-";
            Type = EnTypeDefect.Tool;
            ToolCondition = true;
        }

        public Tools(string tT, string toolN, string mod, string invN, int toolC, string disc)
        {
            ToolType = tT;
            ToolName = toolN;
            Model = mod;
            InventoryNumber = invN;
            TCount = toolC;
            Discription = disc;
            Type = EnTypeDefect.Tool;
            ToolCondition = true;
        }

        public bool Save()
        {
            try
            {
                DBManager.DBNonQuery("INSERT INTO ttools(ToolType, ToolName, Model, InventoryNumber, TCount, Note, ToolCondition) " +
                "VALUES ('" + ToolType + "','" + ToolName + "','" + Model + "', '" + InventoryNumber + "', '" + TCount + "','" + Discription + "', " + ToolCondition + ")");
                DataTable dt = DBManager.DBSelect("Select max(Id) from tTools");
                if (dt.Rows.Count > 0)
                    DBManager.DBNonQuery("Insert into UserToTool(idUser, idTool) values (" + Program.currentUser.Id + ", " + dt.Rows[0][0] + ")");
                Id = Convert.ToInt32(dt.Rows[0][0]);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            return DBManager.DBNonQuery("DELETE FROM ttools where id = " + Id);
        }

        public bool Update()
        {
            return DBManager.DBNonQuery("Update tTools set ToolType = '" + ToolType + "', ToolName = '" + ToolName + "', " +
                "Model = '" + Model + "', InventoryNumber = '" + InventoryNumber + "', TCount = " + TCount + ", " +
                " Note = '" + Discription + "' where id = " + Id);
        }

        public static List<Tools> LoadSearchedTools(string query)
        {
            DataTable dt = DBManager.DBSelect(query);
            List<Tools> list = new List<Tools>();
            foreach (DataRow dr in dt.Rows)
            {
                Tools tools = new Tools()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    ToolType = dr["ToolType"].ToString(),
                    ToolName = dr["ToolName"].ToString(),
                    Model = dr["Model"].ToString(),
                    InventoryNumber = dr["InventoryNumber"].ToString(),
                    TCount = Convert.ToInt32(dr["TCount"].ToString()),
                    Discription = dr["Note"].ToString()
                };
                list.Add(tools);
            }
            return list;
        }

        public static List<Tools> LoadTools()
        {
            DataTable dt = DBManager.DBSelect("Select id, ToolType, ToolName, Model, InventoryNumber, TCount, Note from tTools join UserToTool on ttools.id = UserToTool.idTool where idUser = " + Program.currentUser.Id + " and toolcondition = " + true + "");
            List<Tools> list = new List<Tools>();
            foreach (DataRow dr in dt.Rows)
            {
                Tools tools = new Tools()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    ToolType = dr["ToolType"].ToString(),
                    ToolName = dr["ToolName"].ToString(),
                    Model = dr["Model"].ToString(),
                    InventoryNumber = dr["InventoryNumber"].ToString(),
                    TCount = Convert.ToInt32(dr["TCount"].ToString()),
                    Discription = dr["Note"].ToString()
                };
                list.Add(tools);
            }
            return list;
        }
        public static List<Tools> GetTools()
        {
            return new List<Tools>();
        }
    }
}
