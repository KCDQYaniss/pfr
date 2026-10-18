namespace EFT.UI;

public sealed class QuestItemContextInteraction : BaseItemContextInteractions
{
	[CompilerGenerated]
	private sealed class <get_AvailableInteractions>d__4 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EItemInfoButton <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public QuestItemContextInteraction <>4__this; //Field offset: 0x20
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
		public <get_AvailableInteractions>d__4(int <>1__state) { }

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
		[IteratorStateMachine(typeof(<get_AvailableInteractions>d__4))]
		 get { } //Length: 175
	}

	public virtual bool ExaminationRequired
	{
		 get { } //Length: 3
	}

	private static QuestItemContextInteraction() { }

	public QuestItemContextInteraction(ItemContext itemContext, ItemUiContext itemUiContext, Action closeAction = null) { }

	[IteratorStateMachine(typeof(<get_AvailableInteractions>d__4))]
	protected virtual IEnumerable get_AvailableInteractions() { }

	public virtual bool get_ExaminationRequired() { }

	protected virtual void PlayTape() { }

}

