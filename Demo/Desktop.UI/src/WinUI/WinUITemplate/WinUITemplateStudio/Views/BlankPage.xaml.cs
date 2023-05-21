using Microsoft.UI.Xaml.Controls;

using WinUITemplateStudio.ViewModels;

namespace WinUITemplateStudio.Views;

public sealed partial class BlankPage : Page
{
    public BlankViewModel ViewModel
    {
        get;
    }

    public BlankPage()
    {
        ViewModel = App.GetService<BlankViewModel>();
        InitializeComponent();
    }
}
