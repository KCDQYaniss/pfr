namespace SFB;

public interface IStandaloneFileBrowser
{

	public string[] OpenFilePanel(string title, string directory, ExtensionFilter[] extensions, bool multiselect) { }

	public void OpenFilePanelAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action cb) { }

	public string[] OpenFolderPanel(string title, string directory, bool multiselect) { }

	public void OpenFolderPanelAsync(string title, string directory, bool multiselect, Action cb) { }

	public string SaveFilePanel(string title, string directory, string defaultName, ExtensionFilter[] extensions) { }

	public void SaveFilePanelAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action cb) { }

}

