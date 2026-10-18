//Type is in global namespace

public sealed class PooledBetterSourceHandle : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public BetterAudio betterAudio; //Field offset: 0x10
		public PooledBetterSourceHandle <>4__this; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal void <RequestRelease>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public BetterSource source; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal void <HandleNonPooledSourceRelease>g__DeactivateSource|0() { }

	}

	[CompilerGenerated]
	private BetterSource <Source>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ISourceReleaseListener <SourceListener>k__BackingField; //Field offset: 0x28
	public bool IsHotResident; //Field offset: 0x30
	public bool StopPending; //Field offset: 0x31
	public uint Generation; //Field offset: 0x34

	public private BetterSource Source
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private ISourceReleaseListener SourceListener
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public PooledBetterSourceHandle() { }

	private void Awake() { }

	[CompilerGenerated]
	public BetterSource get_Source() { }

	[CompilerGenerated]
	private ISourceReleaseListener get_SourceListener() { }

	private void HandleNonPooledSourceRelease(BetterSource source, float fadeSec) { }

	public void Init(BetterSource source, ISourceReleaseListener sourceListener = null) { }

	public void NotifyReleased() { }

	public void OnBorrow(bool needUpdate) { }

	private void OnDestroy() { }

	public void RequestRelease(float stopFadeSeconds) { }

	[CompilerGenerated]
	private void set_Source(BetterSource value) { }

	[CompilerGenerated]
	private void set_SourceListener(ISourceReleaseListener value) { }

	private void SourceReleaseRequestedHandler(BetterSource source) { }

}

