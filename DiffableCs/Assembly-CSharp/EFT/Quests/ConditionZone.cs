namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public class ConditionZone : ConditionMultipleTargets
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GenerateFormattedDescription>b__5_0(string x) { }

	}

	public string[] zoneIds; //Field offset: 0xE8

	public virtual string FormattedDescription
	{
		 get { } //Length: 127
	}

	protected string ZonesFormattedDescription
	{
		 get { } //Length: 451
	}

	public ConditionZone() { }

	public bool ContainsZone(string zoneId) { }

	private string GenerateFormattedDescription() { }

	public virtual string get_FormattedDescription() { }

	protected string get_ZonesFormattedDescription() { }

}

