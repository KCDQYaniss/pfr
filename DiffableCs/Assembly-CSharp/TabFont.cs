//Type is in global namespace

public class TabFont : Tab
{
	[SerializeField]
	private CustomTextMeshProUGUI _label; //Field offset: 0x90
	[SerializeField]
	private Color _defaultColor; //Field offset: 0x98
	[SerializeField]
	private Color _hoverColor; //Field offset: 0xA8
	[SerializeField]
	private FontStyle _defaultFont; //Field offset: 0xB8
	[SerializeField]
	private FontStyle _hoverFont; //Field offset: 0xBC

	public TabFont() { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

}

