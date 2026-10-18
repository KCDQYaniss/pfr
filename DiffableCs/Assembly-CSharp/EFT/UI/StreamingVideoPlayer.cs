namespace EFT.UI;

[RequireComponent(typeof(VideoPlayer))]
public sealed class StreamingVideoPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public TaskCompletionSource completed; //Field offset: 0x10
		public long firstFrame; //Field offset: 0x18

		public <>c__DisplayClass25_0() { }

		internal void <WarmupAsync>g__OnError|1(VideoPlayer source, string message) { }

		internal void <WarmupAsync>g__OnFrameReady|2(VideoPlayer source, long frame) { }

		internal void <WarmupAsync>g__OnPrepared|0(VideoPlayer source) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public TaskCompletionSource completed; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal void <PrepareForPlaybackAsync>g__OnError|1(VideoPlayer source, string message) { }

		internal void <PrepareForPlaybackAsync>g__OnPrepared|0(VideoPlayer source) { }

		internal void <PrepareForPlaybackAsync>g__OnSeekCompleted|2(VideoPlayer source) { }

	}

	[CompilerGenerated]
	private struct <PrepareForPlaybackAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StreamingVideoPlayer <>4__this; //Field offset: 0x20
		public float timeout; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private <>c__DisplayClass26_0 <>8__1; //Field offset: 0x38
		private VideoPlayer <videoPlayer>5__2; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WarmupAsync>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StreamingVideoPlayer <>4__this; //Field offset: 0x20
		public float timeout; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private <>c__DisplayClass25_0 <>8__1; //Field offset: 0x38
		private VideoPlayer <videoPlayer>5__2; //Field offset: 0x40
		private bool <warmedUp>5__3; //Field offset: 0x48
		private YieldAwaiter <>u__1; //Field offset: 0x49

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private VideoPlayer _videoPlayer; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Relative path in StreamingAssets (e.g. Folder_name/Video_name.mp4)")]
	private string _streamingAssetsPath; //Field offset: 0x28
	[SerializeField]
	private bool _loop; //Field offset: 0x30
	private Renderer _outputRenderer; //Field offset: 0x38
	private string _outputTexturePropertyName; //Field offset: 0x40
	private int _outputTextureProperty; //Field offset: 0x48
	private RenderTexture _outputTexture; //Field offset: 0x50
	private MaterialPropertyBlock _propertyBlock; //Field offset: 0x58
	private long _resumeFrame; //Field offset: 0x60

	public bool HasValidPath
	{
		 get { } //Length: 22
	}

	public bool IsPlaying
	{
		 get { } //Length: 293
	}

	public Renderer OutputRenderer
	{
		 get { } //Length: 5
	}

	public string Path
	{
		 get { } //Length: 5
	}

	public VideoPlayer VideoPlayer
	{
		 get { } //Length: 5
	}

	public StreamingVideoPlayer() { }

	private void ApplyOutputTexture() { }

	private void ApplyStreamingAssetsPath() { }

	private void Awake() { }

	private void Configure() { }

	private void DiscardOutputTexture() { }

	private bool EnsureOutputTexture() { }

	private void EnsureVideoPlayer() { }

	public void Freeze() { }

	public bool get_HasValidPath() { }

	public bool get_IsPlaying() { }

	public Renderer get_OutputRenderer() { }

	public string get_Path() { }

	public VideoPlayer get_VideoPlayer() { }

	public void InitializePersistentOutput() { }

	private void OnDestroy() { }

	private void OnPreparedForFreeze(VideoPlayer source) { }

	private void OnPreparedForPlay(VideoPlayer source) { }

	public void Pause() { }

	public void Play() { }

	public void Prepare() { }

	[AsyncStateMachine(typeof(<PrepareForPlaybackAsync>d__26))]
	public Task PrepareForPlaybackAsync(float timeout, CancellationToken cancellationToken) { }

	public void ReleasePlaybackResources() { }

	public void Restart() { }

	public bool StartPreparedPlayback() { }

	public void Stop() { }

	[AsyncStateMachine(typeof(<WarmupAsync>d__25))]
	public Task WarmupAsync(float timeout, CancellationToken cancellationToken) { }

}

