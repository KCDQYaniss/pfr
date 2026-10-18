namespace EFT.UI.Gestures;

public sealed class GesturesBindPanel : UIElement
{
	[SerializeField]
	private GesturesQuickPanel _gesturesQuickPanel; //Field offset: 0x70
	[SerializeField]
	private GesturesBindItem _leftTemplate; //Field offset: 0x78
	[SerializeField]
	private GesturesBindItem _rightTemplate; //Field offset: 0x80
	[SerializeField]
	private RectTransform _leftContainer; //Field offset: 0x88
	[SerializeField]
	private RectTransform _rightContainer; //Field offset: 0x90
	public readonly BindableEvent OnItemSelected; //Field offset: 0x98
	private readonly List _bindItems; //Field offset: 0xA0

	public IReadOnlyList Items
	{
		 get { } //Length: 8
	}

	public GesturesBindPanel() { }

	private void Awake() { }

	private void ClearBindItems() { }

	public virtual void Close() { }

	public IReadOnlyList get_Items() { }

	private void ItemClickedHandler(PointerClick click) { }

	public void Show(GestureCommands binds, ColorMap colorMap, HashSet availablePhrases) { }

}

