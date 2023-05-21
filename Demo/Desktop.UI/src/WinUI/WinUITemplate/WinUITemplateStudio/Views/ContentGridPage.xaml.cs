using Microsoft.UI.Xaml.Controls;

using WinUITemplateStudio.ViewModels;

namespace WinUITemplateStudio.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
