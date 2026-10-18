//Type is in global namespace

public class BotCurrentScatteringSetting
{
	public BotWeaponScattering CurrentScattering; //Field offset: 0x10
	private readonly Dictionary _scatteringByType; //Field offset: 0x18

	public BotCurrentScatteringSetting(BotWeaponScattering[] scatterings) { }

	public void Check(BotGlobalsScatteringSettings settings) { }

	public void SetWeapon(Weapon weapon) { }

}

