using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums
{
    public enum MessageType
    {
        [ParamValue("news")] News,
        [ParamValue("notifications")] Notifications
    }
}