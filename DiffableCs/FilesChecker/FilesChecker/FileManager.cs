namespace FilesChecker;

internal class FileManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public FileStream fs; //Field offset: 0x10
		public FileMode fileMode; //Field offset: 0x18
		public FileAccess fileAccess; //Field offset: 0x1C
		public FileShare fileShare; //Field offset: 0x20

		public <>c__DisplayClass10_0() { }

		internal void <CaptureFile>b__0(string p) { }

	}

	private const string LongPathPrefix = "\\?\"; //Field offset: 0x0
	private const int MaxNumberOfRetries = 3; //Field offset: 0x0
	private const int DelayOnRetry = 1000; //Field offset: 0x0
	private readonly FilesCheckerLogger _logger; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnFileOperationError; //Field offset: 0x18

	public event Action OnFileOperationError
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public FileManager(FilesCheckerLogger logger) { }

	[CompilerGenerated]
	public void add_OnFileOperationError(Action value) { }

	public FileStream CaptureFile(string path, FileMode fileMode = 3, FileAccess fileAccess = 1, FileShare fileShare = 1) { }

	public long GetFileSize(string path) { }

	private static string GetFullLongPath(string path) { }

	private void HandleFileExceptions(Action fileAction, string path) { }

	public bool IsFileExist(string path) { }

	[CompilerGenerated]
	public void remove_OnFileOperationError(Action value) { }

}

