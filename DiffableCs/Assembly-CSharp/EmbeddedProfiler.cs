//Type is in global namespace

public sealed class EmbeddedProfiler : IDisposable
{
	[CompilerGenerated]
	private static class <>O
	{
		public static WaitCallback <0>__PruneFile; //Field offset: 0x0

	}

	private static EmbeddedProfiler _instance; //Field offset: 0x0
	public const string UpdateSamplerName = "EmbeddedProfiler.Update"; //Field offset: 0x0
	private readonly Queue _files; //Field offset: 0x10
	private readonly WaitCallback _pruneFileCallBack; //Field offset: 0x18
	private readonly CustomSampler _updateSampler; //Field offset: 0x20
	private Func _fileNameGetter; //Field offset: 0x28
	private int _framesPerFile; //Field offset: 0x30
	private int _maxFilesCount; //Field offset: 0x34
	private int _frameCounter; //Field offset: 0x38
	private int _fileCounter; //Field offset: 0x3C
	private bool _paused; //Field offset: 0x40
	private bool _keepCurrentFile; //Field offset: 0x41
	[CompilerGenerated]
	private Action OnUpdate; //Field offset: 0x48
	[CompilerGenerated]
	private Action BeforeNewFileCreated; //Field offset: 0x50
	[CompilerGenerated]
	private bool <Started>k__BackingField; //Field offset: 0x58

	public event Action BeforeNewFileCreated
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public int CurrentFrameCounter
	{
		 get { } //Length: 4
	}

	public static EmbeddedProfiler Instance
	{
		 get { } //Length: 190
	}

	public bool Paused
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	public private bool Started
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private EmbeddedProfiler() { }

	[CompilerGenerated]
	private string <CreateNewProfilerLogFile>g__CreateLogFile|34_0() { }

	[CompilerGenerated]
	public void add_BeforeNewFileCreated(Action value) { }

	[CompilerGenerated]
	public void add_OnUpdate(Action value) { }

	private void CreateNewProfilerLogFile() { }

	public override void Dispose() { }

	public static void EnableAreas(ProfilerArea[] profilerAreas) { }

	public int get_CurrentFrameCounter() { }

	public static EmbeddedProfiler get_Instance() { }

	public bool get_Paused() { }

	[CompilerGenerated]
	public bool get_Started() { }

	public void KeepCurrentFile() { }

	public void PruneAllFiles() { }

	private static void PruneFile(object state) { }

	[CompilerGenerated]
	public void remove_BeforeNewFileCreated(Action value) { }

	[CompilerGenerated]
	public void remove_OnUpdate(Action value) { }

	public void set_Paused(bool value) { }

	[CompilerGenerated]
	private void set_Started(bool value) { }

	public void StartProfiling(Func fileNameGetter, int framesPerFile, int maxFilesCount, bool paused, ProfilerArea[] profilerAreas) { }

	public void StopProfiling() { }

	private void Update() { }

}

