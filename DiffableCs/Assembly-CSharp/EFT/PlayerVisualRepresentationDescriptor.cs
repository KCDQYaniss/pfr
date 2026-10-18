namespace EFT;

[GenerateBinarySerialization]
public sealed class PlayerVisualRepresentationDescriptor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Func <>9__4_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal EBodyModelPart <.ctor>b__4_0(KeyValuePair bodyPert) { }

		internal MongoID <.ctor>b__4_1(KeyValuePair bodyPart) { }

	}

	[JsonProperty("Info")]
	public PlayerInfo Info; //Field offset: 0x10
	[CanBeNull]
	[JsonProperty("Customization")]
	[Nullable]
	public Dictionary Customization; //Field offset: 0x18
	[CanBeNull]
	[JsonProperty("Equipment")]
	[Nullable]
	public InventoryEquipmentDescriptor Equipment; //Field offset: 0x20

	public PlayerVisualRepresentationDescriptor() { }

	public PlayerVisualRepresentationDescriptor(PlayerVisualRepresentation playerVisual) { }

}

