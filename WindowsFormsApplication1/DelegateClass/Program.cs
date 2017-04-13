using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass delegateClass = new DelegateClass();
            delegateClass.OnCreate += delegateClass_OnCreate;
            delegateClass.DoWork(10);
            Console.ReadLine();
        }

        static void delegateClass_OnCreate(int agrs)
        {
            Console.WriteLine("Tham so: {0}", agrs.ToString(CultureInfo.InvariantCulture));
        }
    }

    class DelegateClass
    {
        private int aValue = 5;
        public delegate void OnCreatingHandle(int agrs);
        public event OnCreatingHandle OnCreate;

        private void DoWork1406649018(int iValue)
        {
            OnCreate(iValue);
        }

        internal void DoWork(int iValue)
        {
            OnCreate(aValue);
        }
    }
}
