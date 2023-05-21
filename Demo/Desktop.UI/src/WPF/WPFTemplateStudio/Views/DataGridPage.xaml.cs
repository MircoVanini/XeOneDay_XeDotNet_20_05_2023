using System.Windows.Controls;

using WPFTemplateStudio.ViewModels;

namespace WPFTemplateStudio.Views;

public partial class DataGridPage : Page
{
    public DataGridPage(DataGridViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
