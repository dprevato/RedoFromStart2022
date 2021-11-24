using System.Windows;
using Core.Enums;

namespace Core.Services
{
    public class IconService : IIconService
    {
        #region Implementation of IIconService

        public string IconName(Icons iconKey) => Application.Current.Resources[iconKey.ToString()].ToString()!;

        #endregion
    }
}
