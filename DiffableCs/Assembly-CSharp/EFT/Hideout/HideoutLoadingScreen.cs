namespace EFT.Hideout;

public sealed class HideoutLoadingScreen : UIScreen
{
	[SerializeField]
	private float _rotationAngle; //Field offset: 0x90
	[SerializeField]
	private float _rotationSpeed; //Field offset: 0x94
	[SerializeField]
	private Image _hideoutImage; //Field offset: 0x98
	[SerializeField]
	private RectTransform _hideoutIcon; //Field offset: 0xA0
	[SerializeField]
	private Image _background; //Field offset: 0xA8
	[SerializeField]
	private Animation _hideoutLogoAnimation; //Field offset: 0xB0
	[SerializeField]
	private CanvasGroup _centerLogo; //Field offset: 0xB8
	[SerializeField]
	private CanvasGroup _topLeftLogo; //Field offset: 0xC0

	public HideoutLoadingScreen() { }

	[CompilerGenerated]
	private void <Close>b__11_0() { }

	public virtual void Close() { }

	public void LoadComplete() { }

	public void Show() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

