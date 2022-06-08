using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clube2.models
{
   public class Rent
    {
        public Rent(string name_family,string media_name,string cray,string date_time,string code_mely)
        {
            
            
        }
        /// <summary>
        /// کد ملی مشتری
        /// </summary>
        /// 

        public string code_mely { get; set; }

        /// <summary>
        /// نام فیلم
        /// </summary>
        /// 
        public string media_name { get; set; }

        /// <summary>
        /// نام خانوادگی مشتری
        /// </summary>
        public string name_family { get; set; }
        /// <summary>
        /// مبلغ کرایه
        /// </summary>
        public long cray { get; set; }

        /// <summary>
        /// تاریخ و زمان کرایه
        /// </summary>
        public string date_time_travel { get; set; }
    }
}
