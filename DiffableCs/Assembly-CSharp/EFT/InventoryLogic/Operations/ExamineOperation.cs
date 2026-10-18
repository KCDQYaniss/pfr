namespace EFT.InventoryLogic.Operations;

public sealed class ExamineOperation : AbstractOperation
{
	internal sealed class ExamineCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("item")]
		public string Item; //Field offset: 0x20
		[CompilerGenerated]
		private MongoID <ItemTemplate>k__BackingField; //Field offset: 0x28

		[JsonIgnore]
		public MongoID ItemTemplate
		{
			[CompilerGenerated]
			 get { } //Length: 21
			[CompilerGenerated]
			 set { } //Length: 98
		}

		public ExamineCommand() { }

		[CompilerGenerated]
		public MongoID get_ItemTemplate() { }

		[CompilerGenerated]
		public void set_ItemTemplate(MongoID value) { }

	}

	public readonly float ExamineTime; //Field offset: 0x40
	private readonly Item _item; //Field offset: 0x48
	private readonly IInventoryProfileInfo _profile; //Field offset: 0x50
	private ExamineItemEventArgs _eventArgs; //Field offset: 0x58

	internal ExamineOperation(ushort id, ItemController controller, IInventoryProfileInfo profile, Item item) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public void FakeExecute(Callback callback) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

