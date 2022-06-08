using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clube2
{
   public class FilmClube
    {
        string id;
        string name;
        string family;
        int tamas;
        /// </>//////
        string idfilm;
        string namefilm;
        string type;
        int number;
        //<?/>/////////
        int pric;
        int timetavel;

        public filmclube(string i, string n, string f, int t)
        {
            id = i;
            name = n;
            family = f;
            tamas = t;
        }
        public filmclube(string i, string n, string t, int num, int p, int tim)
        {
            idfilm = i;
            namefilm = n;
            type = t;
            number = num;
            pric = p;
            timetavel = tim;
        }
        public void set_id(string i)
        {
            id = i;
        }
        public void set_name(string n)
        {
            name = n;
        }
        public void set_family(string f)
        {
            family = f;
        }
        public void set_tamas(int t)
        {
            tamas = t;
        }
        ///////////////////////
        /// ///////////////////
        /// //////////////////
        /// //////////////////
        public string get_id()
        {
            return id;
        }
        public string get_name()
        {
            return name;
        }
        public string get_family()

        {
            return family;
        }
        public int get_tamas()
        {
            return tamas;
        }
        ///////////////////////////move
        //////////////////////////////
        public void set_idfilm(string i)
        {
            idfilm = i;
        }
        public void set_namefilm(string n)
        {
            namefilm = n;
        }
        public void set_type(string t)
        {
            type = t;
        }
        public void set_number(int num )
        {
            number = num;
        }
        public void set_pric(int p)
        {
            pric = p;
        }
        public void set_timetavel(int tim)
        {
            timetavel = tim;
        }
        /////////////////////
       //////////////////////
        /// ////////////////
       ///////////////////////
       //////////////////////
        public string get_idfilm()
        {
            return idfilm;
        }
        public string get_namefilm()
        {
            return namefilm;
        }
        public string get_type()
        {
            return type;
        }
        public int get_number()
        {
            return number;
        }
        public int get_pric()
        {
            return pric;
        }
        public int get_timetavel()
        {
            return timetavel;
        }
    }

}
