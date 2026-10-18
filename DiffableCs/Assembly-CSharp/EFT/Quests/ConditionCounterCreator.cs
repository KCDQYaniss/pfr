namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionCounterCreator : Condition
{
	private sealed class ConditionCounterTemplate
	{
		[JsonProperty("conditions")]
		public ConditionCollection Conditions; //Field offset: 0x10

		public ConditionCounterTemplate() { }

	}

	private const string RESET_ON_CONDITION_FAILED_KEY = "{resetOnConditionFailed{0}}"; //Field offset: 0x0
	private const string RESET_ON_SESSION_END_KEY = "{resetOnSessionEnd}"; //Field offset: 0x0
	private static readonly Dictionary _localizationTypes; //Field offset: 0x0
	[JsonProperty("counter")]
	private ConditionCounterTemplate _templateConditions; //Field offset: 0xE0
	[CompilerGenerated]
	private ConditionCollection <Conditions>k__BackingField; //Field offset: 0xE8
	public EQuestType type; //Field offset: 0xF0
	public bool doNotResetIfCounterCompleted; //Field offset: 0xF4
	public bool isResetOnConditionFailed; //Field offset: 0xF5
	public bool isNotGroupProgress; //Field offset: 0xF6

	[JsonIgnore]
	public private ConditionCollection Conditions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual string FormattedDescription
	{
		 get { } //Length: 18
	}

	private static ConditionCounterCreator() { }

	public ConditionCounterCreator() { }

	[CompilerGenerated]
	public ConditionCollection get_Conditions() { }

	public virtual string get_FormattedDescription() { }

	protected virtual List IdentityFields() { }

	private string LocalizeDescription() { }

	[OnDeserialized]
	internal void OnDeserializedMethod(StreamingContext context) { }

	[CompilerGenerated]
	private void set_Conditions(ConditionCollection value) { }

	public virtual string ToString() { }

}

