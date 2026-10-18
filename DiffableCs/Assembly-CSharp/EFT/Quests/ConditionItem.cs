namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public class ConditionItem : ConditionMultipleTargets
{
	public int minDurability; //Field offset: 0xE8
	public int maxDurability; //Field offset: 0xEC
	public int dogtagLevel; //Field offset: 0xF0
	public bool onlyFoundInRaid; //Field offset: 0xF4
	public bool isEncoded; //Field offset: 0xF5
	[CompilerGenerated]
	private bool <IncludeEquipment>k__BackingField; //Field offset: 0xF6

	public virtual string FormattedDescription
	{
		 get { } //Length: 1045
	}

	[JsonProperty("includeEquipment")]
	public private bool IncludeEquipment
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public ConditionItem() { }

	public IReadOnlyCollection ConvertToHandoverItems(Quest quest, Item[] items) { }

	public virtual string get_FormattedDescription() { }

	[CompilerGenerated]
	public bool get_IncludeEquipment() { }

	[CompilerGenerated]
	private void set_IncludeEquipment(bool value) { }

}

