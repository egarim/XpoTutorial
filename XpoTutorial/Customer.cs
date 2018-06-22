using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpoTutorial
{
    public class Customer: XPObject
    {
        public Customer()
        {

        }

        public Customer(Session session) : base(session)
        {

        }

        public Customer(Session session, XPClassInfo classInfo) : base(session, classInfo)
        {

        }

        string name;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }




    }
}
