﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace MoocDownloader.Models.Credentials;

public partial class Credential : ObservableObject
{
    [ObservableProperty]
    private string _name = string.Empty;

    [ObservableProperty]
    private string _url = string.Empty;

    [ObservableProperty]
    private CredentialStatus _status = CredentialStatus.None;

    [ObservableProperty]
    private CredentialType? _type;

    [ObservableProperty]
    private string _errorMessage = string.Empty;

    [ObservableProperty]
    private string _username = string.Empty;

    [ObservableProperty]
    private string _password = string.Empty;

    [ObservableProperty]
    private string _cookieData = string.Empty;

    [ObservableProperty]
    private ImageSource? _avatar;

    [ObservableProperty]
    private string _nickname = string.Empty;

    [ObservableProperty]
    private DateTime _creationTime = DateTime.Now;

    [ObservableProperty]
    private bool _supportPassword;

    [ObservableProperty]
    private bool _supportCookie;

    [ObservableProperty]
    private List<string> _domains = new();
}