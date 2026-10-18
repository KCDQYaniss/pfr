namespace EFT.ProfileEditor.UI;

[UsedImplicitly]
public sealed class DressItemPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Func <>9__4_1; //Field offset: 0x10
		public static Func <>9__4_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <Show>b__4_0(ResourceKey x) { }

		internal string <Show>b__4_1(ResourceKey x) { }

		internal string <Show>b__4_2(ResourceKey x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public List options; //Field offset: 0x10
		public List visible; //Field offset: 0x18
		public string[] labels; //Field offset: 0x20
		public DressItemPanel <>4__this; //Field offset: 0x28
		public ResourceKey selected; //Field offset: 0x30
		public Action onPartChanged; //Field offset: 0x38

		public <>c__DisplayClass4_0() { }

		internal void <Show>g__DropdownChangeHandler|4(int index) { }

		internal void <Show>g__SearchFilter|3(string search) { }

	}

	[SerializeField]
	private DropDownBox _dropDown; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _caption; //Field offset: 0x78
	[SerializeField]
	private ValidationInputField inputField; //Field offset: 0x80
	private Dictionary _keyToItemBinding; //Field offset: 0x88

	public DressItemPanel() { }

	[CompilerGenerated]
	internal static string <Show>g__GetLabel|4_5(string path) { }

	public void Show(EBodyModelPart part, ResourceKey current, CustomizationClothing[] clothes, Action onPartChanged) { }

}

