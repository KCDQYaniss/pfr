namespace EFT.UI.Insurance;

public sealed class InsuredItem : IUpdatable
{
	public readonly string Id; //Field offset: 0x10
	public string TemplateId; //Field offset: 0x18
	public string Name; //Field offset: 0x20
	public string ShortName; //Field offset: 0x28
	public Item Item; //Field offset: 0x30
	public readonly UpdatableBindableList ChildrenToInsure; //Field offset: 0x38
	[CompilerGenerated]
	private InsuredItem <Parent>k__BackingField; //Field offset: 0x40
	public string InsurerId; //Field offset: 0x48
	public Type Type; //Field offset: 0x50

	public private InsuredItem Parent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private InsuredItem(Item item) { }

	public override bool Compare(InsuredItem other) { }

	public static InsuredItem FindOrCreate(Item item) { }

	[CompilerGenerated]
	public InsuredItem get_Parent() { }

	[CompilerGenerated]
	private void set_Parent(InsuredItem value) { }

	public void SetParent(InsuredItem parent) { }

	public override void UpdateFromAnotherItem(InsuredItem other) { }

}

