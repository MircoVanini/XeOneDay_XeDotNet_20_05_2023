using System.Windows.Controls;

using WPFTemplateStudio.ViewModels;

namespace WPFTemplateStudio.Views;

public partial class ContentGridDetailPage : Page
{
    public ContentGridDetailPage(ContentGridDetailViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
