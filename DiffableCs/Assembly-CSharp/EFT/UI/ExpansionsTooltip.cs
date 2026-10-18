namespace EFT.UI;

public sealed class ExpansionsTooltip : UIElement
{
	[SerializeField]
	private MultiLineTooltip _tooltip; //Field offset: 0x70
	[SerializeField]
	private Sprite _activeHeaderIcon; //Field offset: 0x78
	[SerializeField]
	private Sprite _inactiveHeaderIcon; //Field offset: 0x80
	[SerializeField]
	private Color _activeHeaderColor; //Field offset: 0x88
	[SerializeField]
	private Color _inactiveHeaderColor; //Field offset: 0x98

	public bool Displayed
	{
		 get { } //Length: 30
	}

	public ExpansionsTooltip() { }

	public virtual void Close() { }

	public bool get_Displayed() { }

	public void Show(EExpansionsTooltipState state, MultiLineInfo multiLineInfo, Vector2 offset = null) { }

}

