namespace System.IO;

public sealed class FileSystemEventHandler : MulticastDelegate
{

	public FileSystemEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, FileSystemEventArgs e) { }

}

