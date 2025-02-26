using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ProductDal productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            dgwprotect.DataSource = productDal.GetAll();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           

            try
            {
                productDal.Add(new product
                {
                    Name = tbxname.Text,
                    Surname = tbxsurname.Text,
                    PhoneNumber = Convert.ToInt32(tbxnumber.Text),

                });
                load();
                MessageBox.Show("Added");
            }
            catch (FormatException)
            {

                MessageBox.Show("hata oluştu");
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgwprotect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxnameupdate.Text = dgwprotect.CurrentRow.Cells[1].Value.ToString();
            tbxSurnameupdate.Text = dgwprotect.CurrentRow.Cells[2].Value.ToString();
            tbxPhoneNUmberupdate.Text = dgwprotect.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                productDal.update(new product
                {
                    Id = Convert.ToInt32(dgwprotect.CurrentRow.Cells[0].Value.ToString()),
                    Name = tbxnameupdate.Text,
                    Surname = tbxSurnameupdate.Text,
                    PhoneNumber = Convert.ToInt32(tbxPhoneNUmberupdate.Text)

                });
                load();
                MessageBox.Show("Updated");
            }
            catch (Exception)
            {

                MessageBox.Show("hata oluştu");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productDal.delete(new product
            {
                Id = Convert.ToInt32(dgwprotect.CurrentRow.Cells[0].Value.ToString()),

            });
            load();
            MessageBox.Show("Deleted");

        }
             public void searchName(string key)
            {
                using (PhoneContext context = new PhoneContext())
                {
                   dgwprotect.DataSource = context.Products.Where(C => C.Name.ToLower().Contains(key.ToLower())).ToList();
                }
            }
        public void searchSurname(string key)
        {
            using (PhoneContext context = new PhoneContext())
            {
                dgwprotect.DataSource = context.Products.Where(C => C.Surname.ToLower().Contains(key.ToLower())).ToList();
            }
        }
        public void searchPhonenumber(int key)
        {
            using (PhoneContext context = new PhoneContext())
            {
                dgwprotect.DataSource = context.Products.Where(C => C.PhoneNumber.ToString().Contains(key.ToString())).ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string key = tbxsearchName.Text;

            if (string.IsNullOrEmpty(key))
            {
                load();
            }
            else
            {
                searchName(key);
               
            }

        }

        private void lblsearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string key = tbxsearcsurname.Text;

            if (string.IsNullOrEmpty(key))
            {
                load();
            }
            else
            {
                searchSurname(key);

            }
        }

        private void tbxsearchphonenumber_TextChanged(object sender, EventArgs e)
        {
          var key=tbxsearchphonenumber.Text;

            if (string.IsNullOrEmpty(key))
            {
               load() ;

            }
            else
            {
               
                searchPhonenumber(Convert.ToInt32(key));

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbxadd_Enter(object sender, EventArgs e)
        {

        }
    }
    }

