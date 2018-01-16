using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace net.glympz.ProfileManagerSTMR.Business
{
	public static class AppLogic
	{
		public static void LaunchGame(int appID)
		{
			string steamPath = @"C:\Program Files (x86)\Steam\Steam.exe";

			Process steam = new Process();
			steam.StartInfo.FileName = steamPath;
			steam.StartInfo.Arguments = $"-applaunch {appID}";
			steam.Start();
		}

		public static string PathCombine(string path1, string path2)
		{
			path1 = (path1 ?? "").TrimEnd(Path.DirectorySeparatorChar);
			path2 = (path2 ?? "").TrimStart(Path.DirectorySeparatorChar);

			return Path.Combine(path1, path2);
		}

		internal static bool GetInitialSettings(ApplicationSettings appSettings, out string messages)
		{
			bool showSettingsDialog = false;
			messages = "";

			// Attempt to get the Steam program folder
			if (string.IsNullOrEmpty(appSettings.SteamFolder) || !Directory.Exists(appSettings.SteamFolder))
			{
				appSettings.SteamFolder = Registry.GetValue(appSettings.SteamRegistryKey32, "InstallPath", "") as string;
				if (string.IsNullOrEmpty(appSettings.SteamFolder) || !Directory.Exists(appSettings.SteamFolder))
				{
					appSettings.SteamFolder = Registry.GetValue(appSettings.SteamRegistryKey64, "InstallPath", "") as string;
				}
			}
			if (string.IsNullOrEmpty(appSettings.SteamFolder) || !Directory.Exists(appSettings.SteamFolder))
			{
				appSettings.SteamFolder = "";
				showSettingsDialog = true;
			}

			// Attempt to get the Spintires: Mudrunner game files folder
			if (string.IsNullOrEmpty(appSettings.GameFolder) || !Directory.Exists(appSettings.GameFolder))
			{
				var gamePath = AppLogic.PathCombine(appSettings.SteamFolder, appSettings.GameSubfolder);
				// Check the default steam library path
				if (Directory.Exists(gamePath))
				{
					appSettings.GameFolder = gamePath;
				}
				else
				{
					// Scan the library config file for game library paths
					var libraryFolderConfigPath = AppLogic.PathCombine(appSettings.SteamFolder, appSettings.LibraryFoldersConfig);
					if (!Directory.Exists(AppLogic.PathCombine(appSettings.SteamFolder, appSettings.GameSubfolder)))
					{
						if (File.Exists(libraryFolderConfigPath))
						{
							bool foundGamePath = false;
							// Open steam config and find library folder paths
							var libraryReg = new Regex(@"""\d+""\s+""([^""]+)""");
							foreach (var line in File.ReadAllLines(libraryFolderConfigPath))
							{
								var match = libraryReg.Match(line);
								if (match.Success)
								{
									var libraryPath = match.Groups[1].Value.Replace(@"\\", @"\");
									gamePath = AppLogic.PathCombine(libraryPath, appSettings.GameSubfolder);    // Naive unescaping for Valves path values
																												// See if the game folder exists in this library
									if (Directory.Exists(gamePath))
									{
										appSettings.GameFolder = gamePath;
										foundGamePath = true;
										break;
									}
								}
							}

							if (!foundGamePath)
							{
								appSettings.GameFolder = "";
								showSettingsDialog = true;
							}
						}
						else
						{
							appSettings.GameFolder = "";
							showSettingsDialog = true;
						}
					}
					else
					{
						appSettings.GameFolder = appSettings.SteamFolder;
					}
				}
			}

			// Attempt to get the Spintires: Mudrunner AppData folder
			if (string.IsNullOrEmpty(appSettings.GameAppDataFolder) || !Directory.Exists(appSettings.GameAppDataFolder))
			{
				var gameAppDataFolder = AppLogic.PathCombine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), appSettings.GameAppDataFolderName);
				if (Directory.Exists(gameAppDataFolder))
				{
					appSettings.GameAppDataFolder = gameAppDataFolder;
				}
				else
				{
					appSettings.GameAppDataFolder = "";
					showSettingsDialog = true;
				}
			}

			// Attempt to get the Spintires: Mudrunner Mod folder
			if (!string.IsNullOrEmpty(appSettings.GameFolder)) {
				if (!string.IsNullOrEmpty(appSettings.ModFolder))
				{
					var gameUri = new Uri(appSettings.GameFolder);
					var modUri = new Uri(appSettings.ModFolder);

					// If the mod folder we have is not the game folder or a subfolder then we don't want to use it
					if (gameUri != modUri && gameUri.IsBaseOf(modUri))
					{
						appSettings.ModFolder = "";
					}
				}

				if (string.IsNullOrEmpty(appSettings.ModFolder) || !Directory.Exists(appSettings.ModFolder))
				{
					var modFolder = AppLogic.PathCombine(appSettings.GameFolder, appSettings.ModSubfolderName);
					try
					{
						Directory.CreateDirectory(modFolder);
						appSettings.ModFolder = modFolder;
					}
					catch
					{
						appSettings.ModFolder = null;
						messages = "The mod folder could not be created.";
					}
				}
			}

			appSettings.Save();

			// Attempt to create the profile folder
			if (!string.IsNullOrEmpty(appSettings.GameAppDataFolder))
			{
				try
				{
					Directory.CreateDirectory(AppLogic.PathCombine(appSettings.GameAppDataFolder, appSettings.ProfilesSubfolderName));
				}
				catch
				{
					messages = "The profile folder could not be created";
				}
			}

			return showSettingsDialog;
		}
	}
}
