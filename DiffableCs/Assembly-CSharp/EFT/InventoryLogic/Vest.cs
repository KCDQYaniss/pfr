namespace EFT.InventoryLogic;

public class Vest : SearchableItem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8
		public static Func <>9__2_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__2_0(Slot slot) { }

		internal bool <.ctor>b__2_1(Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <get_ItemInteractionButtons>d__4 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EItemInfoButton <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public Vest <>4__this; //Field offset: 0x20
		private IEnumerator <>7__wrap1; //Field offset: 0x28

		private override EItemInfoButton System.Collections.Generic.IEnumerator<EFT.InventoryLogic.EItemInfoButton>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <get_ItemInteractionButtons>d__4(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.EItemInfoButton>.GetEnumerator() { }

		[DebuggerHidden]
		private override EItemInfoButton System.Collections.Generic.IEnumerator<EFT.InventoryLogic.EItemInfoButton>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[Component]
	public readonly RepairableComponent Repairable; //Field offset: 0xA0
	[Component]
	public BuffComponent Buff; //Field offset: 0xA8

	public virtual IEnumerable ItemInteractionButtons
	{
		[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__4))]
		 get { } //Length: 175
	}

	public Vest(string id, VestTemplate template) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable <>n__0() { }

	[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__4))]
	public virtual IEnumerable get_ItemInteractionButtons() { }

	[OnDeserializing]
	private void OnDeserializing(StreamingContext context) { }

}

