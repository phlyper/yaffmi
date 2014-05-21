using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Yaffmi
{
	class SettingsException : Exception
	{
		public enum OperationValue
		{
			Load = 0,
			Save,
		}

		static readonly string[] Messages =
		{
			"Could not load settings",
			"Could not save settings",
		};

		public OperationValue Operation { get; private set; }

		public SettingsException(OperationValue operation, Exception innerException)
			: base(Messages[(int)operation], innerException)
		{
			Operation = operation;
		}
	}

	static class Settings
	{
		public static string Version { get; private set; }
		public static string Title { get; private set; }

		public static int Architecture { get; private set; }

		public static string AppDataDirectory { get; private set; }
		public static string ProgramDirectory { get; private set; }
		public static string UserPresetsDirectory { get; private set; }
		public static string GlobalPresetsDirectory { get; private set; }
		public static string SettingsFile { get; private set; }

		public static bool ShowAdvancedTab { get; set; }
		public static bool ShowFullInputFilePath { get; set; }
		public static bool NeverAbortOnError { get; set; }

		public static string DefaultOutputFolder { get; set; }
		public static bool DefaultSaveLog { get; set; }

		public static string FFmpegPath32 { get; set; }
		public static string FFmpegPath64 { get; set; }
		public static int FFmpegVersion { get; set; }

		public static event EventHandler Updated;

		public static string FFmpegPath
		{
			get
			{
				return 
					(FFmpegVersion == 64 ||
					(FFmpegVersion == 0 && Architecture == 64)) ?
					FFmpegPath64 : FFmpegPath32;
			}
		}

		static Settings()
		{
			Version versionInfo = Assembly
				.GetExecutingAssembly()
				.GetName()
				.Version;
			Version = String.Format(
				"Version {0}{1:'.'0;'';''}{2:' Beta '0;''}",
				versionInfo.Major, versionInfo.Minor,
				// Build number < 999 = beta, 999 = release
				(versionInfo.Build < 999) ? versionInfo.Build : -1);
			Title = String.Format("Yaffmi {0}", Version);

			Architecture = (Environment.Is64BitOperatingSystem) ? 64 : 32;

			string appData = Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData, 
				Environment.SpecialFolderOption.Create);
			AppDataDirectory = appData + 
				Path.DirectorySeparatorChar + "Yaffmi";
			if (!Directory.Exists(AppDataDirectory))
				Directory.CreateDirectory(AppDataDirectory);

			ProgramDirectory = AppDomain.CurrentDomain.BaseDirectory
				.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

			UserPresetsDirectory = AppDataDirectory + 
				Path.DirectorySeparatorChar + "presets";
			if (!Directory.Exists(UserPresetsDirectory))
				Directory.CreateDirectory(UserPresetsDirectory);

			GlobalPresetsDirectory = ProgramDirectory +
				Path.DirectorySeparatorChar + "presets";

			SettingsFile = AppDataDirectory +
				Path.DirectorySeparatorChar + "settings.xml";

			ShowAdvancedTab = false;
			ShowFullInputFilePath = false;
			NeverAbortOnError = false;

			DefaultOutputFolder = Environment.GetFolderPath(
				Environment.SpecialFolder.Desktop, 
				Environment.SpecialFolderOption.Create);
			DefaultSaveLog = false;

			FFmpegPath32 = ProgramDirectory + 
				Path.DirectorySeparatorChar + "ffmpeg" + 
				Path.DirectorySeparatorChar + "ffmpeg-2.2.1-win32-static.exe";
			FFmpegPath64 = ProgramDirectory +
				Path.DirectorySeparatorChar + "ffmpeg" +
				Path.DirectorySeparatorChar + "ffmpeg-2.2.1-win64-static.exe";
			FFmpegVersion = 0;
		}

		public static void Update()
		{
			if (Updated != null)
				Updated(null, EventArgs.Empty);
		}

		public static void Load()
		{
			if (!File.Exists(SettingsFile))
			{
				Save();
				return;
			}

			XmlDocument document = new XmlDocument();
			try { document.Load(SettingsFile); }
			catch (Exception e)
			{
				throw new SettingsException(
					SettingsException.OperationValue.Load, e);
			}

			XmlElement settingsElement = document.DocumentElement;

			string showAdvancedTab = settingsElement.GetChildText("ShowAdvancedTab");
			string showFullInputFilePath = settingsElement.GetChildText("ShowFullInputFilePath");
			string neverAbortOnError = settingsElement.GetChildText("NeverAbortOnError");

			if (showAdvancedTab != null)
				ShowAdvancedTab = Helpers.ToBool(showAdvancedTab);
			if (showFullInputFilePath != null)
				ShowFullInputFilePath = Helpers.ToBool(showFullInputFilePath);
			if (neverAbortOnError != null)
				NeverAbortOnError = Helpers.ToBool(neverAbortOnError);

			string defaultOutputFolder = settingsElement.GetChildText("DefaultOutputFolder");
			string defaultSaveLog = settingsElement.GetChildText("DefaultSaveLog");

			if (defaultOutputFolder != null &&
				!defaultOutputFolder.ContainsAny(Path.GetInvalidPathChars()) &&
				Directory.Exists(defaultOutputFolder))
				DefaultOutputFolder = defaultOutputFolder;

			if (defaultSaveLog != null)
				DefaultSaveLog = Helpers.ToBool(defaultSaveLog);

			string ffmpegPath32 = settingsElement.GetChildText("FFmpegPath32");
			string ffmpegPath64 = settingsElement.GetChildText("FFmpegPath64");
			string ffmpegVersion = settingsElement.GetChildText("FFmpegVersion");

			if (ffmpegPath32 != null &&
				!ffmpegPath32.ContainsAny(Path.GetInvalidPathChars()) &&
				File.Exists(ffmpegPath32))
				FFmpegPath32 = ffmpegPath32;

			if (ffmpegPath64 != null &&
				!ffmpegPath64.ContainsAny(Path.GetInvalidPathChars()) &&
				File.Exists(ffmpegPath64))
				FFmpegPath64 = ffmpegPath64;

			if (ffmpegVersion != null)
				FFmpegVersion = Helpers.ToInt(ffmpegVersion);

			// Re-save in case some default values had to be used
			Save();
		}

		public static void Save()
		{
			XmlDocument document = new XmlDocument();
			XmlElement settingsElement = document.AppendNewChildElement("YaffmiSettings");

			settingsElement.AppendNewChildElement("ShowAdvancedTab", 
				ShowAdvancedTab.ToString().ToLower());
			settingsElement.AppendNewChildElement("ShowFullInputFilePath",
				ShowFullInputFilePath.ToString().ToLower());
			settingsElement.AppendNewChildElement("NeverAbortOnError",
				NeverAbortOnError.ToString().ToLower());

			settingsElement.AppendNewChildElement("DefaultOutputFolder", DefaultOutputFolder);
			settingsElement.AppendNewChildElement("DefaultSaveLog",
				DefaultSaveLog.ToString().ToLower());

			settingsElement.AppendNewChildElement("FFmpegPath32", FFmpegPath32);
			settingsElement.AppendNewChildElement("FFmpegPath64", FFmpegPath64);
			settingsElement.AppendNewChildElement("FFmpegVersion", 
				FFmpegVersion.ToString(CultureInfo.InvariantCulture));

			XmlWriterSettings settings = new XmlWriterSettings
			{
				Indent = true, 
				CloseOutput = true,
			};

			try
			{
				if (File.Exists(SettingsFile))
					File.Delete(SettingsFile);

				using (XmlWriter writer = XmlWriter.Create(SettingsFile, settings))
					document.WriteTo(writer);
			}
			catch (Exception e)
			{
				throw new SettingsException(
					SettingsException.OperationValue.Save, e);
			}
		}
	}
}
