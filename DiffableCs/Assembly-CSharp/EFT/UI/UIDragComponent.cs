namespace EFT.UI;

[RequireComponent(typeof(Graphic))]
[RequireComponent(typeof(RectTransform))]
public sealed class UIDragComponent : UIBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler
{
	[SerializeField]
	private RectTransform _target; //Field offset: 0x20
	[SerializeField]
	private bool _putOnTop; //Field offset: 0x28
	private Vector2 _startDelta; //Field offset: 0x2C

	public UIDragComponent() { }

	protected virtual void Awake() { }

	private bool CheckTarget(bool showError = false) { }

	public void Init(RectTransform target, bool putOnTop) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private void ScreenSizeUpdateHandler() { }

	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

}

