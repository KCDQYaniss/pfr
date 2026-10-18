namespace EFT.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public sealed class ClickableUIText : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
	[SerializeField]
	private TextMeshProUGUI _textMessage; //Field offset: 0x20
	private ECursorType _previousCursorState; //Field offset: 0x28
	private Action _onLinkClicked; //Field offset: 0x30
	private Action _onMouseClicked; //Field offset: 0x38

	public ClickableUIText() { }

	private string ClickableLink(PointerEventData eventData) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public void SetText(string message, Action onMouseClicked = null, Action onLinkClicked = null) { }

}

