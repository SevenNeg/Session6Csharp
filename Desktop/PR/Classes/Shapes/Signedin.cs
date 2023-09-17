using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Signedin : Form
    {
        public Signedin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Admin> users = new List<Admin>();
            Admin person1 = new Admin(firstname: "Killian", lastname: "Jones", cellphone: "1234");
            Admin person2 = new Admin(firstname: "Emma", lastname: "Swan", cellphone: "5678");
            Admin person3 = new Admin(firstname: "KAte", lastname: "winslet", cellphone: "9101112");
            users.Add(person1);
            users.Add(person2);
            users.Add(person3);
            if (Firstnametxt.Text != person1.FirstName || lastnametxt.Text != person1.LastName || cellphonetxt.Text != person1.Cellphone)
            {
                MessageBox.Show("The user couldn't be found. To creat an account press sign up button");
            }
            else
            {
                MessageBox.Show("Welcome, Next features will be applied soon");

            }
        }
    }
}
