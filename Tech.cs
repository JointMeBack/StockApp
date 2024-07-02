using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static StockApp.Defect;

namespace StockApp
{
    [Serializable]
    public class Tech: BaseItem
    {
        private int id;
        private string model;
        private string category;
        private string techName;
        private string techNumber;
        private bool techCondition;
        private int issueYear;
        private string discription;


        public string Model { get => model; set => model = value; }
        public string Category { get => category; set => category = value; }
        public string TechName { get => techName; set => techName = value; }
        public string TechNumber { get => techNumber; set => techNumber = value; }
        public bool TechCondition { get => techCondition; set => techCondition = value; }
        public int IssueYear { get => issueYear; set => issueYear = value; }
        public string Discription { get => discription; set => discription = value; }
        public int Id { get => id; set => id = value; }


        public Tech()
        {
            Model = "-";
            Category = "-";
            TechName = "-";
            TechNumber = "-";
            TechCondition = false;
            Type = EnTypeDefect.Tech;
        }

        public Tech(string m, string c, string tN, string tNum, bool tchC, int IY, string disc)
        {
            Model = m;
            Category = c;
            TechName = tN;
            TechNumber = tNum;
            TechCondition = tchC;
            IssueYear = IY;
            Discription = disc;
            Type = EnTypeDefect.Tech;
        }

        public string Condition()
        {
            if (TechCondition == true) return "Исправно";
            else return "Неисправно";
        }
        public bool Save()
        {
            try
            {
                DBManager.DBNonQuery("INSERT INTO tTech(Model, Category, TechName, TechNumber, TechCondition, IssueYear, Note) " +
                "VALUES ('" + Model + "', '" + Category + "', '" + TechName + "', '" + TechNumber + "', '" + TechCondition + "', '" + IssueYear + "', '" + Discription + "')");
                DataTable dt = DBManager.DBSelect("Select max(Id) from tTech");
                if (dt.Rows.Count > 0)
                    DBManager.DBNonQuery("Insert into UserToTech(idUser, idTech) values (" + Program.currentUser.Id + ", " + dt.Rows[0][0] + ")");
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
            return DBManager.DBNonQuery("DELETE FROM tTech where id = " + Id);
        }

        public bool Update()
        {
            return DBManager.DBNonQuery("Update tTech set Model = '" + Model + "', Category = '" + Category + "', " +
                "TechName = '" + TechName + "', TechNumber = '" + TechNumber + "', TechCondition = '" + TechCondition + "', " +
                "IssueYear = " + IssueYear + ", Note = '" + Discription + "' where id = " + Id);
        }


        public static List<Tech> LoadSearchedTech(string query)
        {
            DataTable dt = DBManager.DBSelect(query);
            List<Tech> list = new List<Tech>();
            foreach (DataRow dr in dt.Rows)
            {
                Tech tech = new Tech()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    Model = dr["Model"].ToString(),
                    Category = dr["Category"].ToString(),
                    TechName = dr["TechName"].ToString(),
                    TechNumber = dr["TechNumber"].ToString(),
                    TechCondition = Convert.ToBoolean(dr["TechCondition"]),
                    IssueYear = Convert.ToInt32(dr["IssueYear"].ToString()),
                    Discription = dr["Note"].ToString()
                };
                list.Add(tech);
            }
            return list;
        }


        public static List<Tech> LoadTech()
        {
            DataTable dt = DBManager.DBSelect("Select id, Model, Category, TechName, TechNumber, TechCondition, IssueYear, Note from tTech join usertotech on ttech.id = usertotech.idtech where idUser = " + Program.currentUser.Id + " and techcondition = " + true + "");
            List<Tech> list = new List<Tech>();
            foreach (DataRow dr in dt.Rows)
            {
                Tech tech = new Tech()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    Model = dr["Model"].ToString(),
                    Category = dr["Category"].ToString(),
                    TechName = dr["TechName"].ToString(),
                    TechNumber = dr["TechNumber"].ToString(),
                    TechCondition = Convert.ToBoolean(dr["TechCondition"]),
                    IssueYear = Convert.ToInt32(dr["IssueYear"].ToString()),
                    Discription = dr["Note"].ToString()
                };
                list.Add(tech);
            }
            return list;
        }
        public static List<Tech> GetTech()
        {
            return new List<Tech>();
        }

    }
}
