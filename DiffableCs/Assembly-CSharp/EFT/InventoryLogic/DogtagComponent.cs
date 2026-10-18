namespace EFT.InventoryLogic;

public sealed class DogtagComponent : ItemComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__15_1; //Field offset: 0x8
		public static Func <>9__15_3; //Field offset: 0x10
		public static Func <>9__15_5; //Field offset: 0x18
		public static Func <>9__15_7; //Field offset: 0x20
		public static Func <>9__15_9; //Field offset: 0x28
		public static Func <>9__15_11; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__15_1() { }

		internal EItemAttributeDisplayType <.ctor>b__15_11() { }

		internal EItemAttributeDisplayType <.ctor>b__15_3() { }

		internal EItemAttributeDisplayType <.ctor>b__15_5() { }

		internal EItemAttributeDisplayType <.ctor>b__15_7() { }

		internal EItemAttributeDisplayType <.ctor>b__15_9() { }

	}

	public const string BearDogtagsTemplate = "59f32bb586f774757e1e8442"; //Field offset: 0x0
	public const string UsecDogtagsTemplate = "59f32c3b86f77472a31742f0"; //Field offset: 0x0
	public string GroupId; //Field offset: 0x18
	[Diffable]
	public string AccountId; //Field offset: 0x20
	[Diffable]
	public string ProfileId; //Field offset: 0x28
	[Diffable]
	public string Nickname; //Field offset: 0x30
	[Diffable]
	public EPlayerSide Side; //Field offset: 0x38
	[Diffable]
	public int Level; //Field offset: 0x3C
	[Diffable]
	public DateTime Time; //Field offset: 0x40
	[Diffable]
	public string Status; //Field offset: 0x48
	[Diffable]
	public string KillerAccountId; //Field offset: 0x50
	[Diffable]
	public string KillerProfileId; //Field offset: 0x58
	[Diffable]
	public string KillerName; //Field offset: 0x60
	[Diffable]
	public string WeaponName; //Field offset: 0x68
	[Diffable]
	public bool CarriedByGroupMember; //Field offset: 0x70

	public DogtagComponent(Item item) { }

	[CompilerGenerated]
	private string <.ctor>b__15_0() { }

	[CompilerGenerated]
	private string <.ctor>b__15_10() { }

	[CompilerGenerated]
	private string <.ctor>b__15_2() { }

	[CompilerGenerated]
	private string <.ctor>b__15_4() { }

	[CompilerGenerated]
	private string <.ctor>b__15_6() { }

	[CompilerGenerated]
	private string <.ctor>b__15_8() { }

	public DogTagComponentDescriptor ToDescriptor() { }

}

