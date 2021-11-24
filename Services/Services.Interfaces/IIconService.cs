using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;

namespace Services.Interfaces
{
    public interface IIconService
    {
        string IconName(Icons iconKey);
    }
}
