namespace System.IO;

internal class FileData
{
	public string Directory; //Field offset: 0x10
	public FileAttributes Attributes; //Field offset: 0x18
	public bool NotExists; //Field offset: 0x1C
	public DateTime CreationTime; //Field offset: 0x20
	public DateTime LastWriteTime; //Field offset: 0x28

	public FileData() { }

}

