//Type is in global namespace

[UsedImplicitly]
public sealed class PointerEventsProxy : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private readonly BindableEvent _onPointerEnter; //Field offset: 0x20
	private readonly BindableEvent _onPointerExit; //Field offset: 0x28

	public IBindableEvent OnPointerEnter
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnPointerExit
	{
		 get { } //Length: 5
	}

	public PointerEventsProxy() { }

	public IBindableEvent get_OnPointerEnter() { }

	public IBindableEvent get_OnPointerExit() { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

