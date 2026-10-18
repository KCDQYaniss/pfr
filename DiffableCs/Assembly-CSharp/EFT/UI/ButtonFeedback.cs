namespace EFT.UI;

public class ButtonFeedback : InteractableElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
	[SerializeField]
	private bool _onPointerEnterSound; //Field offset: 0x98
	[SerializeField]
	private EUISoundType _hoverSound; //Field offset: 0x9C
	[SerializeField]
	protected bool _onPointerClickSound; //Field offset: 0xA0
	[SerializeField]
	protected EUISoundType _clickSound; //Field offset: 0xA4

	public ButtonFeedback() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	protected override void PlayPointerClickSound() { }

	protected override void PointerEnterHandler(PointerEventData eventData) { }

	protected override void PointerEnterHandler() { }

	protected override void PointerExitHandler(PointerEventData eventData) { }

	protected override void PointerExitHandler() { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

