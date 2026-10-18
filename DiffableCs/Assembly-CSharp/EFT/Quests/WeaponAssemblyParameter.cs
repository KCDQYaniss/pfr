namespace EFT.Quests;

public sealed class WeaponAssemblyParameter
{
	[DefaultValue(ECompareMethod::MoreOrEqual (0))]
	public ECompareMethod compareMethod; //Field offset: 0x10
	public float value; //Field offset: 0x14

	public WeaponAssemblyParameter() { }

}

