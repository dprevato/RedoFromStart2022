using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MenuViewLookups
    {
        public PlantLookup Plants { get; set; } = new PlantLookup();
        public DevKindLookup Kinds { get; set; } = new DevKindLookup();
        public SubKindLookup SubKinds { get; set; } = new SubKindLookup();
    }
}
