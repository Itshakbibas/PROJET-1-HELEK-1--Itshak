using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace DAL
{
    public static class Cloning
    {
        public static Clonable Clone(this Clonable original)
        {
            Clonable target = Activator.CreateInstance(original.GetType());
            //...
            return target;
        }
    }
}
