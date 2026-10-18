namespace EFT.UI;

public sealed class CutsceneSkipUI : UIElement
{
	private const string SINGLE_PLAYER_SKIP_TEXT = "Tutorial/SkipVideo"; //Field offset: 0x0
	private const string MULTIPLAYER_SKIP_TEXT_FORMAT = "{0}/{1} players want to skip"; //Field offset: 0x0
	[SerializeField]
	private Image _skipProgressFill; //Field offset: 0x70
	[SerializeField]
	private CanvasGroup _skipCanvas; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _skipButtonCanvas; //Field offset: 0x80
	[SerializeField]
	private TMP_Text _skipInfoLabel; //Field offset: 0x88
	[SerializeField]
	private float _timeToSkip; //Field offset: 0x90
	[SerializeField]
	private float _skipShowTime; //Field offset: 0x94
	[SerializeField]
	private float _backwardTimeMul; //Field offset: 0x98
	[SerializeField]
	private float _skipButtonAlpha; //Field offset: 0x9C
	private float _currentSkipTime; //Field offset: 0xA0
	private int _playersCount; //Field offset: 0xA4
	private int _remoteSkippingPlayersCount; //Field offset: 0xA8
	private bool _canSkip; //Field offset: 0xAC
	private bool _skipActive; //Field offset: 0xAD
	private bool _skipCompleted; //Field offset: 0xAE
	private bool _localSkipIntentionActive; //Field offset: 0xAF
	private Tween _skipShowTween; //Field offset: 0xB0
	private Tween _skipButtonShowTween; //Field offset: 0xB8
	[CompilerGenerated]
	private Action LocalSkipHoldCompleted; //Field offset: 0xC0
	[CompilerGenerated]
	private Action SkipRequested; //Field offset: 0xC8

	public event Action LocalSkipHoldCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action SkipRequested
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	private bool IsMultiplayer
	{
		private get { } //Length: 11
	}

	private int SkippingPlayersCount
	{
		private get { } //Length: 39
	}

	public CutsceneSkipUI() { }

	[CompilerGenerated]
	public void add_LocalSkipHoldCompleted(Action value) { }

	[CompilerGenerated]
	public void add_SkipRequested(Action value) { }

	private void Awake() { }

	public virtual void Close() { }

	private bool get_IsMultiplayer() { }

	private int get_SkippingPlayersCount() { }

	private void ProcessSkipInput() { }

	private void ProcessSkipRelease() { }

	private void RefreshSkipInfo() { }

	[CompilerGenerated]
	public void remove_LocalSkipHoldCompleted(Action value) { }

	[CompilerGenerated]
	public void remove_SkipRequested(Action value) { }

	private void ResetSkipProgress() { }

	public void SetCanSkip(bool canSkip) { }

	private void SetCanvasVisible(CanvasGroup canvasGroup, bool visible, bool instant, ref Tween tween, float targetAlpha) { }

	private void SetDefaultState() { }

	private void SetLocalSkipIntention(bool active) { }

	public void SetPlayersCount(int playersCount) { }

	private void SetProgress(float value) { }

	public void SetRemoteSkippingPlayersCount(int remoteSkippingPlayersCount) { }

	private void SetSkipButtonVisible(bool visible, bool instant) { }

	private void SetSkipPanelVisible(bool visible, bool instant) { }

	public void SetSkipState(int playersCount, int remoteSkippingPlayersCount) { }

	public void Show(int playersCount, bool canSkip = true) { }

	private void Update() { }

	private void ValidateSkipPanelVisibility() { }

}

