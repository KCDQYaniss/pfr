namespace EFT.UI;

public sealed class HideoutContextInteractions : BaseItemContextInteractions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public EAreaType areaType; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <.ctor>b__0(AreaData area) { }

		internal void <.ctor>g__OpenHideoutArea|1() { }

	}

	[CompilerGenerated]
	private sealed class <get_AvailableInteractions>d__2 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EItemInfoButton <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public HideoutContextInteractions <>4__this; //Field offset: 0x20
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
		public <get_AvailableInteractions>d__2(int <>1__state) { }

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

	private static readonly IEnumerable _interactions; //Field offset: 0x0

	protected virtual IEnumerable AvailableInteractions
	{
		[IteratorStateMachine(typeof(<get_AvailableInteractions>d__2))]
		 get { } //Length: 175
	}

	protected virtual IEnumerable SubInteractions
	{
		 get { } //Length: 78
	}

	private static HideoutContextInteractions() { }

	public HideoutContextInteractions(ItemContext itemContext, ItemUiContext itemUiContext, Action closeAction) { }

	public virtual void CreateSubInteractions(EItemInfoButton parentInteraction, ISubInteractionsWrapper subInteractionsWrapper) { }

	[IteratorStateMachine(typeof(<get_AvailableInteractions>d__2))]
	protected virtual IEnumerable get_AvailableInteractions() { }

	protected virtual IEnumerable get_SubInteractions() { }

}

