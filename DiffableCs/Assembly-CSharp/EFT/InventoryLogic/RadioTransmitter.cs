namespace EFT.InventoryLogic;

public class RadioTransmitter : SpecItem, IRecodableItem, IRecodableItem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Func <>9__4_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__4_0() { }

		internal EItemAttributeDisplayType <.ctor>b__4_1() { }

	}

	private RadioTransmitterTemplate _template; //Field offset: 0x78
	[Component]
	[JsonProperty("RecodableComponent")]
	public readonly RadioTransmitterRecodableComponent RecodableComponent; //Field offset: 0x80

	private override RecodableComponent EFT.InventoryLogic.IRecodableItem.RecodableComponent
	{
		private get { } //Length: 8
	}

	public RadioTransmitter(string id, RadioTransmitterTemplate template) { }

	private override RecodableComponent EFT.InventoryLogic.IRecodableItem.get_RecodableComponent() { }

	public override RadioTransmitterRecodableComponent GetRecodableComponent() { }

	public override void InitializeHandler(Player player) { }

	public override bool IsEncoded() { }

	public override bool IsInitializedHandler() { }

	public override void OnAddRecodableItem(Player player) { }

	public override void OnRemoveRecodableItem() { }

}

