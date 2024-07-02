using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StockApp.Defect;

namespace StockApp
{
    public class BaseItem
    {
        private string status;
        private int counts;
        private string curdate;
        public EnTypeDefect Type { get; set; }
        public string Status { get => status; set => status = value; }
        public int Counts { get => counts; set => counts = value; }
        public string Curdate { get => curdate; set => curdate = value; }
    }
    [Serializable]
    public class Materials: BaseItem
    {
        List<MaterialToDefect> listDefects = new List<MaterialToDefect>();

        private int id;
        private string materialName;
        private DateTime deliveryDate;
        private string mesurementUnit;
        private int unitCount;
        private string typeofMaterial;
        private DateTime manufactureDate;
        private string contractor;
        private string note;



        public string MaterialName { get => materialName; set => materialName = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public string MesurementUnit { get => mesurementUnit; set => mesurementUnit = value; }
        public int UnitCount { get => unitCount; set => unitCount = value; }
        public string TypeofMaterial { get => typeofMaterial; set => typeofMaterial = value; }
        public DateTime ManufactureDate { get => manufactureDate; set => manufactureDate = value; }
        public string Contractor { get => contractor; set => contractor = value; }
        public int Id { get => id; set => id = value; }
        public string Note { get => note; set => note = value; }


        public Materials()
        {
            MaterialName = "None";
            MesurementUnit = "None";
            UnitCount = 0;
            TypeofMaterial = "None";
            Contractor = "Unknow";
            Type = EnTypeDefect.Material;
        }

        public Materials(string mN, DateTime dD, string mU, int uC, string tM, DateTime mD, string contr)
        {
            MaterialName = mN;
            DeliveryDate = dD.Date;
            MesurementUnit = mU;
            UnitCount = uC;
            TypeofMaterial = tM;
            ManufactureDate = mD.Date;
            Contractor = contr;
            Type = EnTypeDefect.Material;
        }
        public void LoadData()
        {

        }
        public bool Save()
        {
            try
            {
                DBManager.DBNonQuery("INSERT INTO tmaterials(materialname, deliverydate, measurementunit, mcount, typeofmaterial, manufacturedate, contractor) " +
                "VALUES ('" + MaterialName + "','" + DeliveryDate.ToShortDateString() + "','" + MesurementUnit + "', " + UnitCount + ",'" + TypeofMaterial + "','" + ManufactureDate.ToShortDateString()
                + "','" + Contractor + "')");
                DataTable dt = DBManager.DBSelect("Select max(Id) from tMaterials");
                if (dt.Rows.Count > 0)
                    DBManager.DBNonQuery("Insert into UserToMaterial(idUser, idMaterial) values (" + Program.currentUser.Id + ", " + dt.Rows[0][0] + ")");
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
            return DBManager.DBNonQuery("DELETE FROM tmaterials where id = " + Id);
        }

        public bool Update()
        {
            return DBManager.DBNonQuery("Update tmaterials set materialname = '" + MaterialName + "', deliverydate = '" + DeliveryDate.ToString() + "', " +
                "measurementunit = '" + MesurementUnit + "', mcount = " + UnitCount + ", typeofmaterial = '" + TypeofMaterial + "', " +
                "manufacturedate = '" + ManufactureDate.ToString() + "', contractor = '" + Contractor + "' where id = " + Id);
        }

        public static List<Materials> LoadSearchedMaterials(string query)
        {
            DataTable dt = DBManager.DBSelect(query);
            List<Materials> list = new List<Materials>();
            foreach (DataRow dr in dt.Rows)
            {
                Materials materials = new Materials()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    MaterialName = dr["materialname"].ToString(),
                    DeliveryDate = DateTime.Parse(dr["deliverydate"].ToString()),
                    MesurementUnit = dr["measurementunit"].ToString(),
                    UnitCount = Convert.ToInt32(dr["mcount"].ToString()),
                    TypeofMaterial = dr["typeofmaterial"].ToString(),
                    ManufactureDate = DateTime.Parse(dr["manufacturedate"].ToString()),
                    Contractor = dr["contractor"].ToString()
                };
                list.Add(materials);
            }
            return list;
        }


        public static List<Materials> LoadMaterials()
        {
            DataTable dt = DBManager.DBSelect("Select id, materialname, deliverydate, measurementunit, mcount, typeofmaterial, manufacturedate, contractor from tMaterials join UserToMaterial on tMaterials.id = UserToMaterial.idMaterial where idUser = " + Program.currentUser.Id + "");
            List<Materials> list = new List<Materials>();
            foreach (DataRow dr in dt.Rows)
            {
                Materials materials = new Materials()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    MaterialName = dr["materialname"].ToString(),
                    DeliveryDate = DateTime.Parse(dr["deliverydate"].ToString()),
                    MesurementUnit = dr["measurementunit"].ToString(),
                    UnitCount = Convert.ToInt32(dr["mcount"].ToString()),
                    TypeofMaterial = dr["typeofmaterial"].ToString(),
                    ManufactureDate = DateTime.Parse(dr["manufacturedate"].ToString()),
                    Contractor = dr["contractor"].ToString()
                };
                list.Add(materials);
            }
            return list;
        }
        public static List<Materials> GetMaterials()
        {
            return new List<Materials>();
        }
    }
}
