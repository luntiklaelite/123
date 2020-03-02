using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tovari
{
    public class compType
    {
        public string typeName;
        public dbCompany.type tip;
        public compType(string typeName, object tip)
        {
            this.typeName = typeName;
            this.tip = (dbCompany.type)tip;
        }
        public override string ToString()
        {
            return typeName;
        }
    }
}
