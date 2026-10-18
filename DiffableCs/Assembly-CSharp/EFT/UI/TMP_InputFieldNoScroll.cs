namespace EFT.UI;

public class TMP_InputFieldNoScroll : TMP_InputField
{
	private Action _onScroll; //Field offset: 0x2F8

	public TMP_InputFieldNoScroll() { }

	public virtual void OnScroll(PointerEventData eventData) { }

	public void Show(Action onScroll) { }

}

