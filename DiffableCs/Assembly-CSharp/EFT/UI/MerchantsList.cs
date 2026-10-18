namespace EFT.UI;

public sealed class MerchantsList : UIScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Trader trader; //Field offset: 0x10
		public MerchantsList <>4__this; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal void <Show>b__1() { }

	}

	[SerializeField]
	private RectTransform _tradersContainer; //Field offset: 0x90
	[SerializeField]
	private TraderTooltip _tooltip; //Field offset: 0x98
	[SerializeField]
	private TraderPanel _traderPanelTemplate; //Field offset: 0xA0
	private Trader _currentTrader; //Field offset: 0xA8
	private QuestController _questController; //Field offset: 0xB0
	private AchievementsController _achievementsController; //Field offset: 0xB8
	private InventoryController _inventoryController; //Field offset: 0xC0
	private IHealthController _healthController; //Field offset: 0xC8
	private Profile _profile; //Field offset: 0xD0
	private IEftSession _session; //Field offset: 0xD8
	private List _tradersList; //Field offset: 0xE0
	[CompilerGenerated]
	private Action TraderSelectedEvent; //Field offset: 0xE8

	public event Action TraderSelectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public MerchantsList() { }

	[CompilerGenerated]
	private void <Show>b__14_0(Trader trader, TraderPanel traderPanel) { }

	[CompilerGenerated]
	public void add_TraderSelectedEvent(Action value) { }

	public virtual void Close() { }

	[CompilerGenerated]
	public void remove_TraderSelectedEvent(Action value) { }

	public void Show(IEnumerable tradersList, QuestController questController, AchievementsController achievementsController, InventoryController inventoryController, IHealthController healthController, IEftSession session, Profile profile) { }

	private void ShowTrader(Trader trader) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

