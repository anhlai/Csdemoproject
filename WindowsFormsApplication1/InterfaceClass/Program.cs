using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    class Program
    {
        public interface IBay
        {
            void Bay();
        }        
        
        public interface IChay
        {
            void Chay();
        }

        class MayBay : IBay, IChay
        {
            public void Bay()
            {
                Console.WriteLine("May Bay: Bay");
            }

            public void Chay()
            {
                Console.WriteLine("May Bay: Chay");
            }
        }

        static void Main(string[] args)
        {
            MayBay mayBay = new MayBay();
            mayBay.Bay();
            mayBay.Chay();
            Console.ReadLine();
        }
    }
}
