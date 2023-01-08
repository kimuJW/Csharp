using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBB
{
    public class GBB
    {    
        public static String Enter() {
            
            string a;

                         
                if (Program.fix_su < Program.input_su)
                {
                    a = "너무 커";

                }
                else if (Program.fix_su > Program.input_su)
                {
                    a = "너무 작어";
                  
                }
                else
                {
                    a = "정답";                                 
                }

            return a;
               
            }
            
    }
    }





