namespace EFT.UI.Ragfair;

public sealed class MerchantInfoView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public RagFair ragfair; //Field offset: 0x10
		public MerchantInfoView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private struct <UpdateAvatar>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MerchantInfoView <>4__this; //Field offset: 0x20
		public string path; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateAvatar>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TraderInfo traderInfo; //Field offset: 0x20
		public MerchantInfoView <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image _avatar; //Field offset: 0x70
	[SerializeField]
	private GameObject _loader; //Field offset: 0x78
	[SerializeField]
	private Sprite _defaultAvatar; //Field offset: 0x80
	[SerializeField]
	private ChatSpecialIcon _specialIcon; //Field offset: 0x88
	[SerializeField]
	private RankPanel _rankPanel; //Field offset: 0x90
	[SerializeField]
	private GameObject _reputationIcon; //Field offset: 0x98
	[SerializeField]
	private GameObject _standingIcon; //Field offset: 0xA0
	[SerializeField]
	private TextMeshProUGUI _merchantName; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _merchantReputation; //Field offset: 0xB0
	[SerializeField]
	private GameObject _positiveReputation; //Field offset: 0xB8
	[SerializeField]
	private GameObject _negativeReputation; //Field offset: 0xC0

	private Color32 DefaultTextColor
	{
		private get { } //Length: 13
	}

	private Color32 NegativeTextColor
	{
		private get { } //Length: 13
	}

	public MerchantInfoView() { }

	private Color32 get_DefaultTextColor() { }

	private Color32 get_NegativeTextColor() { }

	private void SetAvatarLoaderVisibility(bool visible) { }

	public void SetExpandedStatus(bool status) { }

	private void SetRating(float rating, bool isRatingGrowing) { }

	public void Show(RagFair ragfair, Merchant merchant, bool isMyOffer) { }

	public void Show(TraderInfo traderInfo) { }

	[AsyncStateMachine(typeof(<UpdateAvatar>d__18))]
	private Task UpdateAvatar(string path) { }

	[AsyncStateMachine(typeof(<UpdateAvatar>d__19))]
	private Task UpdateAvatar(TraderInfo traderInfo) { }

}

