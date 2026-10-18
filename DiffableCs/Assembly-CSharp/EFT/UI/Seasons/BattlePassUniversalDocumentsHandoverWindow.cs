namespace EFT.UI.Seasons;

public sealed class BattlePassUniversalDocumentsHandoverWindow : Window
{
	private const string TITLE = "UI/BattlePass/HandoverDocuments"; //Field offset: 0x0
	private const string MISSING_DOCUMENTS_DESCRIPTION = "UI/BattlePass/HandoverDocuments/MissingDescription"; //Field offset: 0x0
	private const string HANDOVER_DESCRIPTION = "UI/BattlePass/HandoverDocuments/ReplaceDescription"; //Field offset: 0x0
	private const string SHOP_DESCRIPTION = "UI/BattlePass/HandoverDocuments/ShopDescription"; //Field offset: 0x0
	private const string HANDOVER_BUTTON = "UI/BattlePass/HandoverDocuments/HandoverButton"; //Field offset: 0x0
	private const string SHOP_BUTTON = "UI/BattlePass/HandoverDocuments/ShopButton"; //Field offset: 0x0
	private const string OWNED_LABEL = "UI/BattlePass/HandoverDocuments/Owned"; //Field offset: 0x0
	[SerializeField]
	private BattlePassRewardHandoverItemListView _missingDocuments; //Field offset: 0xB8
	[SerializeField]
	private BattlePassUniversalItemView _universalDocument; //Field offset: 0xC0
	[SerializeField]
	private TMP_Text _missingDocumentsDescription; //Field offset: 0xC8
	[SerializeField]
	private TMP_Text _description; //Field offset: 0xD0
	[SerializeField]
	private DefaultUIButton _handoverButton; //Field offset: 0xD8
	[SerializeField]
	private DefaultUIButton _shopButton; //Field offset: 0xE0
	[SerializeField]
	private GameObject[] _handoverStateObjects; //Field offset: 0xE8
	[SerializeField]
	private GameObject[] _shopStateObjects; //Field offset: 0xF0

	protected virtual bool ShowOnTop
	{
		 get { } //Length: 3
	}

	public BattlePassUniversalDocumentsHandoverWindow() { }

	protected virtual bool get_ShowOnTop() { }

	private void Handover() { }

	private void OpenShop() { }

	private void SetState(EBattlePassUniversalDocumentsHandoverState state) { }

	public BattlePassUniversalDocumentsHandoverWindowContext Show(BattlePassRewardHandover handover, BattlePassController controller, IImageLoader imageLoader) { }

}

