using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class Profile
    {
        private string firstName;
        private string middleName;
        private string secondName;
        private string workPhone;
        private string phone;
        private int districtNumber;
        private string adress;
        private int idUser;

        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string WorkPhone { get => workPhone; set => workPhone = value; }
        public string Phone { get => phone; set => phone = value; }
        public int DistrictNumber { get => districtNumber; set => districtNumber = value; }
        public string Adress { get => adress; set => adress = value; }
        public int IdUser { get => idUser; set => idUser = value; }

        public Profile()
        {
            FirstName = string.Empty;
            MiddleName = string.Empty;
            SecondName = string.Empty;
            WorkPhone = string.Empty;
            Phone = string.Empty;
            DistrictNumber = 0;
            Adress = string.Empty;
        }

        public Profile(string fN, string mN, string sN, string wP, string ph, int dist, string adr)
        {
            FirstName = fN;
            MiddleName = mN;
            SecondName = sN;
            WorkPhone = wP;
            Phone = ph;
            DistrictNumber = dist;
            Adress = adr;
        }

        public Profile(int _idUser)
        {
            IdUser = _idUser;
            LoadProfile(_idUser);
        }

        public void Save()
        {
            try
            {
                
                if(DBManager.DBScalar("Select idUser from tProfile where idUser = " + IdUser) != 0)
                {
                    Update();
                }
                else
                {
                    DBManager.DBNonQuery("INSERT INTO tprofile(FirstName, MiddleName, SecondName, WorkPhone, Phone, DistrictNumber, Adress, idUser) " +
                    "VALUES ('" + FirstName + "','" + MiddleName + "','" + SecondName + "', '" + WorkPhone + "','" + Phone + "', " + DistrictNumber
                    + ",'" + Adress + "', " + IdUser + ")");
                    
                }
                
            }
            catch (Exception)
            {
                
            }
        }

        public void Update()
        {
            DBManager.DBNonQuery("Update tProfile set FirstName = '" + FirstName + "', MiddleName = '" + MiddleName + "', " +
                "SecondName = '" + SecondName + "', WorkPhone = '" + WorkPhone + "', Phone = '" + Phone + "', " +
                "DistrictNumber = " + DistrictNumber + ", Adress = '" + Adress + "' where idUser = " + IdUser);
        }

        public void LoadProfile(int _idUser)
        {
            DataTable dt = DBManager.DBSelect("Select FirstName, MiddleName, SecondName, WorkPhone, Phone, DistrictNumber, Adress, idUser from tProfile where idUser = " + _idUser + "");
            if(dt.Rows.Count > 0)
            {
                FirstName = dt.Rows[0]["FirstName"].ToString();
                MiddleName = dt.Rows[0]["MiddleName"].ToString();
                SecondName = dt.Rows[0]["SecondName"].ToString();
                WorkPhone = dt.Rows[0]["WorkPhone"].ToString();
                Phone = dt.Rows[0]["Phone"].ToString();
                DistrictNumber = Convert.ToInt32(dt.Rows[0]["DistrictNumber"].ToString());
                Adress = dt.Rows[0]["Adress"].ToString();
                IdUser = Convert.ToInt32(dt.Rows[0]["idUser"].ToString());
            }

        }
    }
}
