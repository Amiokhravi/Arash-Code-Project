using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clube2.models
{
    public class Customer
    {
        private string _id;
        
        public Customer(string id, string name, string family, string phone)
        {
            this.id = id;
            this.name = name;
            this.family = family;
            this.phone = phone;
        }


        /// <summary>
        /// شناسه مشتری
        /// </summary>
        public string id
        {
            get
            {
                
                return _id;
            }
            set
            {
                if (value == null)
                {
                    _id = Guid.NewGuid().ToString();
                }
                else
                {
                    _id= value;
                }
            }
        }
        /// <summary>
        /// نام مشتری
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// نام خانوادگی مشتری
        /// </summary>
        public string family { get; set; }
        /// <summary>
        /// شماره تماس مشتری
        /// </summary>
        public string phone { get; set; }


    }
}
