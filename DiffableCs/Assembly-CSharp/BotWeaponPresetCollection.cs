//Type is in global namespace

public class BotWeaponPresetCollection : BotData
{
	private BotGlobalShootData _shootSettings; //Field offset: 0x18
	private BotCurrentSettings _currentSettings; //Field offset: 0x20
	private WeaponAIPreset _weaponAIPreset; //Field offset: 0x28
	private readonly Dictionary _presets; //Field offset: 0x30

	public private WeaponAIPreset WeaponAIPreset
	{
		 get { } //Length: 5
		private set { } //Length: 507
	}

	public BotWeaponPresetCollection(BotOwner owner) { }

	public WeaponAIPreset get_WeaponAIPreset() { }

	private float GetHoldDownAuto() { }

	private float GetHoldDownSingle() { }

	private float GetHoldDownStationaryBullet() { }

	private float GetHoldDownStationaryGrenade() { }

	private float GetWaitUpTriggerSelfWeapon() { }

	private float GetWaitUpTriggerStationaryBullet() { }

	private float GetWaitUpTriggerStationaryGrenade() { }

	public void PreActivate() { }

	private void set_WeaponAIPreset(WeaponAIPreset value) { }

	public void UpdateFirearmsController(StationaryWeapon stationaryWeapon, bool isNowAutomatic) { }

}

