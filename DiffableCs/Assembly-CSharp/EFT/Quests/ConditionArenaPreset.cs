namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public class ConditionArenaPreset : Condition
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8
		public static Func <>9__10_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <GenerateFormattedDescription>b__10_0(string x) { }

		internal string <GenerateFormattedDescription>b__10_2(string x) { }

	}

	private enum EPresetTagTypes
	{
		PresetTier = 0,
		PresetType = 1,
		PresetId = 2,
	}

	public string[] tierIds; //Field offset: 0xE0
	public string[] classIds; //Field offset: 0xE8
	public string[] presetIds; //Field offset: 0xF0

	public virtual string FormattedDescription
	{
		 get { } //Length: 18
	}

	protected override string LocalizationFormatKey
	{
		 get { } //Length: 49
	}

	protected override string LocalizationKey
	{
		 get { } //Length: 49
	}

	public ConditionArenaPreset() { }

	[CompilerGenerated]
	private string <GenerateFormattedDescription>b__10_1(string x) { }

	protected string GenerateFormattedDescription() { }

	public virtual string get_FormattedDescription() { }

	protected override string get_LocalizationFormatKey() { }

	protected override string get_LocalizationKey() { }

}

