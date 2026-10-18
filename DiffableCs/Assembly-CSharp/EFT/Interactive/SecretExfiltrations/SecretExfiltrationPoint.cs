namespace EFT.Interactive.SecretExfiltrations;

public sealed class SecretExfiltrationPoint : ExfiltrationPoint
{
	private const string REQUIREMENT_TIP = "EXFIL_Item"; //Field offset: 0x0
	[CompilerGenerated]
	private bool <EligibleForScav>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private bool <EligibleForPmc>k__BackingField; //Field offset: 0xF9
	public Action OnPointFoundEvent; //Field offset: 0x100
	private bool _itemTransferred; //Field offset: 0x108
	private Player _localPlayer; //Field offset: 0x110

	public private bool EligibleForPmc
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool EligibleForScav
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool ItemTransferred
	{
		 get { } //Length: 8
		 set { } //Length: 490
	}

	public SecretExitTransferItemRequirement SecretTransferItemRequirement
	{
		 get { } //Length: 98
	}

	public virtual EExfiltrationStatus Status
	{
		 get { } //Length: 5
		 set { } //Length: 56
	}

	public SecretExfiltrationPoint() { }

	public void ExternalDiscoverOfPoint(bool discoverFromTeam = true) { }

	[CompilerGenerated]
	public bool get_EligibleForPmc() { }

	[CompilerGenerated]
	public bool get_EligibleForScav() { }

	public bool get_ItemTransferred() { }

	public SecretExitTransferItemRequirement get_SecretTransferItemRequirement() { }

	public virtual EExfiltrationStatus get_Status() { }

	public virtual bool InfiltrationMatch(Player player) { }

	public void InitSecretExfilPoint(Player player) { }

	public void LoadSettings(MongoID exfilId, BackendSecretExitTriggerSettings settings, bool authority) { }

	public virtual void OnItemTransferred(IPlayer player) { }

	public virtual void Proceed(Player player, bool manuallyStarted = false) { }

	[CompilerGenerated]
	private void set_EligibleForPmc(bool value) { }

	[CompilerGenerated]
	private void set_EligibleForScav(bool value) { }

	public void set_ItemTransferred(bool value) { }

	public virtual void set_Status(EExfiltrationStatus value) { }

	private void ShowExitOnItemPickup(AddItemEventArgs args) { }

}

