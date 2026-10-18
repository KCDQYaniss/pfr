namespace EFT;

[GenerateBinarySerialization]
public sealed class ProfileSettings
{
	public WildSpawnType Role; //Field offset: 0x10
	public BotDifficulty BotDifficulty; //Field offset: 0x14
	public int Experience; //Field offset: 0x18
	public double StandingForKill; //Field offset: 0x20
	public double AggressorBonus; //Field offset: 0x28
	public bool UseSimpleAnimator; //Field offset: 0x30

	public ProfileSettings() { }

	public void TryChangeRoleToAssaultGroup() { }

}

