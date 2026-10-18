//Type is in global namespace

public class BotWeaponScattering
{
	public string Name; //Field offset: 0x10
	public float PriorityScatter1meter; //Field offset: 0x18
	public float PriorityScatter10meter; //Field offset: 0x1C
	public float PriorityScatter100meter; //Field offset: 0x20

	public BotWeaponScattering() { }

	public BotWeaponScattering(string Name, float PriorityScatter1meter, float PriorityScatter10meter, float PriorityScatter100meter) { }

	public BotWeaponScattering(BotWeaponScattering sc, BotPreset botPreset) { }

	public void Check(BotGlobalsScatteringSettings settings) { }

}

