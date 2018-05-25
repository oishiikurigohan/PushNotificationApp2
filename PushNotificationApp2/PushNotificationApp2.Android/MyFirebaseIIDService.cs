using Android.App;
using Firebase.Iid;
using WindowsAzure.Messaging;

namespace PushNotificationApp2.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    public class MyFirebaseIIDService : FirebaseInstanceIdService
    {
        public override void OnTokenRefresh()
        {
            // Azure Notification Hubに接続し、FirebaseのTokenを登録する
            NotificationHub hub = new NotificationHub(Constants.NotificationHubName, Constants.ListenConnectionString, this);
            hub.Register(FirebaseInstanceId.Instance.Token, null);
        }
    }
}