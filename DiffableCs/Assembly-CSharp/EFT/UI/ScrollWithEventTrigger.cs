namespace EFT.UI;

public sealed class ScrollWithEventTrigger : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	[SerializeField]
	private ScrollRect scrollRect; //Field offset: 0x20
	[SerializeField]
	private float scrollSensitivity; //Field offset: 0x28

	public ScrollWithEventTrigger() { }

	public override void OnScroll(PointerEventData eventData) { }

}

