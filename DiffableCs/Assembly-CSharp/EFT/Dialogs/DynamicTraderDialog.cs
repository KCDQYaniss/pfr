namespace EFT.Dialogs;

public class DynamicTraderDialog : BaseTraderDialog
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8
		public static Func <>9__11_0; //Field offset: 0x10
		public static Func <>9__12_1; //Field offset: 0x18
		public static Func <>9__14_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <GenerateHandoverItemLine>b__14_1(Item item) { }

		internal bool <GeneratePlayerSelectSubServiceLine>b__8_0(DialogAction action) { }

		internal bool <GenerateSelectQuestNpcLine>b__12_1(DialogAction action) { }

		internal bool <GenerateSelectQuestPlayerLine>b__11_0(DialogAction action) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public string selectedQuestId; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <GenerateSelectQuestNpcLine>b__0(Quest quest) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public DialogHandoverItemAction handoverItemAction; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <GenerateHandoverItemLine>b__0(Quest quest) { }

		internal bool <GenerateHandoverItemLine>b__2(KeyValuePair checker) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public DialogFinishQuestAction finishQuestAction; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <GenerateFinishQuestLines>b__0(Quest quest) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public DialogAcceptQuestAction dialogAcceptQuestAction; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <GenerateAcceptQuestLine>b__0(Quest quest) { }

	}

	[CompilerGenerated]
	private sealed class <GenerateAcceptQuestLine>d__9 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TraderDialogTextLine <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private DialogAcceptQuestAction dialogAcceptQuestAction; //Field offset: 0x28
		public DialogAcceptQuestAction <>3__dialogAcceptQuestAction; //Field offset: 0x30
		private DialogLineTemplate lineTemplate; //Field offset: 0x38
		public DialogLineTemplate <>3__lineTemplate; //Field offset: 0x40
		public DynamicTraderDialog <>4__this; //Field offset: 0x48

		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.Current
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
		public <GenerateAcceptQuestLine>d__9(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Dialogs.TraderDialogTextLine>.GetEnumerator() { }

		[DebuggerHidden]
		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GenerateDynamicLine>d__13 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TraderDialogTextLine <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private DialogLineTemplate lineTemplate; //Field offset: 0x28
		public DialogLineTemplate <>3__lineTemplate; //Field offset: 0x30
		public DynamicTraderDialog <>4__this; //Field offset: 0x38

		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.Current
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
		public <GenerateDynamicLine>d__13(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Dialogs.TraderDialogTextLine>.GetEnumerator() { }

		[DebuggerHidden]
		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GenerateEmbeddedQuestDialogLines>d__5 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private BaseTraderDialogLine <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public DynamicTraderDialog <>4__this; //Field offset: 0x28
		private string questId; //Field offset: 0x30
		public string <>3__questId; //Field offset: 0x38
		private IEnumerator <>7__wrap1; //Field offset: 0x40
		private Nullable <dialogId>5__3; //Field offset: 0x48
		private IEnumerator <>7__wrap3; //Field offset: 0x68

		private override BaseTraderDialogLine System.Collections.Generic.IEnumerator<EFT.Dialogs.BaseTraderDialogLine>.Current
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
		public <GenerateEmbeddedQuestDialogLines>d__5(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Dialogs.BaseTraderDialogLine>.GetEnumerator() { }

		[DebuggerHidden]
		private override BaseTraderDialogLine System.Collections.Generic.IEnumerator<EFT.Dialogs.BaseTraderDialogLine>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GenerateFinishQuestLines>d__15 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TraderDialogTextLine <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private DialogFinishQuestAction finishQuestAction; //Field offset: 0x28
		public DialogFinishQuestAction <>3__finishQuestAction; //Field offset: 0x30
		private DialogLineTemplate template; //Field offset: 0x38
		public DialogLineTemplate <>3__template; //Field offset: 0x40
		public DynamicTraderDialog <>4__this; //Field offset: 0x48

		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.Current
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
		public <GenerateFinishQuestLines>d__15(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Dialogs.TraderDialogTextLine>.GetEnumerator() { }

		[DebuggerHidden]
		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GeneratePlayerSelectSubServiceLine>d__8 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TraderDialogTextLine <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public DynamicTraderDialog <>4__this; //Field offset: 0x28
		private DialogLineTemplate lineTemplate; //Field offset: 0x30
		public DialogLineTemplate <>3__lineTemplate; //Field offset: 0x38
		private ETraderServiceType <selectedSubServiceType>5__2; //Field offset: 0x40
		private ServiceData <serviceData>5__3; //Field offset: 0x48
		private int <i>5__4; //Field offset: 0x50

		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.Current
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
		public <GeneratePlayerSelectSubServiceLine>d__8(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Dialogs.TraderDialogTextLine>.GetEnumerator() { }

		[DebuggerHidden]
		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GeneratePurchaseServiceLines>d__6 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TraderDialogTextLine <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private DialogLineTemplate lineTemplate; //Field offset: 0x28
		public DialogLineTemplate <>3__lineTemplate; //Field offset: 0x30
		public DynamicTraderDialog <>4__this; //Field offset: 0x38

		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.Current
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
		public <GeneratePurchaseServiceLines>d__6(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Dialogs.TraderDialogTextLine>.GetEnumerator() { }

		[DebuggerHidden]
		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GenerateSelectQuestLines>d__10 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TraderDialogTextLine <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private DialogLineTemplate lineTemplate; //Field offset: 0x28
		public DialogLineTemplate <>3__lineTemplate; //Field offset: 0x30
		public DynamicTraderDialog <>4__this; //Field offset: 0x38
		private IEnumerator <>7__wrap1; //Field offset: 0x40

		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.Current
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
		public <GenerateSelectQuestLines>d__10(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Dialogs.TraderDialogTextLine>.GetEnumerator() { }

		[DebuggerHidden]
		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GenerateSelectSubServiceLines>d__7 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TraderDialogTextLine <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private DialogLineTemplate lineTemplate; //Field offset: 0x28
		public DialogLineTemplate <>3__lineTemplate; //Field offset: 0x30
		public DynamicTraderDialog <>4__this; //Field offset: 0x38
		private DialogSelectSubServiceAction selectSubServiceAction; //Field offset: 0x40
		public DialogSelectSubServiceAction <>3__selectSubServiceAction; //Field offset: 0x48
		private IEnumerator <>7__wrap1; //Field offset: 0x50

		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.Current
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
		public <GenerateSelectSubServiceLines>d__7(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Dialogs.TraderDialogTextLine>.GetEnumerator() { }

		[DebuggerHidden]
		private override TraderDialogTextLine System.Collections.Generic.IEnumerator<EFT.Dialogs.TraderDialogTextLine>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	protected override bool CanBeEmpty
	{
		 get { } //Length: 3
	}

	public DynamicTraderDialog(TraderDialogTemplate template, IDialogContext context) { }

	private void CheckEmptyLines(List lines) { }

	[IteratorStateMachine(typeof(<GenerateAcceptQuestLine>d__9))]
	private IEnumerable GenerateAcceptQuestLine(DialogLineTemplate lineTemplate, DialogAcceptQuestAction dialogAcceptQuestAction) { }

	[IteratorStateMachine(typeof(<GenerateDynamicLine>d__13))]
	private IEnumerable GenerateDynamicLine(DialogLineTemplate lineTemplate) { }

	[IteratorStateMachine(typeof(<GenerateEmbeddedQuestDialogLines>d__5))]
	private IEnumerable GenerateEmbeddedQuestDialogLines(string questId) { }

	private TraderDialogTextLine GenerateFallbackLine() { }

	[IteratorStateMachine(typeof(<GenerateFinishQuestLines>d__15))]
	private IEnumerable GenerateFinishQuestLines(DialogLineTemplate template, DialogFinishQuestAction finishQuestAction) { }

	private TraderDialogTextLine GenerateHandoverItemLine(DialogLineTemplate lineTemplate, DialogHandoverItemAction handoverItemAction) { }

	[IteratorStateMachine(typeof(<GeneratePlayerSelectSubServiceLine>d__8))]
	private IEnumerable GeneratePlayerSelectSubServiceLine(DialogLineTemplate lineTemplate) { }

	[IteratorStateMachine(typeof(<GeneratePurchaseServiceLines>d__6))]
	private IEnumerable GeneratePurchaseServiceLines(DialogLineTemplate lineTemplate) { }

	[IteratorStateMachine(typeof(<GenerateSelectQuestLines>d__10))]
	private IEnumerable GenerateSelectQuestLines(DialogLineTemplate lineTemplate) { }

	private TraderDialogTextLine GenerateSelectQuestNpcLine(DialogLineTemplate lineTemplate) { }

	private TraderDialogTextLine GenerateSelectQuestPlayerLine(Quest quest, DialogLineTemplate lineTemplate) { }

	[IteratorStateMachine(typeof(<GenerateSelectSubServiceLines>d__7))]
	private IEnumerable GenerateSelectSubServiceLines(DialogLineTemplate lineTemplate, DialogSelectSubServiceAction selectSubServiceAction) { }

	protected override bool get_CanBeEmpty() { }

}

