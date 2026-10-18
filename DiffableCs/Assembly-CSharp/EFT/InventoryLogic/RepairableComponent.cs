namespace EFT.InventoryLogic;

public class RepairableComponent : ItemComponent, IRelativeComponent, IItemComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_1; //Field offset: 0x8
		public static Func <>9__11_4; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__11_1() { }

		internal EItemAttributeDisplayType <.ctor>b__11_4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public RangedItemAttribute maxDurabilityAttribute; //Field offset: 0x10
		public RepairableComponent <>4__this; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal float <.ctor>b__3() { }

	}

	[Diffable]
	public float MaxDurability; //Field offset: 0x18
	[Diffable]
	public float Durability; //Field offset: 0x1C
	private readonly IRepairableComponentTemplate _template; //Field offset: 0x20

	public override float RelativeValue
	{
		 get { } //Length: 11
	}

	public Vector2 RepairDegradation
	{
		 get { } //Length: 349
	}

	public Vector2 RepairKitDegradation
	{
		 get { } //Length: 349
	}

	public int TemplateDurability
	{
		 get { } //Length: 78
	}

	public RepairableComponent(Item item, IRepairableComponentTemplate template) { }

	[CompilerGenerated]
	private float <.ctor>b__11_0() { }

	[CompilerGenerated]
	private float <.ctor>b__11_2() { }

	public override float get_RelativeValue() { }

	public Vector2 get_RepairDegradation() { }

	public Vector2 get_RepairKitDegradation() { }

	public int get_TemplateDurability() { }

}

