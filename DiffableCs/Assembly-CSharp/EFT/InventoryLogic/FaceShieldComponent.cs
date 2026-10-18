namespace EFT.InventoryLogic;

public class FaceShieldComponent : ItemComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__15_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__15_2() { }

	}

	internal enum EMask
	{
		NoMask = 0,
		Narrow = 1,
		Wide = 2,
	}

	[CanBeNull]
	public readonly TogglableComponent Togglable; //Field offset: 0x18
	[Diffable]
	public byte HitSeed; //Field offset: 0x20
	public readonly BindableEvent HitsChanged; //Field offset: 0x28
	private readonly IFaceShieldComponentTemplate _template; //Field offset: 0x30
	private byte _hits; //Field offset: 0x38

	public float BlindnessProtection
	{
		 get { } //Length: 78
	}

	[Diffable]
	public byte Hits
	{
		 get { } //Length: 5
		 set { } //Length: 59
	}

	public EMask Mask
	{
		 get { } //Length: 75
	}

	public FaceShieldComponent(Item item, TogglableComponent togglable, IFaceShieldComponentTemplate template) { }

	[CompilerGenerated]
	private float <.ctor>b__15_0() { }

	[CompilerGenerated]
	private string <.ctor>b__15_1() { }

	public float get_BlindnessProtection() { }

	public byte get_Hits() { }

	public EMask get_Mask() { }

	public void set_Hits(byte value) { }

	public void StoreValidationTimestamp() { }

	public bool TimestampIsValid(int frameCount) { }

}

