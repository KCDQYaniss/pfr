namespace EFT.UI;

public class ItemIconView : UIElement
{
	[SerializeField]
	private Image _mainImage; //Field offset: 0x70
	[SerializeField]
	private GameObject _iconLoader; //Field offset: 0x78
	[SerializeField]
	private Vector3 _iconRotation; //Field offset: 0x80
	[SerializeField]
	private RectTransform _mainRect; //Field offset: 0x90
	private Action _onHover; //Field offset: 0x98
	protected ItemIcon ItemIcon; //Field offset: 0xA0

	protected GameObject IconLoader
	{
		 get { } //Length: 5
	}

	protected Image MainImage
	{
		 get { } //Length: 5
	}

	public ItemIconView() { }

	[CompilerGenerated]
	private void <Awake>b__10_0(PointerEventData eventData) { }

	private void Awake() { }

	protected GameObject get_IconLoader() { }

	protected Image get_MainImage() { }

	protected override void OnHoverEnd(PointerEventData eventData) { }

	private void OnIconChanged() { }

	public void Show(Item item, Action onHover, Sprite emptyIconSprite = null) { }

	private void ShowEmptySprite(Sprite emptySprite) { }

	protected override void UpdateScale() { }

}

