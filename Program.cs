using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    class Program
    {
      

        static void Main(string[] args)
        {

            var encode = new encode();
       

            mailservice x = new mailservice();

            encode.videoencoded += x.onvideoencoded;
            encode.encoded();
            Console.Read();
        }       
    }



    class mailservice 
    {
        public void onvideoencoded(object sourse, EventArgs e)
        {

            Console.WriteLine("In mail service sending mail");
        }
           
    }
     
}
