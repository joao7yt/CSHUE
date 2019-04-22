﻿using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using CSHUE.Cultures;
using CSHUE.ViewModels;
using CSHUE.Helpers;
using System.Windows.Media;

namespace CSHUE.Views
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings
    {
        public SettingsViewModel ViewModel = new SettingsViewModel();

        public Settings()
        {
            InitializeComponent();
            DataContext = ViewModel;

            ViewModel.MainWindowViewModel = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault()?.ViewModel;

            ComboBoxLanguage.SelectionChanged += ComboBoxLanguage_SelectionChanged;

            Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;
        }

        private void Default_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "MainMenu")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.MainMenu);
            }
            else if (e.PropertyName == "PlayerGetsKill")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.PlayerGetsKill);
            }
            else if (e.PropertyName == "PlayerGetsKilled")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.PlayerGetsKilled);
            }
            else if (e.PropertyName == "PlayerGetsFlashed")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.PlayerGetsFlashed);
            }
            else if (e.PropertyName == "TerroristsWin")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.TerroristsWin);
            }
            else if (e.PropertyName == "CounterTerroristsWin")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.CounterTerroristsWin);
            }
            else if (e.PropertyName == "RoundStarts")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.RoundStarts);
            }
            else if (e.PropertyName == "FreezeTime")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.FreezeTime);
            }
            else if (e.PropertyName == "Warmup")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.Warmup);
            }
            else if (e.PropertyName == "BombExplodes")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.BombExplodes);
            }
            else if (e.PropertyName == "BombPlanted")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.BombPlanted);
            }
            else if (e.PropertyName == "BombBlink")
            {
                UpdateGradient(e.PropertyName, Properties.Settings.Default.BombBlink);
            }
        }

        public void UpdateGradient(string propertyName, EventProperty Event)
        {
            if (propertyName == "MainMenu")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsMainMenu = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsMainMenu.Add(new GradientStop
                            {
                                Color = !selectedLights.Any()
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsMainMenu = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
            else if (propertyName == "PlayerGetsFlashed")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsPlayerGetsFlashed = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsPlayerGetsFlashed.Add(new GradientStop
                            {
                                Color = selectedLights.Count < 1
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsPlayerGetsFlashed = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
            else if (propertyName == "TerroristsWin")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsTerroristsWin = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsTerroristsWin.Add(new GradientStop
                            {
                                Color = selectedLights.Count < 1
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsTerroristsWin = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
            else if (propertyName == "CounterTerroristsWin")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsCounterTerroristsWin = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsCounterTerroristsWin.Add(new GradientStop
                            {
                                Color = selectedLights.Count < 1
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsCounterTerroristsWin = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
            else if (propertyName == "RoundStarts")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsRoundStarts = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsRoundStarts.Add(new GradientStop
                            {
                                Color = selectedLights.Count < 1
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsRoundStarts = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
            else if (propertyName == "BombPlanted")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsBombPlanted = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsBombPlanted.Add(new GradientStop
                            {
                                Color = selectedLights.Count < 1
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsBombPlanted = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
        }

        public void UpdateGradient(string propertyName, EventBrightnessProperty Event)
        {
            if (propertyName == "PlayerGetsKill")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsPlayerGetsKill = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsPlayerGetsKill.Add(new GradientStop
                            {
                                Color = selectedLights.Count < 1
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsPlayerGetsKill = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
            else if (propertyName == "PlayerGetsKilled")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsPlayerGetsKilled = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsPlayerGetsKilled.Add(new GradientStop
                            {
                                Color = selectedLights.Count < 1
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsPlayerGetsKilled = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
            else if (propertyName == "FreezeTime")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsFreezeTime = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsFreezeTime.Add(new GradientStop
                            {
                                Color = selectedLights.Count < 1
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsFreezeTime = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
            else if (propertyName == "Warmup")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsWarmup = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsWarmup.Add(new GradientStop
                            {
                                Color = selectedLights.Count < 1
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsWarmup = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
            else if (propertyName == "BombExplodes")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsBombExplodes = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsBombExplodes.Add(new GradientStop
                            {
                                Color = selectedLights.Count < 1
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsBombExplodes = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
            else if (propertyName == "BombBlink")
            {
                if (Event?.SelectedLights != null)
                {
                    var selectedLights = Event.Lights.FindAll(x => Event.SelectedLights.Contains(x.Id));

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsBombBlink = new GradientStopCollection();
                        for (var i = 0; i < (selectedLights.Count < 2 ? 2 : selectedLights.Count); i++)
                        {
                            ViewModel.GradientStopsBombBlink.Add(new GradientStop
                            {
                                Color = selectedLights.Count < 1
                                    ? Colors.Black
                                    : (selectedLights.Count < 2
                                        ? Color.FromArgb(255, selectedLights[0].Color.Red, selectedLights[0].Color.Green, selectedLights[0].Color.Blue)
                                        : Color.FromArgb(255, selectedLights[i].Color.Red, selectedLights[i].Color.Green, selectedLights[i].Color.Blue)),
                                Offset = i * 1 / (float)((selectedLights.Count < 2 ? 2 : selectedLights.Count) - 1)
                            });
                        }
                    });
                }
                else
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        ViewModel.GradientStopsBombBlink = new GradientStopCollection()
                    {
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 0
                        },
                        new GradientStop()
                        {
                            Color = Colors.Black,
                            Offset = 1
                        }
                    };
                    });
                }
            }
        }

        private void ComboBoxLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == -1)
            {
                var culture = CultureResources.SupportedCultures.Contains(CultureInfo.InstalledUICulture)
                    ? CultureInfo.InstalledUICulture
                    : new CultureInfo("en-US");

                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;

                Thread.CurrentThread.CurrentCulture = culture;
                Thread.CurrentThread.CurrentUICulture = culture;

                Cultures.Resources.Culture = culture;

                CultureResources.ChangeCulture(culture);

                Properties.Settings.Default.Language = Converters.GetIndexFromCultureInfo(culture);
            }
            else
            {
                var culture = Converters.GetCultureInfoFromIndex(((ComboBox)sender).SelectedIndex);

                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;

                Thread.CurrentThread.CurrentCulture = culture;
                Thread.CurrentThread.CurrentUICulture = culture;

                Cultures.Resources.Culture = culture;

                Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();
            }
        }

        private async void Default_Click(object sender, RoutedEventArgs e)
        {
            Window messageBox = new CustomMessageBox
            {
                Yes = Cultures.Resources.Yes,
                No = Cultures.Resources.No,
                Message = Cultures.Resources.AreYouSure,
                Owner = Window.GetWindow(this)
            };
            messageBox.ShowDialog();

            if (messageBox.DialogResult != true) return;

            ComboBoxLanguage.SelectionChanged -= ComboBoxLanguage_SelectionChanged;
            Properties.Settings.Default.Reset();
            ViewModel.MainWindowViewModel.ConfigPage.ViewModel.CheckConfigFile();
            await MainWindowViewModel.SetDefaultLightsSettings();

            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void RunOnStartupCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.RunOnStartup)
                ViewModel.AddStartup(Properties.Settings.Default.RunOnStartupMinimized);
            else
                ViewModel.RemoveStartup();
        }
    }
}
