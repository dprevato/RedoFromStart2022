using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Core.Enums;
using Services.Interfaces;

namespace Services
{
    public class IconService : IIconService
    {
        #region Implementation of IIconService

        public string IconName(Icons iconKey) => Application.Current.Resources[iconKey.ToString()].ToString()!;

        #endregion
    }
}
