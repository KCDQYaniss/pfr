namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public abstract class Condition : IUpdatable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__61_0; //Field offset: 0x8
		public static Func <>9__61_1; //Field offset: 0x10
		public static Func <>9__62_0; //Field offset: 0x18
		public static Func <>9__62_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <CalculateIdentity>b__61_0(object field) { }

		internal int <CalculateIdentity>b__61_1(int current, int hashCode) { }

		internal int <CalculateIdentity>b__62_0(object field) { }

		internal int <CalculateIdentity>b__62_1(int current, int hashCode) { }

	}

	[CompilerGenerated]
	private MongoID <id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private float <value>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ECompareMethod <compareMethod>k__BackingField; //Field offset: 0x2C
	[JsonProperty("visibilityConditions")]
	public Condition[] VisibilityConditions; //Field offset: 0x30
	[CompilerGenerated]
	private int <index>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Nullable <ParentId>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <DynamicLocale>k__BackingField; //Field offset: 0x60
	[JsonProperty("isNecessary")]
	private bool _isNecessary; //Field offset: 0x61
	private int _identity; //Field offset: 0x64
	public readonly UpdatableBindableList ChildConditions; //Field offset: 0x68
	[CompilerGenerated]
	private bool <ResetOnSessionEnd>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private Nullable <QuestNoteId>k__BackingField; //Field offset: 0x78
	[JsonProperty("fromTraderId")]
	public Nullable FromTraderId; //Field offset: 0x98
	[JsonProperty("entryPoint")]
	public Nullable EntryPointSource; //Field offset: 0xB8
	[JsonProperty("dialogId")]
	public Nullable DialogId; //Field offset: 0xC0

	[DefaultValue(ECompareMethod::MoreOrEqual (0))]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public ECompareMethod compareMethod
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonProperty("dynamicLocale")]
	public bool DynamicLocale
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool FirstLevel
	{
		 get { } //Length: 55
	}

	[JsonIgnore]
	public override string FormattedDescription
	{
		 get { } //Length: 241
	}

	[JsonIgnore]
	public string FormattedHint
	{
		 get { } //Length: 123
	}

	[JsonIgnore]
	public bool HasHint
	{
		 get { } //Length: 152
	}

	[JsonIgnore]
	public override bool HiddenByDefault
	{
		 get { } //Length: 3
	}

	private string HintLocale
	{
		private get { } //Length: 176
	}

	[JsonProperty]
	public MongoID id
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 98
	}

	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public int index
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public bool IsHiddenValue
	{
		 get { } //Length: 38
	}

	[JsonIgnore]
	public bool IsNecessary
	{
		 get { } //Length: 69
	}

	[JsonProperty("parentId")]
	public private Nullable ParentId
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("questNoteId")]
	public private Nullable QuestNoteId
	{
		[CompilerGenerated]
		 get { } //Length: 22
		[CompilerGenerated]
		private set { } //Length: 98
	}

	[JsonProperty("oneSessionOnly")]
	public override bool ResetOnSessionEnd
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public override bool Reversible
	{
		 get { } //Length: 3
	}

	[JsonIgnore]
	public override bool SaveCompletionOnBacked
	{
		 get { } //Length: 3
	}

	[DefaultValue(1)]
	[JsonProperty("value", DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public override float value
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	protected Condition() { }

	protected static int CalculateIdentity(List fields) { }

	public static int CalculateIdentity(object[] fields) { }

	public override bool Compare(Condition other) { }

	[CompilerGenerated]
	public ECompareMethod get_compareMethod() { }

	[CompilerGenerated]
	public bool get_DynamicLocale() { }

	public bool get_FirstLevel() { }

	public override string get_FormattedDescription() { }

	public string get_FormattedHint() { }

	public bool get_HasHint() { }

	public override bool get_HiddenByDefault() { }

	private string get_HintLocale() { }

	[CompilerGenerated]
	public MongoID get_id() { }

	[CompilerGenerated]
	public int get_index() { }

	public bool get_IsHiddenValue() { }

	public bool get_IsNecessary() { }

	[CompilerGenerated]
	public Nullable get_ParentId() { }

	[CompilerGenerated]
	public Nullable get_QuestNoteId() { }

	[CompilerGenerated]
	public override bool get_ResetOnSessionEnd() { }

	public override bool get_Reversible() { }

	public override bool get_SaveCompletionOnBacked() { }

	[CompilerGenerated]
	public override float get_value() { }

	public virtual int GetHashCode() { }

	public override bool HasIdentity(int identity) { }

	protected override List IdentityFields() { }

	[CompilerGenerated]
	protected void set_compareMethod(ECompareMethod value) { }

	[CompilerGenerated]
	protected void set_DynamicLocale(bool value) { }

	[CompilerGenerated]
	protected void set_id(MongoID value) { }

	[CompilerGenerated]
	protected void set_index(int value) { }

	[CompilerGenerated]
	private void set_ParentId(Nullable value) { }

	[CompilerGenerated]
	private void set_QuestNoteId(Nullable value) { }

	[CompilerGenerated]
	public override void set_ResetOnSessionEnd(bool value) { }

	[CompilerGenerated]
	protected override void set_value(float value) { }

	public virtual string ToString() { }

	public override void UpdateFromAnotherItem(Condition other) { }

}

