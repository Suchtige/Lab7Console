using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            
            DateTime Start = new DateTime(2018, 1, 20);
            DateTime End = new DateTime(2018, 2, 20);
            scroll scroll1 = new scroll(1, "пиво", 10);
            //product product1 = new product(1, "Балтика", scroll1, 0.5, 70, "Балтика продакшн");
            //product1.info();
            List<TemporaryScroll> listscroll = new List<TemporaryScroll>();
            listscroll.Add(new TemporaryScrollt(2, "Коньяк",40,  Start, End));
            foreach(TemporaryScroll ff in listscroll)
            {
                ff.info();
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
        
    }
}
