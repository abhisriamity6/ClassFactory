using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFactory
{
    class classfactory
    {
        int length, height;
        public classfactory createclass(int a , int b)
        {
            classfactory classfactoryobj = new classfactory();
            classfactoryobj.length = a;
            classfactoryobj.height = b;
            return classfactoryobj;
        }
        public void show()
        {
            Console.WriteLine("length = {0} - height = {1} ", length, height);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            classfactory CFobj = new classfactory();
            Console.Write("Specify the Number of Object to be created : ");
            int size = int.Parse(Console.ReadLine());
            classfactory[] CFOBJArray = new classfactory[size];
            for(i = 0, j = size-1 ;i < size;i++,j--)
            {
                CFOBJArray[i] = CFobj.createclass(i,j);
            }

            for (i = 0; i < size; i++)
            {
                Console.Write("{0} Object  --> ",i);
                CFOBJArray[i].show();
            }
            Console.ReadLine();


        }
    }
}
