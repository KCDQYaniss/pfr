namespace AchievementsSystem;

public sealed class AchievementIconView : UIElement
{
	[CompilerGenerated]
	private struct <LoadIconSprite>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AchievementTemplate template; //Field offset: 0x20
		public IImageLoader session; //Field offset: 0x28
		public AchievementIconView <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Sprite _commonIconBorder; //Field offset: 0x70
	[SerializeField]
	private Sprite _rareIconBorder; //Field offset: 0x78
	[SerializeField]
	private Sprite _legendaryIconBorder; //Field offset: 0x80
	[SerializeField]
	private Sprite _seasonalIconBorder; //Field offset: 0x88
	[SerializeField]
	private Sprite _commonIconBackground; //Field offset: 0x90
	[SerializeField]
	private Sprite _rareIconBackground; //Field offset: 0x98
	[SerializeField]
	private Sprite _legendaryIconBackground; //Field offset: 0xA0
	[SerializeField]
	private Sprite _seasonalIconBackground; //Field offset: 0xA8
	[SerializeField]
	private HoverTrigger _iconHoverTrigger; //Field offset: 0xB0
	[SerializeField]
	private Image _iconImage; //Field offset: 0xB8
	[SerializeField]
	private Image _iconBorder; //Field offset: 0xC0
	[SerializeField]
	private Image _iconBackground; //Field offset: 0xC8
	[SerializeField]
	private CanvasGroup _iconCanvasGroup; //Field offset: 0xD0
	[SerializeField]
	[Space]
	private float _notCompletedAlpha; //Field offset: 0xD8

	public AchievementIconView() { }

	[AsyncStateMachine(typeof(<LoadIconSprite>d__16))]
	private Task LoadIconSprite(AchievementTemplate template, IImageLoader session) { }

	private void SetupImages(bool unlocked, AchievementTemplate template, IImageLoader session) { }

	public void Show(bool unlocked, AchievementTemplate template, IImageLoader session, Action onHoverStart = null, Action onHoverEnd = null) { }

}

