namespace EFT.InventoryLogic;

public class RecodableComponent : ItemComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <AddRecodableAttribute>b__8_1() { }

	}

	protected const string ENCODED = "RecodableItem/AttributeValues/Encoded"; //Field offset: 0x0
	protected const string DECODED = "RecodableItem/AttributeValues/Decoded"; //Field offset: 0x0
	[Diffable]
	public bool IsEncoded; //Field offset: 0x18
	private readonly IRecodableItemTemplate _template; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnRecodableStateChanged; //Field offset: 0x28

	public event Action OnRecodableStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public RecodableComponent(Item item, IRecodableItemTemplate template) { }

	[CompilerGenerated]
	private string <AddRecodableAttribute>b__8_0() { }

	[CompilerGenerated]
	public void add_OnRecodableStateChanged(Action value) { }

	protected void AddRecodableAttribute(Item item) { }

	protected override string GetAttributeValue() { }

	[CompilerGenerated]
	public void remove_OnRecodableStateChanged(Action value) { }

	public override void SetEncoded(bool value) { }

}

