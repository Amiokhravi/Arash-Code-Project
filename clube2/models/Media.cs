using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clube2.models
{
    public class Media
    {
        public Media(string idMedia, string nameFilm, string type,int price)
        {
            if (idMedia != null)
            {
                this.id = idMedia;
            }
            this.name = nameFilm;
            this.type = type;
            this.price = price;
        }
        /// <summary>
        /// شناسه فیلم
        /// </summary>
        public string id
        {
            get
            {
                return id;
            }
            set
            {
                if(value==null)
                {
                    id = new Guid().ToString();
                }
                else
                {
                    id = value;
                }

            }
        }       /// <summary>
        /// نام فیلم
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// نوع فیلم
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// قیمت فیلم
        /// </summary>
        public int price { get; set; }
    }
}
