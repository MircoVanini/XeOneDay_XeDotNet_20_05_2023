using System.Windows.Controls;

using WPFTemplateStudio.ViewModels;

namespace WPFTemplateStudio.Views;

public partial class SettingsPage : Page
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
