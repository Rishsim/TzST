using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL
{
    public class Demo
    {

        public void S1()
        {
            ArrayList a = new ArrayList();

            a.Add(10);

            a.Add("rish");

            Console.WriteLine(a[0]);

            a.Add(10.5f);

            a.Add(223344d);

            a.Add('s');
            
            a.Add(true);

            foreach(var b in a)
            {
                Console.WriteLine(b);



            }
        
        
        
        
        }
       









    }
}
