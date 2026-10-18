namespace EFT.UI;

[UsedImplicitly]
public sealed class QuestRewardList : UIElement
{
	[SerializeField]
	private TMP_Text _title; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _info; //Field offset: 0x78
	[SerializeField]
	private ItemWideView _itemPrefab; //Field offset: 0x80
	[SerializeField]
	private StatView _statPrefab; //Field offset: 0x88
	[SerializeField]
	private CommonHorizontalRewardView _commonHorizontalRewardView; //Field offset: 0x90
	[SerializeField]
	private TraderRewardView _traderRewardView; //Field offset: 0x98
	[SerializeField]
	private StashRowsRewardView _stashRowsViewTemplate; //Field offset: 0xA0
	[SerializeField]
	private GameObject _unknownPrefab; //Field offset: 0xA8
	[SerializeField]
	private QuestRewardView _questRewardView; //Field offset: 0xB0
	[SerializeField]
	private CustomizationOfferRewardView _customizationOfferRewardView; //Field offset: 0xB8
	[SerializeField]
	private RectTransform _container; //Field offset: 0xC0

	public QuestRewardList() { }

	private void AddRewardView(QuestReward reward, bool showUnknown, bool isStartRewards) { }

	public void Init(string title, IEnumerable rewards, bool showUnknown, bool isStartRewards, string infoText = null) { }

	private void SetupHeader(string title, string infoText) { }

}

