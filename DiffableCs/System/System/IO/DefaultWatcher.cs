namespace System.IO;

internal class DefaultWatcher : IFileWatcher
{
	private static DefaultWatcher instance; //Field offset: 0x0
	private static Thread thread; //Field offset: 0x8
	private static Hashtable watches; //Field offset: 0x10
	private static string[] NoStringsArray; //Field offset: 0x18

	private static DefaultWatcher() { }

	private DefaultWatcher() { }

	private static FileData CreateFileData(string directory, string filename) { }

	private static void DispatchEvents(FileSystemWatcher fsw, FileAction action, string filename) { }

	public override void Dispose(object handle) { }

	private void DoFiles(DefaultWatcherData data, string directory, bool dispatch) { }

	public static bool GetInstance(out IFileWatcher watcher) { }

	private void IterateAndModifyFilesData(DefaultWatcherData data, string directory, bool dispatch, string[] files) { }

	private void Monitor() { }

	public override void StartDispatching(object handle) { }

	public override void StopDispatching(object handle) { }

	private bool UpdateDataAndDispatch(DefaultWatcherData data, bool dispatch) { }

}

