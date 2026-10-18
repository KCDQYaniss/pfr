namespace EFT.UI;

public sealed class SeasonsSeasonInfoTab : UIElement
{
	internal sealed class SeasonsSeasonInfoTabController : UIElementTabController
	{
		private readonly SeasonsHubScreenController _context; //Field offset: 0x18

		public SeasonsSeasonInfoTabController(SeasonsSeasonInfoTab content, SeasonsHubScreenController context) { }

		public virtual void Show() { }

	}

	[SerializeField]
	private CarouselView _carousel; //Field offset: 0x70
	[SerializeField]
	private SeasonCarouselData _carouselData; //Field offset: 0x78
	[SerializeField]
	private SeasonalModifiersList _modifiersList; //Field offset: 0x80

	public SeasonsSeasonInfoTab() { }

	public virtual void Close() { }

	private void Show(SeasonsHubScreenController context) { }

}

