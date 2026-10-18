namespace EFT.UI.Matchmaker;

public sealed class MatchmakerBanner : UIElement
{
	private const float SWITCH_SPEED = 2; //Field offset: 0x0
	[SerializeField]
	private Image _bannerImage; //Field offset: 0x70
	[SerializeField]
	private CanvasGroup _imageCanvasGroup; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _bannerCanvasGroup; //Field offset: 0x80
	[HideInInspector]
	public string BannerName; //Field offset: 0x88
	[HideInInspector]
	public string BannerDescription; //Field offset: 0x90
	private bool _isVisible; //Field offset: 0x98
	private Coroutine _showCoroutine; //Field offset: 0xA0

	public Transform BannerImageTransform
	{
		 get { } //Length: 29
	}

	public MatchmakerBanner() { }

	[CompilerGenerated]
	private void <SetSelected>b__11_0() { }

	public virtual void Close() { }

	public Transform get_BannerImageTransform() { }

	public void Init(string bannerName, string description, Sprite sprite) { }

	private void ResetForPool() { }

	public void SetSelected(bool value) { }

}

