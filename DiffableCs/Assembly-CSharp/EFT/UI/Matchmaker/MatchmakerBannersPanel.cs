namespace EFT.UI.Matchmaker;

public sealed class MatchmakerBannersPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public BannerPageToggle bannerToggle; //Field offset: 0x10
		public MatchmakerBannersPanel <>4__this; //Field offset: 0x18
		public BannerWithToggle currentBanner; //Field offset: 0x20

		public <>c__DisplayClass23_0() { }

		internal void <CreateBanner>b__0() { }

		internal void <CreateBanner>g__BannerToggleClickHandler|1(bool visible) { }

	}

	[CompilerGenerated]
	private struct <Show>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerBannersPanel <>4__this; //Field offset: 0x20
		public Location location; //Field offset: 0x28
		public ProfileStats stats; //Field offset: 0x30
		public ESideType side; //Field offset: 0x38
		public IImageLoader textureLoader; //Field offset: 0x40
		private CancellationToken <token>5__2; //Field offset: 0x48
		private LocationBanner[] <>7__wrap2; //Field offset: 0x50
		private int <>7__wrap3; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryCreateBanner>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken token; //Field offset: 0x20
		public LocationBanner banner; //Field offset: 0x28
		public IImageLoader textureLoader; //Field offset: 0x30
		public MatchmakerBannersPanel <>4__this; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float BANNER_SWITCH_TIME = 10; //Field offset: 0x0
	public KeyBannerGenerator KeyBannerGenerator; //Field offset: 0x70
	[SerializeField]
	private ToggleGroup _toggleGroup; //Field offset: 0x78
	[SerializeField]
	private MatchmakerBanner _bannerImageTemplate; //Field offset: 0x80
	[SerializeField]
	private BannerPageToggle _bannerPageTemplate; //Field offset: 0x88
	[SerializeField]
	private Sprite _savageSprite; //Field offset: 0x90
	[SerializeField]
	private CustomTextMeshProUGUI _bannerHeader; //Field offset: 0x98
	[SerializeField]
	private CustomTextMeshProUGUI _bannerDescription; //Field offset: 0xA0
	[SerializeField]
	private RectTransform _bannerPagesPlaceholder; //Field offset: 0xA8
	[SerializeField]
	private RectTransform _bannerImagesPlaceholder; //Field offset: 0xB0
	private readonly List _locationBanners; //Field offset: 0xB8
	private readonly Queue _bannerPool; //Field offset: 0xC0
	private readonly Queue _togglePool; //Field offset: 0xC8
	private KeyBindingBannerView _keyBindingView; //Field offset: 0xD0
	private bool _stopSwitch; //Field offset: 0xD8
	private double _time; //Field offset: 0xE0
	private int _currentSelectedBanner; //Field offset: 0xE8
	private bool _skipFirstDone; //Field offset: 0xEC

	private int NextIndex
	{
		private get { } //Length: 91
	}

	public MatchmakerBannersPanel() { }

	private void AddKeyBindingBanner() { }

	private void AddSavageBanner() { }

	public virtual void Close() { }

	private BannerWithToggle CreateBanner(string bannerName, string description, Sprite sprite) { }

	private void DetachKeyBindingView(MatchmakerBanner banner) { }

	private int get_NextIndex() { }

	private MatchmakerBanner GetBanner() { }

	private BannerPageToggle GetToggle() { }

	private void ReturnAllToPool() { }

	private void ReturnToPool(BannerWithToggle bannerWithToggle) { }

	private void SelectBanner(BannerWithToggle bannerWithToggle, bool visible) { }

	[AsyncStateMachine(typeof(<Show>d__21))]
	public Task Show(Location location, ESideType side, ProfileStats stats, IImageLoader textureLoader) { }

	[AsyncStateMachine(typeof(<TryCreateBanner>d__22))]
	private Task TryCreateBanner(LocationBanner banner, IImageLoader textureLoader, CancellationToken token) { }

	private void Update() { }

}

