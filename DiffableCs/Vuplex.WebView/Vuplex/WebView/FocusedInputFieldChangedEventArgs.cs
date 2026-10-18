namespace Vuplex.WebView;

public class FocusedInputFieldChangedEventArgs : EventArgs
{
	public readonly FocusedInputFieldType Type; //Field offset: 0x10

	public FocusedInputFieldChangedEventArgs(FocusedInputFieldType type) { }

	public static FocusedInputFieldType ParseType(string typeString) { }

}

