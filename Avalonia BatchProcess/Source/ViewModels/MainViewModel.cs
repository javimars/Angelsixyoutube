using Avalonia;
using Avalonia.Svg.Skia;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BatchProcess3.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _sideMenuExpanded = true;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HomePageIsActive))]
    [NotifyPropertyChangedFor(nameof(ProcessPageIsActive))]
    [NotifyPropertyChangedFor(nameof(ActionsPageIsActive))]
    [NotifyPropertyChangedFor(nameof(MacrosPageIsActive))]
    [NotifyPropertyChangedFor(nameof(ReporterPageIsActive))]
    [NotifyPropertyChangedFor(nameof(HistoryPageIsActive))]
    [NotifyPropertyChangedFor(nameof(SettingsPageIsActive))]
    private ViewModelBase _currentPage;

    public bool HomePageIsActive => CurrentPage == _homePage;
    public bool ProcessPageIsActive => CurrentPage == _processPage;
    public bool ActionsPageIsActive => CurrentPage == _actionsPage;
    public bool MacrosPageIsActive => CurrentPage == _macrosPage;
    public bool ReporterPageIsActive => CurrentPage == _reporterPage;
    public bool HistoryPageIsActive => CurrentPage == _historyPage;
    public bool SettingsPageIsActive => CurrentPage == _settingsPage;
    
    private readonly HomePageViewModel _homePage = new ();
    private readonly ProcessPageViewModel _processPage = new ();
    private readonly ActionsPageViewModel _actionsPage = new ();
    private readonly MacrosPageViewModel _macrosPage = new ();
    private readonly ReporterPageViewModel _reporterPage = new ();
    private readonly HistoryPageViewModel _historyPage = new ();
    private readonly SettingsPageViewModel _settingsPage = new ();

    public MainViewModel()
    {
        CurrentPage = _homePage;
    }
    
    [RelayCommand]
    private void SideMenuResize()
    {
        SideMenuExpanded = !SideMenuExpanded;
    }
    
    [RelayCommand]
    private void GoToHome() => CurrentPage = _homePage;
        
    [RelayCommand]
    private void GoToProcess() => CurrentPage = _processPage;
    [RelayCommand]
    private void GoToActions() => CurrentPage = _actionsPage;
    [RelayCommand]
    private void GoToMacros() => CurrentPage = _macrosPage;
    [RelayCommand]
    private void GoToReporter() => CurrentPage = _reporterPage;
    [RelayCommand]
    private void GoToHistory() => CurrentPage = _historyPage;
    [RelayCommand]
    private void GoToSettings() => CurrentPage = _settingsPage;
  }