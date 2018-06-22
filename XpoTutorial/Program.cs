using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace XpoTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hack lets setup the data layer
            //Hack vamos a configurar el data layer
            var ConnectionString = AccessConnectionProvider.GetConnectionString("MyDatabase.mdb");

            XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionString, AutoCreateOption.DatabaseAndSchema);

            //HACK our first XPO Object Instance
            //HACK nuestra primera instancia de un objeto XPO

            Customer Customer = new Customer(XpoDefault.Session);
            Customer.Name = "Jose Manuel Ojeda Melgar";
            Customer.Save();
            



        }
    }
}
