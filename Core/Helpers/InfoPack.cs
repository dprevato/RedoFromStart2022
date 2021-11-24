using System.Drawing;
using System.Windows;

namespace Core.Helpers
{
    public enum MessageType
    {
        Info,
        Warning,
        Error
    }

    public class InfoPack
    {
        public Icon MsgTypeIcon { get; set; }

        public string MessageText { get; set; }

        public InfoPack(string msgText, MessageType icon = MessageType.Info ) {
            MessageText = msgText;

            MsgTypeIcon = icon switch {
                MessageType.Warning => (Icon) Application.Current.Resources["Warning"],
                MessageType.Error => (Icon) Application.Current.Resources["Error"],
                _ => (Icon) Application.Current.Resources["Info"]
            };
        }
    }
}