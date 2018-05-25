using Xamarin.Forms;
using Reactive.Bindings;

namespace PushNotificationApp2
{
    public class ReceiveMessage
    {
        public ReactiveProperty<string> FileName { get; } = new ReactiveProperty<string>();

        public ReceiveMessage()
        {
            MessagingCenter.Subscribe<Application, string>(this, Constants.MessageID, (sender, arg) => {
                FileName.Value = arg;
            });
        }
    }
}