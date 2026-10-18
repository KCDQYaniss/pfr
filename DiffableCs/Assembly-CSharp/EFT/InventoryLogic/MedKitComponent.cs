namespace EFT.InventoryLogic;

public sealed class MedKitComponent : ItemComponent, IRelativeComponent, IItemComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_3; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__10_3() { }

	}

	[Diffable]
	public float HpResource; //Field offset: 0x18
	private readonly IMedKitComponentTemplate _template; //Field offset: 0x20

	public EBodyPart[] BodyPartPriority
	{
		 get { } //Length: 203
	}

	public float HpResourceRate
	{
		 get { } //Length: 78
	}

	public int MaxHpResource
	{
		 get { } //Length: 75
	}

	public override float RelativeValue
	{
		 get { } //Length: 105
	}

	public MedKitComponent(Item item, IMedKitComponentTemplate template) { }

	[CompilerGenerated]
	private float <.ctor>b__10_0() { }

	[CompilerGenerated]
	private string <.ctor>b__10_1() { }

	[CompilerGenerated]
	private string <.ctor>b__10_2() { }

	public EBodyPart[] get_BodyPartPriority() { }

	public float get_HpResourceRate() { }

	public int get_MaxHpResource() { }

	public override float get_RelativeValue() { }

}

