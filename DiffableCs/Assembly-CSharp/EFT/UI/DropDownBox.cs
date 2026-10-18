namespace EFT.UI;

[UsedImplicitly]
public class DropDownBox : BaseDropDownBox, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler
{
	[SerializeField]
	private TextMeshProUGUI _currentValueText; //Field offset: 0xF0
	[SerializeField]
	private Button _button; //Field offset: 0xF8
	[SerializeField]
	private Image _background; //Field offset: 0x100
	[SerializeField]
	private Color _highlightedColor; //Field offset: 0x108
	[SerializeField]
	private LayoutElement _scrollRectLayoutElement; //Field offset: 0x118
	[SerializeField]
	private RectTransform _scrollBar; //Field offset: 0x120
	[SerializeField]
	private Image _buttonOpen; //Field offset: 0x128
	[SerializeField]
	private Image _buttonClosed; //Field offset: 0x130
	[SerializeField]
	private float _maxVisibleHeight; //Field offset: 0x138
	private Vector3 _currentPosition; //Field offset: 0x13C
	private RectTransform _overlayLayer; //Field offset: 0x148
	private readonly Color _defaultColor; //Field offset: 0x150

	public DropDownBox() { }

	[CompilerGenerated]
	private void <Show>b__12_0() { }

	protected virtual void HoverDropDownEventHandler(bool value) { }

	protected virtual void OnMenuStateChanged(bool open) { }

	protected override void PointerDownHandler() { }

	public void SetAsSpecific(bool value) { }

	protected virtual void SetPanelState(bool open) { }

	public virtual void SetSpriteAsset(TMP_SpriteAsset asset) { }

	protected virtual void SetTextInternal(string text) { }

	public virtual void Show(IEnumerable values, Func validator = null) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	protected virtual void Update() { }

	private void UpdateDirection() { }

	private void UpdateOpenPanelLayout() { }

}

