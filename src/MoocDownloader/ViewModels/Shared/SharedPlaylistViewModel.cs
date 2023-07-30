﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DryIoc;
using MoocDownloader.Models.Playlists;
using MoocDownloader.Views.Downloads;
using Prism.Services.Dialogs;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MoocDownloader.ViewModels.Shared;

public abstract partial class SharedPlaylistViewModel : SharedViewModel
{
    [ObservableProperty]
    private ObservableCollection<PlaylistModel> _playlists = new();

    [ObservableProperty]
    private PlaylistModel? _selectedPlaylist;

    /// <inheritdoc />
    protected SharedPlaylistViewModel(IContainer container) : base(container)
    {
    }

    [RelayCommand]
    protected virtual async Task Create()
    {
        DialogService.ShowDialog(
            name: nameof(CreationView),
            callback: result => { Trace.TraceInformation(result.Result.ToString()); });
        await Task.CompletedTask;
    }

    [RelayCommand]
    private void Select(PlaylistModel playlist)
    {
        _selectedPlaylist = playlist;
    }

    [RelayCommand]
    private void Open(PlaylistModel playlist)
    {
    }

    [RelayCommand]
    private void CopyUrl(PlaylistModel playlist)
    {
    }
}