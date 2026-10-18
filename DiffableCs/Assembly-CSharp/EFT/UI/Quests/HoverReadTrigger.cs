namespace EFT.UI.Quests;

public sealed class HoverReadTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private const float HOVER_READ_DELAY_SECONDS = 0.1; //Field offset: 0x0
	private readonly BindableEvent _onRead; //Field offset: 0x20
	private Nullable _hoverStartTime; //Field offset: 0x28

	public IBindableEvent OnRead
	{
		 get { } //Length: 5
	}

	public HoverReadTrigger() { }

	public IBindableEvent get_OnRead() { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	private void Update() { }

}

