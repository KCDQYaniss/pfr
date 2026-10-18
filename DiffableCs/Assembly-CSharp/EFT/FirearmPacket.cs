namespace EFT;

public struct FirearmPacket
{
	private const int MIN_SCOPE_INDEX = -1; //Field offset: 0x0
	private const int MAX_SCOPE_INDEX = 15; //Field offset: 0x0
	public FireModePacket ChangeFireMode; //Field offset: 0x0
	public bool ChangeCalibrationPoint; //Field offset: 0x2
	public bool ToggleAim; //Field offset: 0x3
	public int AimingIndex; //Field offset: 0x4
	public bool ExamineWeapon; //Field offset: 0x8
	public bool CheckAmmo; //Field offset: 0x9
	public bool CheckChamber; //Field offset: 0xA
	public bool CheckFireMode; //Field offset: 0xB
	public bool ToggleLauncher; //Field offset: 0xC
	public bool ReloadBoltAction; //Field offset: 0xD
	public bool ToggleBipod; //Field offset: 0xE
	public ToggleTacticalComboPacket ToggleTacticalCombo; //Field offset: 0x10
	public SightsModePacket ChangeSightsMode; //Field offset: 0x20
	public SpectatorScopeZoomStatusPacket SpectatorScopeZoomStatus; //Field offset: 0x30
	public LauncherRangeStatePacket LauncherRangeStatePacket; //Field offset: 0x40
	public Nullable FiredShotInfos; //Field offset: 0x50
	public FlareShotInfo FlareShotInfo; //Field offset: 0xA0
	public RocketShotInfo RocketShotInfo; //Field offset: 0xBC
	public LauncherReloadInfo LauncherReloadInfo; //Field offset: 0xD8
	public EnableInventoryPacket EnableInventoryPacket; //Field offset: 0xE8
	public HideWeaponPacket HideWeaponPacket; //Field offset: 0xF0
	public ReloadMagPacket ReloadMagPacket; //Field offset: 0x100
	public QuickReloadMag QuickReloadMagPacket; //Field offset: 0x118
	public ReloadWithAmmo ReloadWithAmmoPacket; //Field offset: 0x138
	public ReloadBarrels ReloadBarrelsPacket; //Field offset: 0x158
	public OneAndList ShotsForApprovement; //Field offset: 0x170
	public CompassPacket CompassPacket; //Field offset: 0x1F8
	public RadioTransmitterPacket RadioTransmitterPacket; //Field offset: 0x200
	public LighthouseTraderZoneData LighthouseTraderZoneDataPacket; //Field offset: 0x218
	public CylinderMagStatus CylinderMagStatusPacket; //Field offset: 0x228
	public RollCylinderPacket RollCylinderPacket; //Field offset: 0x234
	public bool IsInImportantState; //Field offset: 0x236
	public EInteraction Gesture; //Field offset: 0x237
	public float TimeStamp; //Field offset: 0x238
	public SetLeftStancePacket SetLeftStancePacket; //Field offset: 0x23C

	internal bool HasCommandsForHands
	{
		internal get { } //Length: 380
	}

	internal bool HasReloadData
	{
		internal get { } //Length: 47
	}

	public void Add(FiredShotInfo firedShotInfo) { }

	public static void DeserializeDiffUsing(IBitReaderStream reader, ref FirearmPacket firearmPacket, FirearmPacket prevFrame) { }

	internal bool get_HasCommandsForHands() { }

	internal bool get_HasReloadData() { }

	public bool HasShotsRealShots() { }

	public static void SerializeDiffUsing(IBitWriterStream writer, FirearmPacket current, FirearmPacket prevFrame) { }

	public virtual string ToString() { }

}

