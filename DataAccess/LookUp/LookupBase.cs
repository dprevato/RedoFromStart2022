using System.Collections.ObjectModel;

namespace DataAccess;

public abstract class LookupBase
{
    public ObservableCollection<LookupTable> Items { get; set; } = new ObservableCollection<LookupTable>();

    public virtual void GetAll() {
        Items = new ObservableCollection<LookupTable> {
            new() { Id = "A", DisplayMember = "First Item" },
            new() { Id = "B", DisplayMember = "Second Item" },
            new() { Id = "C", DisplayMember = "Third Item" },
            new() { Id = "D", DisplayMember = "Fourth Item" },
            new() { Id = "E", DisplayMember = "Fifth item" }
        };
    }

    public void RemoveAll() {
        Items.Clear();
    }

    public class LookupTable
    {
        public string DisplayMember { get; set; }
        public string Id { get; set; }
    }
}