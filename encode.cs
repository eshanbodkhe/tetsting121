using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks;ggg

namespace ConsoleApplication3
{
    class encode
    {

        public delegate void videoencodedeventhandler(object source, EventArgs args);

        public event videoencodedeventhandler videoencoded;

        public void encoded()
        {
            Console.WriteLine("in encoded");
            Thread.Sleep(3000);
            onvideoencoded();
        }

        public virtual void onvideoencoded()
        {
            if (videoencoded != null)
            {
                videoencoded(this, EventArgs.Empty);
            }
        
        }

    }
}
