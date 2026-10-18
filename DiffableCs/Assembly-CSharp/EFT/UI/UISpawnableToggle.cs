namespace EFT.UI;

public class UISpawnableToggle : ButtonFeedback
{
	[SerializeField]
	private TextMeshProUGUI _headerLabel; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _sizeLabel; //Field offset: 0xB0
	[SerializeField]
	private Image _iconSprite; //Field offset: 0xB8
	[SerializeField]
	private bool _isBoldOnHover; //Field offset: 0xC0
	private GameObject HoverImage; //Field offset: 0xC8
	public AnimatedToggle Toggle; //Field offset: 0xD0
	private FontStyles _originalFontStyle; //Field offset: 0xD8

	public virtual bool Interactable
	{
		 get { } //Length: 8
		 set { } //Length: 63
	}

	internal bool IsToggled
	{
		internal get { } //Length: 33
		internal set { } //Length: 90
	}

	public UISpawnableToggle() { }

	[Obfuscation(Exclude = True)]
	public void Default() { }

	public virtual bool get_Interactable() { }

	internal bool get_IsToggled() { }

	[Obfuscation(Exclude = True)]
	public void Highlighted() { }

	internal void Init(ToggleGroup group) { }

	internal void InitSpawnableButton(string headerText, int headerSize, Sprite sprite, GameObject hoverImage) { }

	public virtual void set_Interactable(bool value) { }

	internal void set_IsToggled(bool value) { }

	internal void SetEllipsis(bool useEllipsis) { }

	internal void SetMinWidth(float minWidth) { }

}

