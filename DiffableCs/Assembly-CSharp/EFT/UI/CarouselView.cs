namespace EFT.UI;

public sealed class CarouselView : UIElement
{
	private enum EAnimationType
	{
		None = 0,
		Fade = 1,
	}

	internal sealed class PageData
	{
		[SerializeField]
		[TextArea(3, 10)]
		private string _text; //Field offset: 0x10
		[SerializeField]
		private Sprite _background; //Field offset: 0x18

		public Sprite Background
		{
			 get { } //Length: 5
		}

		public string TextLocalized
		{
			 get { } //Length: 117
		}

		public PageData() { }

		public Sprite get_Background() { }

		public string get_TextLocalized() { }

	}

	[Header("Active page")]
	[SerializeField]
	private CanvasGroup _activePageCanvasGroup; //Field offset: 0x70
	[SerializeField]
	private Image _activeBackground; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _body; //Field offset: 0x80
	[Header("Incoming page")]
	[SerializeField]
	private CanvasGroup _incomingPageCanvasGroup; //Field offset: 0x88
	[SerializeField]
	private Image _incomingBackground; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _incomingBody; //Field offset: 0x98
	[Header("Controls")]
	[SerializeField]
	private TextMeshProUGUI _pageCounter; //Field offset: 0xA0
	[SerializeField]
	private Button _previousPageButton; //Field offset: 0xA8
	[SerializeField]
	private Button _nextPageButton; //Field offset: 0xB0
	[SerializeField]
	private ButtonShortcutInputNode _previousPageShortcut; //Field offset: 0xB8
	[SerializeField]
	private ButtonShortcutInputNode _nextPageShortcut; //Field offset: 0xC0
	[SerializeField]
	private bool _loop; //Field offset: 0xC8
	[Header("Animation")]
	[SerializeField]
	private EAnimationType _animationType; //Field offset: 0xC9
	[SerializeField]
	private float _switchDuration; //Field offset: 0xCC
	[SerializeField]
	private Ease _switchEase; //Field offset: 0xD0
	private IReadOnlyList _pages; //Field offset: 0xD8
	private Tween _switchTween; //Field offset: 0xE0
	private int _currentPageIndex; //Field offset: 0xE8
	private bool _navigationLocked; //Field offset: 0xEC
	private Sprite _defaultActiveBackground; //Field offset: 0xF0
	private Sprite _defaultIncomingBackground; //Field offset: 0xF8

	public CarouselView() { }

	private void AnimateFadeSwitch() { }

	private static void ApplyBackground(Image image, Sprite fallback, PageData page) { }

	private void ApplyImmediateState() { }

	private void BindNavigation() { }

	public virtual void Close() { }

	private void CompleteSwitchAnimation() { }

	private void KillSwitchTween() { }

	private void PrepareAnimatedSwitch() { }

	private void ResetTextLayers() { }

	private void SetButtonsInteractable(bool interactable) { }

	public void Show(IReadOnlyList pages) { }

	private void ShowNextPage() { }

	private void ShowPage(int pageIndex, int direction, bool immediate) { }

	private void ShowPreviousPage() { }

	private void UpdateNavigationState() { }

	private void UpdatePageCounter() { }

}

