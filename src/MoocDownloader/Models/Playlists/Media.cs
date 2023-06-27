﻿using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MoocDownloader.Models.Playlists;

public partial class Media : ObservableObject
{
    [ObservableProperty]
    private int _index;

    [ObservableProperty]
    private string? _fileName;

    [ObservableProperty]
    private string? _fileUrl;

    [ObservableProperty]
    private long? _fileSize;

    [ObservableProperty]
    private ImageSource? _image;

    [ObservableProperty]
    private MediaStatus _status = MediaStatus.Paused;
}