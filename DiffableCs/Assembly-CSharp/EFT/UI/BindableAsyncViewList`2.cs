namespace EFT.UI;

public sealed class BindableAsyncViewList`2 : AsyncViewList
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TItem <OrderViewList>b__14_0(TItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public BindableAsyncViewList <>4__this; //Field offset: 0x0
		public Func template; //Field offset: 0x0

		public <>c__DisplayClass7_0() { }

		internal TView <InitImmediate>g__ViewFactory|0(TItem item) { }

	}

	[CompilerGenerated]
	private struct <Init>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BindableAsyncViewList <>4__this; //Field offset: 0x0
		public IBindableList items; //Field offset: 0x0
		public Func template; //Field offset: 0x0
		public Func container; //Field offset: 0x0
		public Action showAction; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BindableAsyncViewList <>4__this; //Field offset: 0x0
		public IBindableList items; //Field offset: 0x0
		public IComparer comparer; //Field offset: 0x0
		public Func template; //Field offset: 0x0
		public Func container; //Field offset: 0x0
		public Action showAction; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private IBindableList _items; //Field offset: 0x0
	private IComparer _comparer; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnRemove; //Field offset: 0x0

	public event Action OnRemove
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BindableAsyncViewList`2() { }

	[CompilerGenerated]
	public void add_OnRemove(Action value) { }

	public virtual void Dispose() { }

	private List GetOrderedItems(IEnumerable items) { }

	[AsyncStateMachine(typeof(<Init>d__5))]
	public Task Init(IBindableList items, Func template, Func container, Action showAction) { }

	[AsyncStateMachine(typeof(<Init>d__6))]
	public Task Init(IBindableList items, IComparer comparer, Func template, Func container, Action showAction) { }

	private void Initialize(IBindableList items, IComparer comparer) { }

	public void InitImmediate(IBindableList items, IComparer comparer, Func template, Func container, Action showAction) { }

	private void ItemAddedHandler(TItem item) { }

	private void ItemRemovedHandler(TItem item) { }

	private void ItemsAddedHandler(IEnumerable items) { }

	private void ItemsRemovedHandler() { }

	public void OrderViewList() { }

	[CompilerGenerated]
	public void remove_OnRemove(Action value) { }

}

