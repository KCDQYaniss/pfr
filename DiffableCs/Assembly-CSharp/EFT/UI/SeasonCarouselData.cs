namespace EFT.UI;

[CreateAssetMenu(fileName = "SeasonCarouselData", menuName = "EFT/Seasons/Carousel Data")]
public sealed class SeasonCarouselData : ScriptableObject
{
	[SerializeField]
	private List _pages; //Field offset: 0x18

	public IReadOnlyList Pages
	{
		 get { } //Length: 5
	}

	public SeasonCarouselData() { }

	public IReadOnlyList get_Pages() { }

}

