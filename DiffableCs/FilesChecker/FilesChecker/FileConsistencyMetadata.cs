namespace FilesChecker;

public class FileConsistencyMetadata
{
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly long <Size>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <Checksum>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <IsCritical>k__BackingField; //Field offset: 0x24

	public int Checksum
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool IsCritical
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Path
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public long Size
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public FileConsistencyMetadata(string path, long size, int checksum, bool isCritical = false) { }

	[CompilerGenerated]
	public int get_Checksum() { }

	[CompilerGenerated]
	public bool get_IsCritical() { }

	[CompilerGenerated]
	public string get_Path() { }

	[CompilerGenerated]
	public long get_Size() { }

}

