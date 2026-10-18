namespace Vuplex.WebView;

[HelpURL("https://developer.vuplex.com/webview/IPointerInputDetector")]
public class CanvasPointerInputDetector : DefaultPointerInputDetector
{
	private RectTransform _cachedRectTransform; //Field offset: 0x80
	private CachingGetter _canvasGetter; //Field offset: 0x88

	protected virtual Vector2 _convertToNormalizedPoint(PointerEventData pointerEventData) { }

	protected virtual Vector2 _convertToNormalizedPoint(Vector3 worldPosition) { }

	private Vector2 _convertVector2ToNormalizedPoint(Vector2 localPoint) { }

	private RectTransform _getRectTransform() { }

	protected virtual bool _positionIsZero(PointerEventData eventData) { }

	public CanvasPointerInputDetector() { }

	private void Start() { }

}

