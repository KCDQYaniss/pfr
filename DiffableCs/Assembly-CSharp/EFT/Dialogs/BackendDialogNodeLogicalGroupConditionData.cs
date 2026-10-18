namespace EFT.Dialogs;

public sealed class BackendDialogNodeLogicalGroupConditionData
{
	[CompilerGenerated]
	private MongoID <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ELogicalCompareMethod <CompareMethod>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private IReadOnlyList <Conditions>k__BackingField; //Field offset: 0x30

	[JsonProperty("operator")]
	public private ELogicalCompareMethod CompareMethod
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("conditions")]
	public private IReadOnlyList Conditions
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("id")]
	public private MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	[JsonConstructor]
	public BackendDialogNodeLogicalGroupConditionData(MongoID id, ELogicalCompareMethod compareMethod, IReadOnlyList conditions) { }

	[CompilerGenerated]
	public ELogicalCompareMethod get_CompareMethod() { }

	[CompilerGenerated]
	public IReadOnlyList get_Conditions() { }

	[CompilerGenerated]
	public MongoID get_Id() { }

	[CompilerGenerated]
	private void set_CompareMethod(ELogicalCompareMethod value) { }

	[CompilerGenerated]
	private void set_Conditions(IReadOnlyList value) { }

	[CompilerGenerated]
	private void set_Id(MongoID value) { }

}

