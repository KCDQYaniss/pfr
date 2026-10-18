namespace EFT.InventoryLogic;

public class ItemAttribute
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_1; //Field offset: 0x8
		public static Func <>9__3_2; //Field offset: 0x10
		public static Func <>9__3_3; //Field offset: 0x18
		public static Func <>9__3_4; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal float <.ctor>b__3_1() { }

		internal MultiLineInfo <.ctor>b__3_2() { }

		internal string <.ctor>b__3_3() { }

		internal string <.ctor>b__3_4() { }

	}

	public Func DisplayType; //Field offset: 0x10
	public EItemAttributeLabelVariations LabelVariations; //Field offset: 0x18
	public bool LessIsGood; //Field offset: 0x1C
	public string Name; //Field offset: 0x20
	public Enum Id; //Field offset: 0x28
	public Func Base; //Field offset: 0x30
	public Func DisplayNameFunc; //Field offset: 0x38
	public Func MultiLineInfo; //Field offset: 0x40
	public Func StringValue; //Field offset: 0x48
	public Func FullStringValue; //Field offset: 0x50
	public Func Tooltip; //Field offset: 0x58
	public bool IsTextValueDisplayable; //Field offset: 0x60
	public RepairBuffAttribute Enhancement; //Field offset: 0x68
	public Func GetCustomColor; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnUpdate; //Field offset: 0x78

	public event Action OnUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public string DisplayName
	{
		 get { } //Length: 163
	}

	public ItemAttribute(Enum id) { }

	[CompilerGenerated]
	private string <.ctor>b__3_0() { }

	[CompilerGenerated]
	public void add_OnUpdate(Action value) { }

	public override ItemAttribute Clone() { }

	public override void CopyFrom(ItemAttribute source) { }

	public string get_DisplayName() { }

	[CompilerGenerated]
	public void remove_OnUpdate(Action value) { }

	public void Update() { }

}

