namespace EFT.UI;

public class SeasonsRanksTab : UIInputNode
{
	internal sealed class SeasonsRanksTabController : UIElementTabController
	{
		private readonly SeasonsHubScreenController _context; //Field offset: 0x18

		public SeasonsRanksTabController(SeasonsRanksTab content, SeasonsHubScreenController context) { }

		public virtual void Show() { }

	}

	[SerializeField]
	private SeasonsRanksSelector _selector; //Field offset: 0x80
	[SerializeField]
	private SeasonRankRewardPageView _rewards; //Field offset: 0x88
	[SerializeField]
	private GameObject _rewardsClaimedObject; //Field offset: 0x90
	[SerializeField]
	private GameObject _rewardsNotClaimedObject; //Field offset: 0x98
	[SerializeField]
	private GameObject _noRewardsObject; //Field offset: 0xA0
	private IEftSession _session; //Field offset: 0xA8
	private int _maxRank; //Field offset: 0xB0
	private List _rewardsData; //Field offset: 0xB8
	private SeasonsLeaguesTabContext _context; //Field offset: 0xC0

	public SeasonsRanksTab() { }

	private void RankSelectedHandler(int rank) { }

	public void Show(SeasonsHubScreenController context) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

