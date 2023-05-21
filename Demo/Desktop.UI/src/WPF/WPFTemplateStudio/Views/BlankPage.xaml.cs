using System.Windows.Controls;

using WPFTemplateStudio.ViewModels;

namespace WPFTemplateStudio.Views;

public partial class BlankPage : Page
{
    public BlankPage(BlankViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
