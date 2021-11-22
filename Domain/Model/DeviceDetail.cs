using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class DeviceDetail
    {
        public int DeviceId { get; set; }
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemUoM { get; set; }
        public string ItemValue { get; set; }
        [Timestamp] public byte[] TimeStamp { get; set; }
        //
        public Device Device { get; set; }
    }
}
