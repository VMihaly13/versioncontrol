using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource1.LastName; 
            lblFirstName.Text = Resource1.FirstName; 
            btnAdd.Text = Resource1.Add;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }
        var u = new User()
        {
            LastName = txtLastName.Text,
            FirstName = txtFirstNa     private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sr = new StreamWriter(users, Encoding.Default))
            {
                users.Write(ID);
                users.Write(FullName);
                sr.WriteLine();

            }
        }
    }
}
