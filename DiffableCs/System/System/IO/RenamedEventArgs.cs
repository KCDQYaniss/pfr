namespace System.IO;

public class RenamedEventArgs : FileSystemEventArgs
{
	private readonly string _oldName; //Field offset: 0x28
	private readonly string _oldFullPath; //Field offset: 0x30

	public RenamedEventArgs(WatcherChangeTypes changeType, string directory, string name, string oldName) { }

}

