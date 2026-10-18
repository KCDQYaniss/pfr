namespace EFT.Interactive;

public class LighthouseTraderZone : BaseRestrictableZone, IInteractive
{
	[CompilerGenerated]
	private static Action OnPlayerAllowStatusChanged; //Field offset: 0x0
	private PhysicsTriggerHandler _triggerHandler; //Field offset: 0x38
	private EquipmentSlot[] pocketSlots; //Field offset: 0x40
	private WildSpawnType[] _zoneDefenderRoles; //Field offset: 0x48
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x50

	public static event Action OnPlayerAllowStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	public string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LighthouseTraderZone() { }

	[CompilerGenerated]
	public static void add_OnPlayerAllowStatusChanged(Action value) { }

	protected virtual void AddPlayer(Player player) { }

	private void Awake() { }

	private void CheckForDestroyZone(EGameType gameType) { }

	[CompilerGenerated]
	public string get_Description() { }

	public virtual bool IsAllowedPlayer(Player player) { }

	private bool IsValidAiPlayer(Player player) { }

	private bool IsValidPlayer(RadioTransmitterHandler handler) { }

	private bool IsZoneDefender(Player player) { }

	private void OnAllTeammatesChangeRadioTransmitterState() { }

	private void OnDestroy() { }

	private void OnEnterZone(Collider col) { }

	private void OnLeaveZone(Collider col) { }

	private void OnPlayerChangeRadioTransmitterStatus(RadioTransmitterStatus newStatus) { }

	private void OnPlayerDieInZone(Player player, IPlayer lastAgressor, DamageInfo damage, EBodyPart part) { }

	private void RecalculatePlayersAllow() { }

	[CompilerGenerated]
	public static void remove_OnPlayerAllowStatusChanged(Action value) { }

	protected virtual void RemovePlayer(Player player) { }

	private void SetAgressor(Player victim, IPlayer agressor) { }

	private void UpdatePlayerAllowedStatus() { }

}

