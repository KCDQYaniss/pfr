namespace EFT.UI;

public sealed class SeasonalCommonPerksState : EftScreenState
{
	[CompilerGenerated]
	private struct <HideState>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonalCommonPerksState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowState>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonalCommonPerksState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string COMMON_SCREEN_TITLE = "Perks/Season/Common/Title"; //Field offset: 0x0
	private const string COMMON_SCREEN_DESCRIPTION = "Perks/Season/Common/Description"; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _title; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0x98
	[SerializeField]
	private SeasonalCommonPerkView _perkTemplate; //Field offset: 0xA0
	[SerializeField]
	private Transform _perksContainer; //Field offset: 0xA8
	[SerializeField]
	private StreamingVideoPlayer _videoPlayer; //Field offset: 0xB0
	private readonly List _perkViews; //Field offset: 0xB8
	private IEnumerable _commonPerks; //Field offset: 0xC0
	private IImageLoader _imageLoader; //Field offset: 0xC8

	public SeasonalCommonPerksState() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__1() { }

	private void EnsureViewsCount(int count) { }

	[AsyncStateMachine(typeof(<HideState>d__12))]
	public virtual Task HideState() { }

	public void Init(IImageLoader imageLoader) { }

	private void RefreshTextsAndViews() { }

	[AsyncStateMachine(typeof(<ShowState>d__11))]
	public virtual Task ShowState() { }

}

