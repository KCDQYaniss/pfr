//Type is in global namespace

public class BotWeaponInfo
{
	public Weapon weapon; //Field offset: 0x10
	public BotReload Reload; //Field offset: 0x18
	private Func _changeAction; //Field offset: 0x20

	public int BulletCount
	{
		 get { } //Length: 29
	}

	public bool IsNowAutomatic
	{
		 get { } //Length: 47
	}

	public BotWeaponInfo(BotOwner owner, Weapon weapon, EquipmentSlot slot, Func changeAction) { }

	public void ChangeFireMode(EFireMode mode) { }

	public bool CheckHaveAmmoForReload() { }

	public int get_BulletCount() { }

	public bool get_IsNowAutomatic() { }

}

