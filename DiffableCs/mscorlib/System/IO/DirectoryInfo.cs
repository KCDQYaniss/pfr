namespace System.IO;

public sealed class DirectoryInfo : FileSystemInfo
{

	public DirectoryInfo Parent
	{
		 get { } //Length: 449
	}

	public DirectoryInfo Root
	{
		 get { } //Length: 144
	}

	public DirectoryInfo(string path) { }

	internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	private DirectoryInfo(SerializationInfo info, StreamingContext context) { }

	public void Create() { }

	public DirectoryInfo get_Parent() { }

	public DirectoryInfo get_Root() { }

	private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

}

