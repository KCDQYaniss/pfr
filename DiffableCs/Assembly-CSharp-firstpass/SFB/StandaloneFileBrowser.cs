namespace SFB;

public class StandaloneFileBrowser
{
	private static IStandaloneFileBrowser _platformWrapper; //Field offset: 0x0

	private static StandaloneFileBrowser() { }

	public StandaloneFileBrowser() { }

	public static string[] OpenFilePanel(string title, string directory, string extension, bool multiselect) { }

	public static string[] OpenFilePanel(string title, string directory, ExtensionFilter[] extensions, bool multiselect) { }

	public static void OpenFilePanelAsync(string title, string directory, string extension, bool multiselect, Action cb) { }

	public static void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action cb) { }

	public static string[] OpenFolderPanel(string title, string directory, bool multiselect) { }

	public static void OpenFolderPanelAsync(string title, string directory, bool multiselect, Action cb) { }

	public static string SaveFilePanel(string title, string directory, string defaultName, string extension) { }

	public static string SaveFilePanel(string title, string directory, string defaultName, ExtensionFilter[] extensions) { }

	public static void SaveFilePanelAsync(string title, string directory, string defaultName, string extension, Action cb) { }

	public static void SaveFilePanelAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action cb) { }

}

