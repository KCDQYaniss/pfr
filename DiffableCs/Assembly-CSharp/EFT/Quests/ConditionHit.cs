namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public class ConditionHit : Condition
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__19_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GenerateFormattedDescription>b__19_0(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public string localeKey; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal string <GenerateFormattedDescription>b__1(EBodyPart x) { }

	}

	private enum EHitTagTypes
	{
		Target = 0,
		Distance = 1,
		Weapon = 2,
		WeaponType = 3,
		BodyPart = 4,
		OneSession = 5,
		BotRole = 6,
	}

	public string target; //Field offset: 0xE0
	public ConditionComparer distance; //Field offset: 0xE8
	public string[] weapon; //Field offset: 0xF0
	public string[] weaponCaliber; //Field offset: 0xF8
	public string[] weaponCategories; //Field offset: 0x100
	public string[][] weaponModsInclusive; //Field offset: 0x108
	public string[][] weaponModsExclusive; //Field offset: 0x110
	public EBodyPart[] bodyPart; //Field offset: 0x118
	public string[] savageRole; //Field offset: 0x120
	public ConditionTimeComparer daytime; //Field offset: 0x128
	public bool resetOnSessionEnd; //Field offset: 0x130
	public string[][] enemyEquipmentInclusive; //Field offset: 0x138
	public string[][] enemyEquipmentExclusive; //Field offset: 0x140
	public BodyPartsWithEffects[] enemyHealthEffects; //Field offset: 0x148

	public virtual string FormattedDescription
	{
		 get { } //Length: 18
	}

	protected override string LocalizationKey
	{
		 get { } //Length: 49
	}

	public ConditionHit() { }

	private string GenerateFormattedDescription() { }

	public virtual string get_FormattedDescription() { }

	protected override string get_LocalizationKey() { }

}

