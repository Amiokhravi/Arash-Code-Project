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
        private List<Media> _medias;
        private List<Rent> _rents;
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

                MessageBox.Show("ذخیره با موفقیت انجام شد","ذخیره",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
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

                    if (media.id==idMedia && media.name==nameFilm)

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
            string code_mely=(txt_codemely.Text.Trim().ToString());

        }
    }
}
