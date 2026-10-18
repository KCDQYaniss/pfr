namespace EFT.UI;

public sealed class BattleUiVoipPanel : UIElement
{
	private sealed class BanContainer
	{
		public CanvasGroup Group; //Field offset: 0x10
		public CustomTextMeshProUGUI LeftTimeText; //Field offset: 0x18

		public BanContainer() { }

		public void Hide() { }

		public void Show() { }

	}

	private sealed class StatusContainer
	{
		public CanvasGroup Group; //Field offset: 0x10
		public CustomTextMeshProUGUI LeftTimeText; //Field offset: 0x18
		public Image StaticImage; //Field offset: 0x20
		public Sprite BlockedSprite; //Field offset: 0x28
		public Sprite BannedSprite; //Field offset: 0x30
		public Sprite TalkDetectedSprite; //Field offset: 0x38
		public Image[] TalkingStates; //Field offset: 0x40
		public float TweenDuration; //Field offset: 0x48
		public Ease TweenEase; //Field offset: 0x4C
		private Sequence _talkingAnimation; //Field offset: 0x50
		private Action _talkDetectionBinding; //Field offset: 0x58

		public StatusContainer() { }

		public void Clear() { }

		private Sequence GetTalkingAnimation() { }

		public void Hide(float duration = -1) { }

		private void HideTalking() { }

		private void PlayTalkDetectedAnimation(bool detected) { }

		public void ShowBan() { }

		public void ShowBlock(float duration) { }

		private void ShowStaticImage(Sprite sprite, float duration = -1) { }

		public void StartTalkDetection(IPlayerVoipController controller) { }

		public void StartTalkingAnimation(float duration) { }

	}

	[SerializeField]
	private StatusContainer _status; //Field offset: 0x70
	[SerializeField]
	private BanContainer _ban; //Field offset: 0x78
	public float ShowHideDuration; //Field offset: 0x80
	private IPlayerVoipController _controller; //Field offset: 0x88
	private int _cachedSeconds; //Field offset: 0x90

	public BattleUiVoipPanel() { }

	public virtual void Close() { }

	private void RefreshTime(bool force) { }

	private void SetStatus(EVoipControllerStatus status) { }

	public void Show(IPlayerVoipController controller) { }

	private void Update() { }

}

