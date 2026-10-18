namespace System.IO.Enumeration;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct FileSystemEntry
{
	internal FILE_FULL_DIR_INFORMATION* _info; //Field offset: 0x0
	[CompilerGenerated]
	private ReadOnlySpan <Directory>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private ReadOnlySpan <RootDirectory>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ReadOnlySpan <OriginalRootDirectory>k__BackingField; //Field offset: 0x28

	public FileAttributes Attributes
	{
		 get { } //Length: 25
	}

	public private ReadOnlySpan Directory
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public ReadOnlySpan FileName
	{
		 get { } //Length: 109
	}

	public bool IsDirectory
	{
		 get { } //Length: 29
	}

	public private ReadOnlySpan OriginalRootDirectory
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ReadOnlySpan RootDirectory
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public FileAttributes get_Attributes() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ReadOnlySpan get_Directory() { }

	public ReadOnlySpan get_FileName() { }

	public bool get_IsDirectory() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ReadOnlySpan get_OriginalRootDirectory() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ReadOnlySpan get_RootDirectory() { }

	internal static void Initialize(ref FileSystemEntry entry, FILE_FULL_DIR_INFORMATION* info, ReadOnlySpan directory, ReadOnlySpan rootDirectory, ReadOnlySpan originalRootDirectory) { }

	[CompilerGenerated]
	private void set_Directory(ReadOnlySpan value) { }

	[CompilerGenerated]
	private void set_OriginalRootDirectory(ReadOnlySpan value) { }

	[CompilerGenerated]
	private void set_RootDirectory(ReadOnlySpan value) { }

	public string ToSpecifiedFullPath() { }

}

