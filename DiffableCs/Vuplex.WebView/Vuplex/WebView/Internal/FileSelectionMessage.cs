namespace Vuplex.WebView.Internal;

public class FileSelectionMessage
{
	public string[] AcceptFilters; //Field offset: 0x10
	public bool MultipleAllowed; //Field offset: 0x18

	public FileSelectionMessage() { }

	public static FileSelectionMessage FromJson(string json) { }

}

