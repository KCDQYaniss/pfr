namespace EFT.UI;

public sealed class ExpansionsHeroButton : HeroActionButton
{
	[SerializeField]
	private readonly Dictionary _stateData; //Field offset: 0x160
	[SerializeField]
	private GameObject _newFlag; //Field offset: 0x168
	[SerializeField]
	private GameObject _freeFlag; //Field offset: 0x170
	[SerializeField]
	private GameObject _saleFlag; //Field offset: 0x178
	[SerializeField]
	private GameObject _maintenanceFlag; //Field offset: 0x180
	[SerializeField]
	private string _disabledTooltipText; //Field offset: 0x188
	private ExpansionsPlayerInfo _expansionsInfo; //Field offset: 0x190
	private Action _unsubscribeDataUpdated; //Field offset: 0x198

	public virtual bool Interactable
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	protected virtual Dictionary StateData
	{
		 get { } //Length: 8
	}

	public ExpansionsHeroButton() { }

	[CompilerGenerated]
	private void <Show>b__13_0() { }

	private void ApplyState(bool isAvailable, bool hoverState, bool forced) { }

	public virtual void Close() { }

	public virtual bool get_Interactable() { }

	protected virtual Dictionary get_StateData() { }

	protected virtual string GetDescriptionText() { }

	private int GetFreeOffersCount() { }

	private int GetNewOffersCount() { }

	private int GetSaleOffersCount() { }

	private int GetTarcoinsCount() { }

	private void OnExpansionsDataUpdated() { }

	private void Refresh() { }

	public virtual void set_Interactable(bool value) { }

	private void SetNotificationFlags(bool isAvailable) { }

	public void Show(ExpansionsPlayerInfo expansionsInfo) { }

}

