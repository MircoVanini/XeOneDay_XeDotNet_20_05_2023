using Microsoft.UI.Xaml.Controls;

using WinUITemplateStudio.ViewModels;

namespace WinUITemplateStudio.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private void OnShowTeachingTip(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        AutoSaveTip.IsOpen = true;


        var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        File.WriteAllText(Path.Combine(path, "MyDocument.txt"), "This is my document");
    }

}
