namespace EFT.UI;

public interface IBattleUIScreenController
{

	public event Action OnClose
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnShow
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool AllowHealthPanel
	{
		 get { } //Length: 0
	}

	public bool AllowQuickPanel
	{
		 get { } //Length: 0
	}

	public bool AllowStancePanel
	{
		 get { } //Length: 0
	}

	public bool AmmoSelectorAvailable
	{
		 get { } //Length: 0
	}

	public bool AzimuthActive
	{
		 get { } //Length: 0
	}

	public bool Closed
	{
		 get { } //Length: 0
	}

	public GesturesQuickPanel GesturesQuickPanel
	{
		 get { } //Length: 0
	}

	public InsuranceCompany Insurance
	{
		 get { } //Length: 0
	}

	public GamePlayerOwner Owner
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnClose(Action value) { }

	[CompilerGenerated]
	public void add_OnShow(Action value) { }

	public void CloseScreen() { }

	public bool get_AllowHealthPanel() { }

	public bool get_AllowQuickPanel() { }

	public bool get_AllowStancePanel() { }

	public bool get_AmmoSelectorAvailable() { }

	public bool get_AzimuthActive() { }

	public bool get_Closed() { }

	public GesturesQuickPanel get_GesturesQuickPanel() { }

	public InsuranceCompany get_Insurance() { }

	public GamePlayerOwner get_Owner() { }

	public void HideAzimuthPanel() { }

	[CompilerGenerated]
	public void remove_OnClose(Action value) { }

	[CompilerGenerated]
	public void remove_OnShow(Action value) { }

	public void ShowAmmoCountZeroingPanel(string message) { }

	public void ShowAmmoDetails(int ammoCount, int maxAmmoCount, int mastering, string details, bool foldingMechanimWeapon) { }

	public void ShowAzimuthPanel(Func valueGetter) { }

	public void ShowFireMode(EFireMode fireMode) { }

	public void ShowRaidTime() { }

	public void ShowScreen(EScreenState screenState) { }

	public void SubscribeOnMalfunctions(Action func) { }

	public void UnsubscribeFromMalfunctions(Action func) { }

}

