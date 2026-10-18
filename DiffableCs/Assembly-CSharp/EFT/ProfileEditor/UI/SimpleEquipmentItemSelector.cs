namespace EFT.ProfileEditor.UI;

internal sealed class SimpleEquipmentItemSelector : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_2; //Field offset: 0x8
		public static Func <>9__6_3; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal GameObject <Show>b__6_2(RectTransform x) { }

		internal bool <Show>b__6_3(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Action onItemSelected; //Field offset: 0x10
		public SimpleEquipmentItemSelector <>4__this; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <Show>b__0() { }

		internal bool <Show>b__1(RectTransform x) { }

		internal void <Show>b__4(Item item, DressRoomEquipmentItemView itemView) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_1
	{
		public Item item; //Field offset: 0x10
		public <>c__DisplayClass6_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass6_1() { }

		internal void <Show>b__5() { }

	}

	[CompilerGenerated]
	private sealed class <HideRoutine>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SimpleEquipmentItemSelector <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <HideRoutine>d__10(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private RectTransform listContainer; //Field offset: 0x70
	[SerializeField]
	private DressRoomEquipmentItemView itemTemplate; //Field offset: 0x78
	[SerializeField]
	private Button clearButton; //Field offset: 0x80
	[SerializeField]
	private Button backButton; //Field offset: 0x88
	[SerializeField]
	private ValidationInputField inputField; //Field offset: 0x90
	private ViewList _equipmentItemViews; //Field offset: 0x98

	public SimpleEquipmentItemSelector() { }

	public void Equip(Item item) { }

	private void Hide() { }

	[IteratorStateMachine(typeof(<HideRoutine>d__10))]
	private IEnumerator HideRoutine() { }

	private void Search(string value) { }

	public void Show(string profileName, Item equipped, Item[] items, Action onItemSelected) { }

}

