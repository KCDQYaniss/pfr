//Type is in global namespace

public class BPDocViewCrossOnSelect : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private GameObject _count; //Field offset: 0x20
	[SerializeField]
	private GameObject _cross; //Field offset: 0x28

	public BPDocViewCrossOnSelect() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void SetState(bool showCross, bool instant) { }

}

