using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class PlantLookup : LookupBase
    {
        #region Overrides of LookupBase

        public override void GetAll() {
            using var db = new RfsContext();
            Items = new ObservableCollection<LookupTable>((db.Plant.AsNoTracking().Select(x => new { x.Code, x.Name }) as IEnumerable<LookupTable>)!);
        }

        #endregion
    }
}