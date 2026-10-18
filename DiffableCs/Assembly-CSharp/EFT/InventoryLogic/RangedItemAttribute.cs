namespace EFT.InventoryLogic;

public sealed class RangedItemAttribute : ItemAttribute
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <.ctor>b__4_0() { }

	}

	public Func Delta; //Field offset: 0x80
	public Vector2 Range; //Field offset: 0x88

	public bool RangeIsInverted
	{
		 get { } //Length: 19
	}

	public RangedItemAttribute(EItemAttributeId id) { }

	public virtual ItemAttribute Clone() { }

	public virtual void CopyFrom(ItemAttribute source) { }

	public bool get_RangeIsInverted() { }

}

