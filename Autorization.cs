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
    public partial class Autorization : Form
    {

        public Autorization()
        {
            InitializeComponent();
        }

        public bool IsClose { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {

            Program.currentUser = User.GetUser(tbLog.Text, tbPass.Text);
            if(Program.currentUser != null )
            {
                IsClose = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверно введены логин или пароль", "Ошибка");
            }
        }
    }
}
