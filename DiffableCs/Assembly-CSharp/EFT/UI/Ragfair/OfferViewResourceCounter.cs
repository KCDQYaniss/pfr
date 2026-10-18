namespace EFT.UI.Ragfair;

public sealed class OfferViewResourceCounter : UIElement
{
	[SerializeField]
	private Image _resourceIcon; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _resourceCount; //Field offset: 0x78
	[SerializeField]
	private PointerEventsProxy _pointerEventsProxy; //Field offset: 0x80

	public OfferViewResourceCounter() { }

	public void Show(Sprite icon, string resource, out PointerEventsProxy pointerEventsProxy) { }

}

