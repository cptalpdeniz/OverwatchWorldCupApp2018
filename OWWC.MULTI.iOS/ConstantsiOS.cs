using System;
namespace OWWC.MULTI.iOS
{
    public class ConstantsiOS
    {
        // Azure app-specific connection string and hub path
        public const string ListenConnectionString = "Endpoint=sb://owwcnotification.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey= ";
        public const string NotificationHubName = "OWWCNotificationHub";
    }
}
