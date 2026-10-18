namespace EFT.UI;

public sealed class WishlistCategoryView : HandbookCategoryView
{
	[SerializeField]
	private Color _defaultBackgroundColor; //Field offset: 0x1A8
	[SerializeField]
	private Color _hoverBackgroundColor; //Field offset: 0x1B8

	protected virtual Color DefaultBackgroundColor
	{
		 get { } //Length: 14
	}

	protected virtual Color HoverBackgroundColor
	{
		 get { } //Length: 14
	}

	public WishlistCategoryView() { }

	protected virtual Color get_DefaultBackgroundColor() { }

	protected virtual Color get_HoverBackgroundColor() { }

}

