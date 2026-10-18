namespace EFT.UI;

public class StretchArea : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Flags]
	internal enum EStretchAreaType
	{
		Top = 1,
		Bottom = 2,
		Left = 4,
		Right = 8,
		TopLeft = 5,
		TopRight = 9,
		BottomLeft = 6,
		BottomRight = 10,
	}

	public readonly BindableEvent OnCursorChange; //Field offset: 0x20
	public readonly BindableEvent OnForcedCursorChange; //Field offset: 0x28
	private EStretchAreaType _areaType; //Field offset: 0x30
	private LayoutElement _stretchableObject; //Field offset: 0x38
	private RectTransform _rootTransform; //Field offset: 0x40
	private RectTransform _stretchableTransform; //Field offset: 0x48
	private Vector2 _maxSize; //Field offset: 0x50
	private ECursorType _cursor; //Field offset: 0x58
	private ECursorType _previousCursor; //Field offset: 0x5C
	private bool _horizontal; //Field offset: 0x60
	private bool _vertical; //Field offset: 0x61
	private Vector2 _multiplier; //Field offset: 0x64
	private Vector2 _pivot; //Field offset: 0x6C
	private Vector2 _lastPosition; //Field offset: 0x74

	public StretchArea() { }

	public void Init(EStretchAreaType areaType, RectTransform rootTransform, LayoutElement stretchableObject, Vector2 maxSize) { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

}

