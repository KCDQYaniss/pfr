namespace System.ComponentModel;

public class AsyncCompletedEventArgs : EventArgs
{
	private readonly Exception error; //Field offset: 0x10
	private readonly bool cancelled; //Field offset: 0x18
	private readonly object userState; //Field offset: 0x20

	public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState) { }

}

