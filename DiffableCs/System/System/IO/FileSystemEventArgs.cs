namespace System.IO;

public class FileSystemEventArgs : EventArgs
{
	private readonly WatcherChangeTypes _changeType; //Field offset: 0x10
	private readonly string _name; //Field offset: 0x18
	private readonly string _fullPath; //Field offset: 0x20

	public FileSystemEventArgs(WatcherChangeTypes changeType, string directory, string name) { }

	internal static string Combine(string directoryPath, string name) { }

}

