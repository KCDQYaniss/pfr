namespace UI.InfoWindow;

public sealed class StretchWindow : UIElement
{
	[SerializeField]
	private Vector2 _maxSize; //Field offset: 0x70
	[SerializeField]
	private LayoutElement _stretchableObject; //Field offset: 0x78
	[SerializeField]
	private RectTransform _rootTransform; //Field offset: 0x80
	[SerializeField]
	private Dictionary _stretchAreas; //Field offset: 0x88
	private Nullable _forcedCursor; //Field offset: 0x90
	private Nullable _regularCursor; //Field offset: 0x98

	public StretchWindow() { }

	private void CursorChangeHandler(Nullable cursor) { }

	private void ForcedCursorChangeHandler(Nullable cursor) { }

	private void OnDestroy() { }

	private void OnValidate() { }

	private void Start() { }

	private void UpdateCursor() { }

}

