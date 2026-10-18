namespace System.Diagnostics;

public class DataReceivedEventArgs : EventArgs
{
	private string data; //Field offset: 0x10

	public string Data
	{
		 get { } //Length: 5
	}

	internal DataReceivedEventArgs(string data) { }

	public string get_Data() { }

}

