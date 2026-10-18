namespace FilesChecker;

public sealed class ConsistencyViolationException : Exception
{
	[CompilerGenerated]
	private readonly EViolation <Violation>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly string <Cause>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private readonly FileConsistencyMetadata <FileConsistencyMetadata>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private readonly Nullable <CurrentSize>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private readonly Nullable <CurrentChecksum>k__BackingField; //Field offset: 0xB8

	public string Cause
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Nullable CurrentChecksum
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Nullable CurrentSize
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public FileConsistencyMetadata FileConsistencyMetadata
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public EViolation Violation
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public ConsistencyViolationException(EViolation violation, string message, FileConsistencyMetadata fileConsistencyMetadata, Nullable currentSize = null, Nullable currentChecksum = null) { }

	[CompilerGenerated]
	public string get_Cause() { }

	[CompilerGenerated]
	public Nullable get_CurrentChecksum() { }

	[CompilerGenerated]
	public Nullable get_CurrentSize() { }

	[CompilerGenerated]
	public FileConsistencyMetadata get_FileConsistencyMetadata() { }

	[CompilerGenerated]
	public EViolation get_Violation() { }

}

