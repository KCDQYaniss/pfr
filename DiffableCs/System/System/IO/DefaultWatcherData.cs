namespace System.IO;

internal class DefaultWatcherData
{
	public FileSystemWatcher FSW; //Field offset: 0x10
	public string Directory; //Field offset: 0x18
	public string FileMask; //Field offset: 0x20
	public bool IncludeSubdirs; //Field offset: 0x28
	public bool Enabled; //Field offset: 0x29
	public bool NoWildcards; //Field offset: 0x2A
	public DateTime DisabledTime; //Field offset: 0x30
	public object FilesLock; //Field offset: 0x38
	public Dictionary Files; //Field offset: 0x40

	public DefaultWatcherData() { }

}

