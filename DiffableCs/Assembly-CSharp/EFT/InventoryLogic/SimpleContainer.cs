namespace EFT.InventoryLogic;

public class SimpleContainer : CompoundItem
{
	[CompilerGenerated]
	private sealed class <get_ItemInteractionButtons>d__5 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EItemInfoButton <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public SimpleContainer <>4__this; //Field offset: 0x20
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
		public <get_ItemInteractionButtons>d__5(int <>1__state) { }

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
	public readonly TagComponent Tag; //Field offset: 0x90

	public virtual bool IsContainer
	{
		 get { } //Length: 3
	}

	public virtual IEnumerable ItemInteractionButtons
	{
		[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__5))]
		 get { } //Length: 175
	}

	public SimpleContainer(string id, SimpleContainerTemplate template) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable <>n__0() { }

	public virtual bool get_IsContainer() { }

	[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__5))]
	public virtual IEnumerable get_ItemInteractionButtons() { }

}

