namespace EFT.UI.Ragfair;

public sealed class RagfairAvailabilityWarning : UIElement
{
	private const float UPDATE_INTERVAL = 1; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _textField; //Field offset: 0x70
	private RagFair _ragfair; //Field offset: 0x78
	private double _nextUpdate; //Field offset: 0x80

	public RagfairAvailabilityWarning() { }

	public virtual void Close() { }

	public void Show(RagFair ragFair) { }

	private void Update() { }

	private void UpdateText() { }

}

