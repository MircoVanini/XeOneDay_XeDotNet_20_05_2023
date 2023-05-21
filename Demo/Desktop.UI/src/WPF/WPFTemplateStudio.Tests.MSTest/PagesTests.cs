﻿using System.IO;
using System.Reflection;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WPFTemplateStudio.Contracts.Services;
using WPFTemplateStudio.Core.Contracts.Services;
using WPFTemplateStudio.Core.Services;
using WPFTemplateStudio.Models;
using WPFTemplateStudio.Services;
using WPFTemplateStudio.ViewModels;
using WPFTemplateStudio.Views;

namespace WPFTemplateStudio.Tests.MSTest;

[TestClass]
public class PagesTests
{
    private readonly IHost _host;

    public PagesTests()
    {
        var appLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location);
        _host = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(c => c.SetBasePath(appLocation))
            .ConfigureServices(ConfigureServices)
            .Build();
    }

    private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        // Core Services
        services.AddSingleton<IFileService, FileService>();

        // Services
        services.AddSingleton<IThemeSelectorService, ThemeSelectorService>();
        services.AddSingleton<ISystemService, SystemService>();
        services.AddSingleton<ISampleDataService, SampleDataService>();
        services.AddSingleton<IPersistAndRestoreService, PersistAndRestoreService>();
        services.AddSingleton<IApplicationInfoService, ApplicationInfoService>();
        services.AddSingleton<IPageService, PageService>();
        services.AddSingleton<INavigationService, NavigationService>();

        // ViewModels
        services.AddTransient<WebViewViewModel>();
        services.AddTransient<SettingsViewModel>();
        services.AddTransient<MainViewModel>();
        services.AddTransient<ListDetailsViewModel>();
        services.AddTransient<DataGridViewModel>();
        services.AddTransient<ContentGridViewModel>();
        services.AddTransient<BlankViewModel>();

        // Configuration
        services.Configure<AppConfig>(context.Configuration.GetSection(nameof(AppConfig)));
    }

    // TODO: Add tests for functionality you add to WebViewViewModel.
    [TestMethod]
    public void TestWebViewViewModelCreation()
    {
        var vm = _host.Services.GetService(typeof(WebViewViewModel));
        Assert.IsNotNull(vm);
    }

    [TestMethod]
    public void TestGetWebViewPageType()
    {
        if (_host.Services.GetService(typeof(IPageService)) is IPageService pageService)
        {
            var pageType = pageService.GetPageType(typeof(WebViewViewModel).FullName);
            Assert.AreEqual(typeof(WebViewPage), pageType);
        }
        else
        {
            Assert.Fail($"Can't resolve {nameof(IPageService)}");
        }
    }

    // TODO: Add tests for functionality you add to SettingsViewModel.
    [TestMethod]
    public void TestSettingsViewModelCreation()
    {
        var vm = _host.Services.GetService(typeof(SettingsViewModel));
        Assert.IsNotNull(vm);
    }

    [TestMethod]
    public void TestGetSettingsPageType()
    {
        if (_host.Services.GetService(typeof(IPageService)) is IPageService pageService)
        {
            var pageType = pageService.GetPageType(typeof(SettingsViewModel).FullName);
            Assert.AreEqual(typeof(SettingsPage), pageType);
        }
        else
        {
            Assert.Fail($"Can't resolve {nameof(IPageService)}");
        }
    }

    // TODO: Add tests for functionality you add to MainViewModel.
    [TestMethod]
    public void TestMainViewModelCreation()
    {
        var vm = _host.Services.GetService(typeof(MainViewModel));
        Assert.IsNotNull(vm);
    }

    [TestMethod]
    public void TestGetMainPageType()
    {
        if (_host.Services.GetService(typeof(IPageService)) is IPageService pageService)
        {
            var pageType = pageService.GetPageType(typeof(MainViewModel).FullName);
            Assert.AreEqual(typeof(MainPage), pageType);
        }
        else
        {
            Assert.Fail($"Can't resolve {nameof(IPageService)}");
        }
    }

    // TODO: Add tests for functionality you add to ListDetailsViewModel.
    [TestMethod]
    public void TestListDetailsViewModelCreation()
    {
        var vm = _host.Services.GetService(typeof(ListDetailsViewModel));
        Assert.IsNotNull(vm);
    }

    [TestMethod]
    public void TestGetListDetailsPageType()
    {
        if (_host.Services.GetService(typeof(IPageService)) is IPageService pageService)
        {
            var pageType = pageService.GetPageType(typeof(ListDetailsViewModel).FullName);
            Assert.AreEqual(typeof(ListDetailsPage), pageType);
        }
        else
        {
            Assert.Fail($"Can't resolve {nameof(IPageService)}");
        }
    }

    // TODO: Add tests for functionality you add to DataGridViewModel.
    [TestMethod]
    public void TestDataGridViewModelCreation()
    {
        var vm = _host.Services.GetService(typeof(DataGridViewModel));
        Assert.IsNotNull(vm);
    }

    [TestMethod]
    public void TestGetDataGridPageType()
    {
        if (_host.Services.GetService(typeof(IPageService)) is IPageService pageService)
        {
            var pageType = pageService.GetPageType(typeof(DataGridViewModel).FullName);
            Assert.AreEqual(typeof(DataGridPage), pageType);
        }
        else
        {
            Assert.Fail($"Can't resolve {nameof(IPageService)}");
        }
    }

    // TODO: Add tests for functionality you add to ContentGridViewModel.
    [TestMethod]
    public void TestContentGridViewModelCreation()
    {
        var vm = _host.Services.GetService(typeof(ContentGridViewModel));
        Assert.IsNotNull(vm);
    }

    [TestMethod]
    public void TestGetContentGridPageType()
    {
        if (_host.Services.GetService(typeof(IPageService)) is IPageService pageService)
        {
            var pageType = pageService.GetPageType(typeof(ContentGridViewModel).FullName);
            Assert.AreEqual(typeof(ContentGridPage), pageType);
        }
        else
        {
            Assert.Fail($"Can't resolve {nameof(IPageService)}");
        }
    }

    // TODO: Add tests for functionality you add to BlankViewModel.
    [TestMethod]
    public void TestBlankViewModelCreation()
    {
        var vm = _host.Services.GetService(typeof(BlankViewModel));
        Assert.IsNotNull(vm);
    }

    [TestMethod]
    public void TestGetBlankPageType()
    {
        if (_host.Services.GetService(typeof(IPageService)) is IPageService pageService)
        {
            var pageType = pageService.GetPageType(typeof(BlankViewModel).FullName);
            Assert.AreEqual(typeof(BlankPage), pageType);
        }
        else
        {
            Assert.Fail($"Can't resolve {nameof(IPageService)}");
        }
    }
}
