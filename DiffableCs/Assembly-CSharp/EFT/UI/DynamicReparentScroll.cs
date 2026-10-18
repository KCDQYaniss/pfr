namespace EFT.UI;

public class DynamicReparentScroll : DynamicScroll
{
	[SerializeField]
	private RectTransform _temporaryContainer; //Field offset: 0x60
	[SerializeField]
	private RectTransform _originalContainer; //Field offset: 0x68

	public DynamicReparentScroll() { }

	protected virtual void Disable(DynamicScrollElement scrollElement, EArrangement arrangement) { }

	protected virtual void Enable(DynamicScrollElement scrollElement, EArrangement arrangement) { }

}

