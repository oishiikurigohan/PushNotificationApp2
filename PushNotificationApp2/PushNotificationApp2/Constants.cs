using System;

namespace PushNotificationApp2
{
    public static class Constants
    {
        public const string ListenConnectionString = "Endpoint=sb://pushnotification20180508.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=xxxxxxx your access key xxxxxxx=";
        public const string NotificationHubName = "PushNotificationTest";
        public const string MessageID = "NotificationFileName";
        public const string AndroidIntentExtraID = "AndroidIntentExtraID";
    }
}
