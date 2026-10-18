namespace EFT.UI;

public sealed class ClickTrigger : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private Action _onClick; //Field offset: 0x20

	public ClickTrigger() { }

	public void Init(Action onClick) { }

	public override void OnPointerClick(PointerEventData eventData) { }

}

