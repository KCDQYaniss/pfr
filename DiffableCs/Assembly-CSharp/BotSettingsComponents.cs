//Type is in global namespace

public class BotSettingsComponents
{
	public BotGlobalLayData Lay; //Field offset: 0x10
	public BotGlobalAimingSettings Aiming; //Field offset: 0x18
	public BotGlobalLookData Look; //Field offset: 0x20
	public BotGlobalShootData Shoot; //Field offset: 0x28
	public BotGlobalsMoveSettings Move; //Field offset: 0x30
	public BotGlobalsGrenadeSettings Grenade; //Field offset: 0x38
	public BotGlobalsChangeSettings Change; //Field offset: 0x40
	public BotGlobalsCoverSettings Cover; //Field offset: 0x48
	public BotGlobalPatrolSettings Patrol; //Field offset: 0x50
	public BotGlobasHearingSettings Hearing; //Field offset: 0x58
	public BotGlobalsMindSettings Mind; //Field offset: 0x60
	public BotGlobalsBossSettings Boss; //Field offset: 0x68
	public BotCoreSettings Core; //Field offset: 0x70
	public BotGlobalsScatteringSettings Scattering; //Field offset: 0x78

	public BotSettingsComponents() { }

	public BotSettingsComponents Copy() { }

	public static BotSettingsComponents Create(string pvp, string pve, BotDifficulty d, WildSpawnType role) { }

}

