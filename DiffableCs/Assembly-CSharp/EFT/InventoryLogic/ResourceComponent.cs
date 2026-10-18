namespace EFT.InventoryLogic;

public sealed class ResourceComponent : ItemComponent, IResourceComponent, IItemComponent, IRelativeComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__9_2() { }

	}

	[CompilerGenerated]
	private float <Value>k__BackingField; //Field offset: 0x18
	private readonly IResourceItemTemplate _template; //Field offset: 0x20

	public override float MaxResource
	{
		 get { } //Length: 75
	}

	public override float RelativeValue
	{
		 get { } //Length: 98
	}

	[Diffable]
	public override float Value
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public ResourceComponent(Item item, IResourceItemTemplate template) { }

	[CompilerGenerated]
	private float <.ctor>b__9_0() { }

	[CompilerGenerated]
	private string <.ctor>b__9_1() { }

	public override float get_MaxResource() { }

	public override float get_RelativeValue() { }

	[CompilerGenerated]
	public override float get_Value() { }

	[CompilerGenerated]
	public override void set_Value(float value) { }

}

