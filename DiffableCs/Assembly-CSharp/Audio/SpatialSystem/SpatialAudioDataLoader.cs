namespace Audio.SpatialSystem;

public class SpatialAudioDataLoader
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public SpatialAudioDataLoader <>4__this; //Field offset: 0x10
		public SpatialAudioDataContainer dataContainer; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <LoadDataAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <LoadDataAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpatialAudioDataLoader <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly string _fullPath; //Field offset: 0x10
	private readonly AudioBakeDataSerializer _bakeDataSerializer; //Field offset: 0x18
	private TaskCompletionSource _dataLoadedTcs; //Field offset: 0x20
	private Coroutine _loadCoroutine; //Field offset: 0x28
	private readonly MonoBehaviour _runner; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnDataLoaded; //Field offset: 0x38

	public event Action OnDataLoaded
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public SpatialAudioDataLoader(string dataPath, MonoBehaviour runner) { }

	[CompilerGenerated]
	private void <LoadBakeDataAsync>b__12_0(Exception ex) { }

	[CompilerGenerated]
	public void add_OnDataLoaded(Action value) { }

	private void DataLoadedHandler(SpatialAudioDataContainer dataContainer) { }

	private void LoadBakeDataAsync(string path, SpatialAudioDataContainer container, CancellationToken cancellationToken, Action onDone = null) { }

	[AsyncStateMachine(typeof(<LoadDataAsync>d__9))]
	public Task LoadDataAsync(CancellationToken cancellationToken) { }

	private void LoadRoomsAndPortals(SpatialAudioDataContainer container) { }

	[CompilerGenerated]
	public void remove_OnDataLoaded(Action value) { }

	public void StopLoadCoroutine() { }

}

