using CommunityToolkit.WinUI.Notifications;

using Windows.UI.Notifications;

using WPFTemplateStudio.Contracts.Services;

namespace WPFTemplateStudio.Services;

public partial class ToastNotificationsService : IToastNotificationsService
{
    public ToastNotificationsService()
    {
    }

    public void ShowToastNotification(ToastNotification toastNotification)
    {
        ToastNotificationManagerCompat.CreateToastNotifier().Show(toastNotification);
    }
}
