namespace EFT.UI;

public class MasteringContainer`1 : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_3; //Field offset: 0x0
		public static Func <>9__2_4; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal KeyValuePair <Show>b__2_3(KeyValuePair skill) { }

		internal DateTime <Show>b__2_4(KeyValuePair skill) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public ViewList skillPanels; //Field offset: 0x0
		public KeyValuePair[] skills; //Field offset: 0x0
		public DropDownBox filterMethod; //Field offset: 0x0
		public TMP_InputField inputField; //Field offset: 0x0
		public Func <>9__5; //Field offset: 0x0
		public Func <>9__6; //Field offset: 0x0

		public <>c__DisplayClass2_0() { }

		internal void <Show>b__0(int index) { }

		internal void <Show>b__1(int index) { }

		internal void <Show>b__2(string arg) { }

		internal bool <Show>b__5(KeyValuePair skill) { }

		internal bool <Show>b__6(KeyValuePair skill) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_1
	{
		public string arg; //Field offset: 0x0
		public <>c__DisplayClass2_0 CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass2_1() { }

		internal bool <Show>b__7(KeyValuePair skill) { }

	}

	[SerializeField]
	private Transform _skillsContainer; //Field offset: 0x0
	[SerializeField]
	private TSkillView _skillViewTemplate; //Field offset: 0x0

	public MasteringContainer`1() { }

	private static bool AcceptableFilter(KeyValuePair skill, DropDownBox filterMethod, string weaponName) { }

	private static bool AcceptableWeaponName(KeyValuePair skill, string weaponName) { }

	private static bool AcceptableWeaponType(KeyValuePair skill, DropDownBox filterMethod) { }

	protected void Show(KeyValuePair[] skills, DropDownBox sortMethod, DropDownBox filterMethod, TMP_InputField inputField, InventoryController inventoryController, Action showAction) { }

}

