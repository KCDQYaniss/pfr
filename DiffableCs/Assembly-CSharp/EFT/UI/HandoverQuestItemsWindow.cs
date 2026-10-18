namespace EFT.UI;

public sealed class HandoverQuestItemsWindow : HandoverSelectItemsWindow
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <get_SelectedItemsCount>b__2_0(Item x) { }

	}

	[SerializeField]
	private TextMeshProUGUI _count; //Field offset: 0x138
	private double _neededValue; //Field offset: 0x140
	private bool _allowPartialHandover; //Field offset: 0x148
	private Action _acceptAction; //Field offset: 0x150
	private Condition _condition; //Field offset: 0x158

	private int SelectedItemsCount
	{
		private get { } //Length: 387
	}

	public HandoverQuestItemsWindow() { }

	protected virtual void Accept() { }

	protected virtual void ClearSelectedList() { }

	private int get_SelectedItemsCount() { }

	protected virtual bool IsActive(Item item, out string tooltip) { }

	protected virtual bool IsSelected(Item item) { }

	public DialogWindowContext Show(Condition condition, double currentValue, Item[] items, Profile profile, ItemController controller, Action acceptAction, bool canShowCloseButton = true, bool allowPartialHandover = true) { }

	protected virtual void TrySelectItemToHandover(Item item) { }

}

