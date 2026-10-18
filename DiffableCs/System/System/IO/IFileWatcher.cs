namespace System.IO;

internal interface IFileWatcher
{

	public void Dispose(object fsw) { }

	public void StartDispatching(object fsw) { }

	public void StopDispatching(object fsw) { }

}

