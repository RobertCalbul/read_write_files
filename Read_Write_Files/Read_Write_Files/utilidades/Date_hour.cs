using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Write_Files.utilidades
{
    class Date_hour
    {
        public String get_date()
        {

            return DateTime.Now.ToString("MM/dd/yyyy");
        }


        public String get_hour()
        {

            return DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
