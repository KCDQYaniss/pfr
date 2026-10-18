namespace EFT.UI.Matchmaker;

public sealed class FriendPinClickHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public Action Clicked; //Field offset: 0x20

	public FriendPinClickHandler() { }

	public override void OnPointerClick(PointerEventData eventData) { }

}

