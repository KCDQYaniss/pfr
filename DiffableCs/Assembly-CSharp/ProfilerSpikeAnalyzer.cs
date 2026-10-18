//Type is in global namespace

public sealed class ProfilerSpikeAnalyzer : IDisposable
{
	private sealed class RecorderData
	{
		private readonly Recorder _recorder; //Field offset: 0x10
		private readonly bool _divideBySamplesCount; //Field offset: 0x18

		internal RecorderData(Recorder recorder, bool divideBySamplesCount = false) { }

		internal long ElapsedNanoseconds() { }

	}

	private struct SpikeFile
	{
		public string path; //Field offset: 0x0
		public float time; //Field offset: 0x8
		public int profilerFrame; //Field offset: 0xC
		public int gameFrame; //Field offset: 0x10

	}

	private readonly RecorderData[] _addRecorders; //Field offset: 0x10
	private readonly RecorderData[] _subtractRecorders; //Field offset: 0x18
	private readonly Recorder _embeddedProfilerRecorder; //Field offset: 0x20
	private readonly float _triggerTime; //Field offset: 0x28
	private readonly string _workingDirectory; //Field offset: 0x30
	private readonly string _baseFileName; //Field offset: 0x38
	private readonly WaitCallback _renameCallBack; //Field offset: 0x40
	private int _fileNumber; //Field offset: 0x48
	private SpikeFile _currentSpike; //Field offset: 0x50
	private string _currentFile; //Field offset: 0x68

	public ProfilerSpikeAnalyzer(string workingDirectory, IReadOnlyList addRecorders, IReadOnlyList subtractRecorders, float triggerTime, int framesPerFile, bool paused, ProfilerArea[] profilerAreas) { }

	private void BeforeNewFileCreated() { }

	private static RecorderData[] CreateRecorders(IReadOnlyList configs) { }

	public override void Dispose() { }

	private string FileNameGetter(int fileNumber) { }

	private static long GetRecordersElapsedNanoseconds(RecorderData[] recorders) { }

	private void OnUpdate() { }

	public void Pause() { }

	private void RenameFile(object state) { }

	public void Resume() { }

}

