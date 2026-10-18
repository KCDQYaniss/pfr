namespace EFT.InventoryLogic;

public class SideEffectComponent : StimulatorBuffsComponent, IResourceComponent, IItemComponent, IRelativeComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__3_0; //Field offset: 0x8
		public static Func <>9__9_0; //Field offset: 0x10
		public static Func <>9__9_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__9_0(StimulatorBuffSettings x) { }

		internal EItemAttributeDisplayType <.ctor>b__9_2() { }

		internal bool <set_Value>b__3_0(ItemAttribute attribute) { }

	}

	private float _value; //Field offset: 0x20
	private readonly IPoisonComponentTemplate _template; //Field offset: 0x28

	public bool IsEmpty
	{
		 get { } //Length: 224
	}

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
		 get { } //Length: 6
		 set { } //Length: 558
	}

	public SideEffectComponent(Item item, IPoisonComponentTemplate template) { }

	[CompilerGenerated]
	private string <.ctor>b__9_1() { }

	public bool get_IsEmpty() { }

	public override float get_MaxResource() { }

	public override float get_RelativeValue() { }

	public override float get_Value() { }

	public override void set_Value(float value) { }

}

