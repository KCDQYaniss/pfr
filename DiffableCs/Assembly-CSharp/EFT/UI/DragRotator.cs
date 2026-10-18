namespace EFT.UI;

[UsedImplicitly]
public sealed class DragRotator : UIElement, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
{
	[SerializeField]
	[UsedImplicitly]
	private Transform _target; //Field offset: 0x70
	[SerializeField]
	[UsedImplicitly]
	private int _horizontalSpeed; //Field offset: 0x78
	[SerializeField]
	[UsedImplicitly]
	private int _verticalSpeed; //Field offset: 0x7C
	private Graphic _graphic; //Field offset: 0x80
	private Vector2 _startPos; //Field offset: 0x88
	private Vector2 _lastRotation; //Field offset: 0x90
	private Vector2 _newRotation; //Field offset: 0x98

	public Vector2 Rotation
	{
		 set { } //Length: 15
	}

	public DragRotator() { }

	[UsedImplicitly]
	private void OnEnable() { }

	private void Rotate(Vector2 angle) { }

	public void set_Rotation(Vector2 value) { }

	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

}

