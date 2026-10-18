namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionWeaponAssembly : ConditionItem, IConditionHandoverItem
{
	public WeaponAssemblyParameter durability; //Field offset: 0xF8
	public WeaponAssemblyParameter ergonomics; //Field offset: 0x100
	public WeaponAssemblyParameter baseAccuracy; //Field offset: 0x108
	public WeaponAssemblyParameter recoil; //Field offset: 0x110
	public WeaponAssemblyParameter muzzleVelocity; //Field offset: 0x118
	public WeaponAssemblyParameter height; //Field offset: 0x120
	public WeaponAssemblyParameter magazineCapacity; //Field offset: 0x128
	public WeaponAssemblyParameter width; //Field offset: 0x130
	public WeaponAssemblyParameter weight; //Field offset: 0x138
	public WeaponAssemblyParameter effectiveDistance; //Field offset: 0x140
	public WeaponAssemblyParameter emptyTacticalSlot; //Field offset: 0x148
	public string[] hasItemFromCategory; //Field offset: 0x150
	public string[] containsItems; //Field offset: 0x158

	public virtual string FormattedDescription
	{
		 get { } //Length: 939
	}

	public ConditionWeaponAssembly() { }

	public virtual string get_FormattedDescription() { }

}

