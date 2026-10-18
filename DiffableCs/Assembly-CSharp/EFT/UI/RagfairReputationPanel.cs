namespace EFT.UI;

public sealed class RagfairReputationPanel : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _myRagfairRating; //Field offset: 0x70
	[SerializeField]
	private GameObject _positiveReputation; //Field offset: 0x78
	[SerializeField]
	private GameObject _negativeReputation; //Field offset: 0x80
	[SerializeField]
	private TextMeshProUGUI _myOffersCount; //Field offset: 0x88
	private RagFair _ragfair; //Field offset: 0x90
	private int _maxCount; //Field offset: 0x98

	public RagfairReputationPanel() { }

	public void UpdateMyOffersCount(EViewListType type) { }

	public void UpdateRagfairRating(float rating, bool isRatingGrowing, RagFair ragfair) { }

}

