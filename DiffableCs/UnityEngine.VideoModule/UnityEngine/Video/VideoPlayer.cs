namespace UnityEngine.Video;

[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode]
public sealed class VideoPlayer : Behaviour
{
	internal sealed class ErrorEventHandler : MulticastDelegate
	{

		public ErrorEventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source, string message) { }

	}

	internal sealed class EventHandler : MulticastDelegate
	{

		public EventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source) { }

	}

	internal sealed class FrameReadyEventHandler : MulticastDelegate
	{

		public FrameReadyEventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source, long frameIdx) { }

	}

	internal sealed class TimeEventHandler : MulticastDelegate
	{

		public TimeEventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source, double seconds) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler prepareCompleted; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler loopPointReached; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler started; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler frameDropped; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ErrorEventHandler errorReceived; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler seekCompleted; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TimeEventHandler clockResyncOccurred; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FrameReadyEventHandler frameReady; //Field offset: 0x50

	public event ErrorEventHandler errorReceived
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event FrameReadyEventHandler frameReady
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event EventHandler loopPointReached
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event EventHandler prepareCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event EventHandler seekCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public bool canSetTime
	{
		[NativeName("CanSetTime")]
		 get { } //Length: 78
	}

	[NativeName("VideoClip")]
	public VideoClip clip
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	[NativeName("FramePosition")]
	public long frame
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public uint height
	{
		 get { } //Length: 78
	}

	[NativeName("Loop")]
	public bool isLooping
	{
		 set { } //Length: 93
	}

	public bool isPlaying
	{
		[NativeName("IsPlaying")]
		 get { } //Length: 78
	}

	public bool isPrepared
	{
		[NativeName("IsPrepared")]
		 get { } //Length: 78
	}

	[NativeName("Duration")]
	public double length
	{
		 get { } //Length: 78
	}

	public bool playOnAwake
	{
		 set { } //Length: 93
	}

	public VideoRenderMode renderMode
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public bool sendFrameReadyEvents
	{
		[NativeName("EnableFrameReadyEvents")]
		 set { } //Length: 93
	}

	public bool skipOnDrop
	{
		 set { } //Length: 93
	}

	public VideoSource source
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public string targetMaterialProperty
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	[NativeHeader("Runtime/Graphics/Renderer.h")]
	public Renderer targetMaterialRenderer
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	public RenderTexture targetTexture
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	[NativeName("SecPosition")]
	public double time
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	[NativeName("VideoUrl")]
	public string url
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public bool waitForFirstFrame
	{
		 set { } //Length: 93
	}

	public uint width
	{
		 get { } //Length: 78
	}

	[CompilerGenerated]
	public void add_errorReceived(ErrorEventHandler value) { }

	[CompilerGenerated]
	public void add_frameReady(FrameReadyEventHandler value) { }

	[CompilerGenerated]
	public void add_loopPointReached(EventHandler value) { }

	[CompilerGenerated]
	public void add_prepareCompleted(EventHandler value) { }

	[CompilerGenerated]
	public void add_seekCompleted(EventHandler value) { }

	[NativeName("CanSetTime")]
	public bool get_canSetTime() { }

	public VideoClip get_clip() { }

	public long get_frame() { }

	public uint get_height() { }

	[NativeName("IsPlaying")]
	public bool get_isPlaying() { }

	[NativeName("IsPrepared")]
	public bool get_isPrepared() { }

	public double get_length() { }

	public VideoRenderMode get_renderMode() { }

	public VideoSource get_source() { }

	public string get_targetMaterialProperty() { }

	public Renderer get_targetMaterialRenderer() { }

	public RenderTexture get_targetTexture() { }

	public double get_time() { }

	public string get_url() { }

	public uint get_width() { }

	[RequiredByNativeCode]
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

	[RequiredByNativeCode]
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCode]
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCode]
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	public void Pause() { }

	public void Play() { }

	public void Prepare() { }

	[CompilerGenerated]
	public void remove_errorReceived(ErrorEventHandler value) { }

	[CompilerGenerated]
	public void remove_frameReady(FrameReadyEventHandler value) { }

	[CompilerGenerated]
	public void remove_loopPointReached(EventHandler value) { }

	[CompilerGenerated]
	public void remove_prepareCompleted(EventHandler value) { }

	[CompilerGenerated]
	public void remove_seekCompleted(EventHandler value) { }

	public void set_clip(VideoClip value) { }

	public void set_frame(long value) { }

	public void set_isLooping(bool value) { }

	public void set_playOnAwake(bool value) { }

	public void set_renderMode(VideoRenderMode value) { }

	[NativeName("EnableFrameReadyEvents")]
	public void set_sendFrameReadyEvents(bool value) { }

	public void set_skipOnDrop(bool value) { }

	public void set_source(VideoSource value) { }

	public void set_targetMaterialProperty(string value) { }

	public void set_targetMaterialRenderer(Renderer value) { }

	public void set_targetTexture(RenderTexture value) { }

	public void set_time(double value) { }

	public void set_url(string value) { }

	public void set_waitForFirstFrame(bool value) { }

	public void Stop() { }

}

