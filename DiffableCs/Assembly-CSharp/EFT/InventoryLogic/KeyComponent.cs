namespace EFT.InventoryLogic;

public class KeyComponent : ItemComponent, IRelativeComponent, IItemComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_1; //Field offset: 0x8
		public static Func <>9__10_3; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__10_1() { }

		internal EItemAttributeDisplayType <.ctor>b__10_3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public KeyComponent <>4__this; //Field offset: 0x10
		public IKeyComponentTemplate template; //Field offset: 0x18
		public int maximumUsages; //Field offset: 0x20

		public <>c__DisplayClass10_0() { }

		internal string <.ctor>b__0() { }

		internal string <.ctor>b__2() { }

	}

	private const string SINGLE_KEYCARD = "keycard_single"; //Field offset: 0x0
	private const string REUSABLE_KEYCARD = "keycard_reusable"; //Field offset: 0x0
	private const string UNLIMITED_KEYCARD = "keycard_unlimited"; //Field offset: 0x0
	public static readonly string RedColorFormat; //Field offset: 0x0
	public static readonly string WhiteColorFormat; //Field offset: 0x8
	public static readonly string CyanColorFormat; //Field offset: 0x10
	[Diffable]
	public int NumberOfUsages; //Field offset: 0x18
	public readonly IKeyComponentTemplate Template; //Field offset: 0x20

	public override float RelativeValue
	{
		 get { } //Length: 120
	}

	private static KeyComponent() { }

	public KeyComponent(Item item, IKeyComponentTemplate template) { }

	public override float get_RelativeValue() { }

	private string KeycardType(int usage) { }

}

