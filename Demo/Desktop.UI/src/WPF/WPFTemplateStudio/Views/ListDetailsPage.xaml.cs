using System.Windows.Controls;

using WPFTemplateStudio.ViewModels;

namespace WPFTemplateStudio.Views;

public partial class ListDetailsPage : Page
{
    public ListDetailsPage(ListDetailsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
