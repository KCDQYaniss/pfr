namespace EFT.UI;

[UsedImplicitly]
public sealed class MasteringScreen : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_1; //Field offset: 0x8
		public static Func <>9__13_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <Show>b__13_1(KeyValuePair mastering) { }

		internal string <Show>b__13_2(KeyValuePair masteringData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public MasteringScreen <>4__this; //Field offset: 0x10
		public Profile profile; //Field offset: 0x18
		public InventoryController inventoryController; //Field offset: 0x20

		public <>c__DisplayClass13_0() { }

		internal void <Show>b__3(MasteringList x) { }

		internal void <Show>b__4(MasteringThumbs x) { }

		internal void <Show>b__5() { }

		internal void <Show>b__6() { }

		internal void <Show>g__OnNewWeaponMastered|0(Mastering newMastering) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_1
	{
		public KeyValuePair mastering; //Field offset: 0x10

		public <>c__DisplayClass13_1() { }

		internal KeyValuePair <Show>b__7(string templateId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public int index; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <GetAcceptableWeaponsCount>b__0(KeyValuePair skill) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__GetItemTemplateText; //Field offset: 0x0

	}

	private static List _masterings; //Field offset: 0x0
	[SerializeField]
	private MasteringList _masteringList; //Field offset: 0x70
	[SerializeField]
	private MasteringThumbs _masteringThumbs; //Field offset: 0x78
	[SerializeField]
	private DropDownBox _sortMethod; //Field offset: 0x80
	[SerializeField]
	private DropDownBox _filterMethod; //Field offset: 0x88
	[SerializeField]
	private TMP_InputField _searchWeaponInputField; //Field offset: 0x90
	[SerializeField]
	private Tab _listTab; //Field offset: 0x98
	[SerializeField]
	private Tab _thumbsTab; //Field offset: 0xA0
	private TabGroup _masteringViewTabGroup; //Field offset: 0xA8
	private KeyValuePair[] _flatMastering; //Field offset: 0xB0

	public static List ItemTemplates
	{
		 get { } //Length: 523
	}

	private static MasteringScreen() { }

	public MasteringScreen() { }

	[UsedImplicitly]
	private void Awake() { }

	public static List get_ItemTemplates() { }

	private int GetAcceptableWeaponsCount(int index) { }

	public static string GetItemTemplateText(string id) { }

	public void Show(Profile profile, InventoryController inventoryController) { }

}

