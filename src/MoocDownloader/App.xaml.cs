﻿using MoocDownloader.Controls;
using MoocDownloader.Domain.Accounts;
using MoocDownloader.Services;
using MoocDownloader.Services.Contracts;
using MoocDownloader.ViewModels.Accounts;
using MoocDownloader.ViewModels.Dialogs;
using MoocDownloader.ViewModels.Downloads;
using MoocDownloader.ViewModels.Preferences;
using MoocDownloader.Views;
using MoocDownloader.Views.Accounts;
using MoocDownloader.Views.Dialogs;
using MoocDownloader.Views.Downloads;
using MoocDownloader.Views.Preferences;
using MoocResolver.Contracts;
using MoocResolver.Resolvers;
using Prism.Ioc;
using System.IO;
using System.Windows;

namespace MoocDownloader;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    static App()
    {
        // Check if the user data folder exists.
        if (!Directory.Exists(Constants.UserDataPath))
        {
            Directory.CreateDirectory(Constants.UserDataPath);
        }
    }

    /// <inheritdoc />
    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterSingleton<ResourceDictionary>(() => Resources);
        containerRegistry.RegisterSingleton<AccountManager>();
        containerRegistry.RegisterSingleton<ILanguageService, LanguageService>();
        containerRegistry.RegisterSingleton<IResourceService, ResourceService>();

        containerRegistry.Register<IWebsiteResolver, BilibiliResolver>();
        containerRegistry.Register<IWebsiteResolver, Course163Resolver>();
        containerRegistry.Register<IWebsiteResolver, CoursesResolver>();
        containerRegistry.Register<IWebsiteResolver, Study163Resolver>();
        containerRegistry.Register<IWebsiteResolver, XuetangxResolver>();

        containerRegistry.RegisterDialogWindow<BorderlessWindow>();
        containerRegistry.RegisterDialog<CreationView, CreationViewModel>();
        containerRegistry.RegisterDialog<WebsiteView, WebsiteViewModel>();
        containerRegistry.RegisterDialog<AboutView, AboutViewModel>();
        containerRegistry.RegisterDialog<PreferenceView, PreferenceViewModel>();
        containerRegistry.RegisterDialog<AccountView, AccountViewModel>();
        containerRegistry.RegisterDialog<BrowserView, BrowserViewModel>();
        containerRegistry.RegisterDialog<MessageView, MessageViewModel>();
    }

    /// <inheritdoc />
    protected override Window CreateShell() => Container.Resolve<ShellView>();
}