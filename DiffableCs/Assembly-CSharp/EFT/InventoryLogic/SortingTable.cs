namespace EFT.InventoryLogic;

public sealed class SortingTable : Stash
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__0_0(Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <get_Containers>d__7 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IContainer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public SortingTable <>4__this; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30

		private override IContainer System.Collections.Generic.IEnumerator<EFT.InventoryLogic.IContainer>.Current
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
		public <get_Containers>d__7(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.IContainer>.GetEnumerator() { }

		[DebuggerHidden]
		private override IContainer System.Collections.Generic.IEnumerator<EFT.InventoryLogic.IContainer>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public readonly Slot BuildSlot; //Field offset: 0xA8

	public virtual IEnumerable Containers
	{
		[IteratorStateMachine(typeof(<get_Containers>d__7))]
		 get { } //Length: 175
	}

	public bool IsActive
	{
		 get { } //Length: 116
	}

	public bool IsNotEmpty
	{
		 get { } //Length: 69
	}

	public SortingTable(string id, SortingTableTemplate template) { }

	public void ClampSize(int width, int height) { }

	public void Close() { }

	[IteratorStateMachine(typeof(<get_Containers>d__7))]
	public virtual IEnumerable get_Containers() { }

	public bool get_IsActive() { }

	public bool get_IsNotEmpty() { }

}

