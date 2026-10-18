namespace System.IO;

internal class NullFileWatcher : IFileWatcher
{
	private static IFileWatcher instance; //Field offset: 0x0

	public NullFileWatcher() { }

	public override void Dispose(object handle) { }

	public static bool GetInstance(out IFileWatcher watcher) { }

	public override void StartDispatching(object handle) { }

	public override void StopDispatching(object handle) { }

}

