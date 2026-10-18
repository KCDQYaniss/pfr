namespace EFT.ProfileEditor.UI;

public sealed class EquipmentItemPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public EquipmentItemPanel <>4__this; //Field offset: 0x10
		public string profileName; //Field offset: 0x18
		public Item[] items; //Field offset: 0x20
		public Action onItemSelected; //Field offset: 0x28

		public <>c__DisplayClass6_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private CustomTextMeshProUGUI _caption; //Field offset: 0x70
	[SerializeField]
	private Button _button; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _buttonLabel; //Field offset: 0x80
	[SerializeField]
	private SimpleEquipmentItemSelector _selector; //Field offset: 0x88
	private Item _equipped; //Field offset: 0x90

	public EquipmentItemPanel() { }

	public void Equip(Item item) { }

	private static string GetLabel(Item x) { }

	public void Show(string profileName, Item equipped, Item[] items, Action onItemSelected) { }

}

