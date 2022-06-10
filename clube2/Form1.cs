using clube2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clube2
{
    public partial class Form1 : Form
    {
        private List<Customer> _customers;
        private Customer _customer;
        private List<Media> _medias;
        private Media _media;
        private List<Rent> _rents;
        private Rent _rent;
        private int selectedIndexCustomer = -1;
        private List<Customer> searchDataCustomer;

        public Form1()
        {
            InitializeComponent();

            _customers = new List<Customer>();
            _medias = new List<Media>();
            _rents = new List<Rent>();
        }



        private void Btn_add_Click(object sender, EventArgs e)
        {
            //try
            //{
            string name = txt_name.Text.Trim().ToString();
            string family = txt_family.Text.Trim().ToString();
            string phone = txt_phone.Text.Trim().ToString();

            if (name.Length > 0 && family.Length > 0)
            {
                foreach (Customer customer in _customers)
                {
                    if (customer.name == name && customer.family == family)
                    {
                        MessageBox.Show($"مشتری با نام  {name}  {family} \n در بانک موجود میباشد و امکان درج مجدد نمی باشد",
                            "اخطار",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign
                            );
                        return;
                    }
                }

                _customers.Add(
                new Customer(null, name, family, phone)
                );

                MessageBox.Show("ذخیره با موفقیت انجام شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                initGridCustomer(_customers);
            }
            else
            {
                MessageBox.Show("نام و نام خانوادگی اجباری می باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        private void Btnfilm_Click(object sender, EventArgs e)
        {
            //try
            //{
            string idMedia = txt_id.Text.Trim().ToString();
            string nameFilm = txt_Name_movie.Text.Trim().ToString();
            string type = txt_type.Text.Trim().ToString();
            int price = Convert.ToInt32(txt_price.Text.Trim());
            if (nameFilm.Length > 0 && idMedia.Length > 0)
            {


                foreach (Media media in _medias)
                {

                    if (media.id == idMedia && media.name == nameFilm)

                    {
                        MessageBox.Show($"ثبت نام فیلم در بانک موجود می باشد امکان {nameFilm} {idMedia}\nدرج مجدد نمی باشد ",
                          "اخطار",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign);
                        return;
                    }
                }

                _medias.Add(new Media(null, nameFilm, type, price));
                MessageBox.Show("ذخیر با موفقیت انجام شود", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            else
            {
                MessageBox.Show("نام فیلم و کدشناسایی اجباری می باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

        }

        private void Btnshow_Click(object sender, EventArgs e)
        {


        }

        private void Btn_updat2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            string name = (txt_name3.Text.Trim().ToString());
            string family = (txt_family3.Text.Trim().ToString());
            string name_movei = (txt_move3.Text.Trim().ToString());
            double pric_cray = Convert.ToUInt64(txt_cray.Text.Trim().ToString());
            string time_cray = (txt_Time_cray.Text.Trim().ToString());
            string code_mely = (txt_codemely.Text.Trim().ToString());

        }
















        private void clear_customer()
        {
            txt_name.Text = null;
            txt_family.Text = null;
            txt_phone.Text = null;
            _customer = null;
        }
        private void initGridCustomer(List<Customer> data)
        {
            grdCustomers.Rows.Clear();
            if (data.Count > 0)
            {
                grdCustomers.RowCount = data.Count;
                for (int i = 0; i < data.Count; i++)
                {
                    grdCustomers.Rows[i].Cells["id"].Value = data[i].id;
                    grdCustomers.Rows[i].Cells["name"].Value = data[i].name;
                    grdCustomers.Rows[i].Cells["family"].Value = data[i].family;
                    grdCustomers.Rows[i].Cells["phone"].Value = data[i].phone;
                }
                grdCustomers.ScrollBars = ScrollBars.Both;
                if (selectedIndexCustomer >= 0)
                {
                    grdCustomers.Rows[0].Selected = false;
                    grdCustomers.Rows[selectedIndexCustomer].Selected = true;
                    selectedIndexCustomer = -1;
                }
                else
                {
                    clear_customer();
                }

            }

        }
        private void add_customer()
        {
            _customer = null;
            string name = txt_name.Text.Trim().ToString();
            string family = txt_family.Text.Trim().ToString();
            string phone = txt_phone.Text.Trim().ToString();
            if (name.Length > 0 && family.Length > 0)
            {
                foreach (Customer customer in _customers)
                {
                    if (customer.name == name && customer.family == family)
                    {
                        MessageBox.Show($"مشتری با نام  {name}  {family} \n در بانک موجود میباشد و امکان درج مجدد نمی باشد",
                            "اخطار",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign
                            );
                        return;
                    }
                }

                _customers.Add(
                new Customer(null, name, family, phone)
                );
                txt_search_customers.Text = null;
               // MessageBox.Show("ذخیره با موفقیت انجام شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                initGridCustomer(_customers);
            }
            else
            {
                MessageBox.Show("نام و نام خانوادگی اجباری می باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

        }
        private void edit_customer()
        {
            string name = txt_name.Text.Trim().ToString();
            string family = txt_family.Text.Trim().ToString();
            string phone = txt_phone.Text.Trim().ToString();

            if (name.Length > 0 && family.Length > 0)
            {
                foreach (Customer customer in _customers)
                {
                    if (customer.name == name && customer.family == family)
                    {
                        MessageBox.Show($"مشتری با نام  {name}  {family} \n در بانک موجود میباشد و امکان درج مجدد نمی باشد",
                            "اخطار",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign
                            );
                        return;
                    }
                }
                _customer = new Customer(_customer.id, name, family, phone);

                int index = _customers.FindIndex(i => i.id == _customer.id);
                _customers[index] = _customer;
                txt_search_customers.Text = null;
                // MessageBox.Show("ذخیره با موفقیت انجام شد", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                initGridCustomer( _customers);
            }
            else
            {
                MessageBox.Show("نام و نام خانوادگی اجباری می باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

        }
        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                add_customer();
            }
            else
            {
                edit_customer();
            }
        }
        private void btn_claer_customer_Click(object sender, EventArgs e)
        {
            clear_customer();
        }
        private void grdCustomers_MouseClick(object sender, MouseEventArgs e)
        {
            if (grdCustomers.CurrentRow != null)
            {
                _customer = new Customer(
                    grdCustomers.CurrentRow.Cells["id"].Value.ToString(),
                    grdCustomers.CurrentRow.Cells["name"].Value.ToString(),
                    grdCustomers.CurrentRow.Cells["family"].Value.ToString(),
                    grdCustomers.CurrentRow.Cells["phone"].Value.ToString()
                    );
                txt_name.Text = _customer.name;
                txt_family.Text = _customer.family;
                txt_phone.Text = _customer.phone;
                selectedIndexCustomer = grdCustomers.SelectedRows[0].Index;
            }
        }
        private void btn_delete_customer_Click(object sender, EventArgs e)
        {
            if (grdCustomers.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("آیا می خواهید مشتری حذف شود ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (result == DialogResult.Yes)
                {
                    
                    var itemToRemove = _customers.Single(customer => customer.id == grdCustomers.CurrentRow.Cells["id"].Value.ToString());
                    _customers.Remove(itemToRemove);
                    selectedIndexCustomer = -1;
                    initGridCustomer(searchDataCustomer ?? _customers); 
                }
            }

        }
        private void txt_search_customers_TextChanged(object sender, EventArgs e)
        {
            searchDataCustomer = _customers;
            var search = txt_search_customers.Text.Trim();
            if (search != "")
            {
                searchDataCustomer = searchDataCustomer.FindAll(customer => customer.name.Contains(search) || customer.family.Contains(search) || customer.phone.Contains(search));
            }
            initGridCustomer(searchDataCustomer);
            
        }
    }
}
