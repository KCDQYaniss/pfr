namespace EFT.UI;

[UsedImplicitly]
public sealed class OutsideClickDetector : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private bool _hover; //Field offset: 0x20
	private readonly BindableEvent _onOutsideClick; //Field offset: 0x28

	public IBindableEvent OnOutsideClick
	{
		 get { } //Length: 5
	}

	public OutsideClickDetector() { }

	public IBindableEvent get_OnOutsideClick() { }

	[UsedImplicitly]
	private void OnApplicationFocus(bool hasFocus) { }

	[UsedImplicitly]
	private void OnDisable() { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	[UsedImplicitly]
	private void Update() { }

}

