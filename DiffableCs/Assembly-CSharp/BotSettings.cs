//Type is in global namespace

public class BotSettings
{
	private readonly BotDifficulty _difficulty; //Field offset: 0x10
	private readonly WildSpawnType _role; //Field offset: 0x14
	private readonly HashSet _alwaysFriendlyBotTypes; //Field offset: 0x18
	private readonly HashSet _friendlyNoWarnBotTypes; //Field offset: 0x20
	private readonly HashSet _friendlyBotTypes; //Field offset: 0x28
	private readonly HashSet _warnBotTypes; //Field offset: 0x30
	private readonly HashSet _enemyBotTypes; //Field offset: 0x38
	private readonly HashSet _potentialEnemiesByChance; //Field offset: 0x40
	private List _rolledEnemyChanceGroupsEnemy; //Field offset: 0x48
	private List _rolledEnemyChanceGroupsNotEnemy; //Field offset: 0x50
	[CompilerGenerated]
	private readonly BotCurvSettings <Curv>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private BotCurrentSettings <Current>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private BotSettingsComponents <FileSettings>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private BotCurrentScatteringSetting <CurrentScatteringSetting>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <HaveDamaged>k__BackingField; //Field offset: 0x78
	private bool _isLogged; //Field offset: 0x79

	public private BotCurrentSettings Current
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotCurrentScatteringSetting CurrentScatteringSetting
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotCurvSettings Curv
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private BotSettingsComponents FileSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool HaveDamaged
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public BotSettings(BotDifficulty difficulty, WildSpawnType role, BotCurvSettings curv, BotWeaponScattering[] scatterings, bool isPve) { }

	public void Activate() { }

	public void ApplyPreset(BotPreset settings) { }

	public void ApplyPresetLocation(BotLocationModifier modifier) { }

	public BotSettings Copy() { }

	public bool DebugChangeParameter(string cls, string prm, object val) { }

	public void DebugUpdateSettingsExternal(bool isPve) { }

	[CompilerGenerated]
	public BotCurrentSettings get_Current() { }

	[CompilerGenerated]
	public BotCurrentScatteringSetting get_CurrentScatteringSetting() { }

	[CompilerGenerated]
	public BotCurvSettings get_Curv() { }

	[CompilerGenerated]
	public BotSettingsComponents get_FileSettings() { }

	[CompilerGenerated]
	public bool get_HaveDamaged() { }

	public HashSet GetAlwaysFriendlyBotTypes() { }

	public T GetAttribute(object obj, string _name) { }

	private void GetCurrentSettings() { }

	public HashSet GetEnemyBotTypes() { }

	public HashSet GetFriendlyBotTypes() { }

	public HashSet GetFriendNoWarnBotTypes() { }

	public static AdditionalHostilitySettings[] GetHostilitySettings() { }

	public HashSet GetPotentialByChanceEnemyBotTypes() { }

	public HashSet GetWarnBotTypes() { }

	public bool IsEnemyByChance(BotOwner bot) { }

	public bool IsPlayerAlwaysFriends(IPlayer player) { }

	public bool IsPlayerWarn(IPlayer player) { }

	[CompilerGenerated]
	private void set_Current(BotCurrentSettings value) { }

	[CompilerGenerated]
	private void set_CurrentScatteringSetting(BotCurrentScatteringSetting value) { }

	[CompilerGenerated]
	private void set_FileSettings(BotSettingsComponents value) { }

	[CompilerGenerated]
	public void set_HaveDamaged(bool value) { }

	public bool SetAttribute(object obj, string fieldName, object val) { }

	public void UpdateManual() { }

}

