//Type is in global namespace

public class AdditionalHostilitySettings
{
	internal class ChancedEnemy
	{
		public int EnemyChance; //Field offset: 0x10
		public WildSpawnType Role; //Field offset: 0x14

		public ChancedEnemy() { }

	}

	public WildSpawnType BotRole; //Field offset: 0x10
	public WildSpawnType[] AlwaysEnemies; //Field offset: 0x18
	public ChancedEnemy[] ChancedEnemies; //Field offset: 0x20
	public WildSpawnType[] Warn; //Field offset: 0x28
	public WildSpawnType[] Neutral; //Field offset: 0x30
	public WildSpawnType[] AlwaysFriends; //Field offset: 0x38
	public EWarnBehaviour SavagePlayerBehaviour; //Field offset: 0x40
	public int SavageEnemyChance; //Field offset: 0x44
	public EWarnBehaviour BearPlayerBehaviour; //Field offset: 0x48
	public int BearEnemyChance; //Field offset: 0x4C
	public EWarnBehaviour UsecPlayerBehaviour; //Field offset: 0x50
	public int UsecEnemyChance; //Field offset: 0x54

	public AdditionalHostilitySettings() { }

}

