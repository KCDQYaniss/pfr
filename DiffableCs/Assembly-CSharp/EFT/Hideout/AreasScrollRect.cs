namespace EFT.Hideout;

public class AreasScrollRect : ScrollRect
{
	private bool _resetDrag; //Field offset: 0x130
	public readonly UnityEvent OnStartDrag; //Field offset: 0x138

	public AreasScrollRect() { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	public void ResetDrag() { }

}

