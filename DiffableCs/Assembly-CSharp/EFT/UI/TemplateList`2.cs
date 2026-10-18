namespace EFT.UI;

[DefaultMember("Item")]
public abstract class TemplateList`2 : IDisposable, IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public TView view; //Field offset: 0x0

		public <>c__DisplayClass18_0() { }

		internal bool <IndexOf>b__0(KeyValuePair kvp) { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__39 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private KeyValuePair <>2__current; //Field offset: 0x0
		public TemplateList <>4__this; //Field offset: 0x0
		private Enumerator <>7__wrap1; //Field offset: 0x0

		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TItem,TView>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 21
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 54
		}

		[DebuggerHidden]
		public <GetEnumerator>d__39(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TItem,TView>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <System-Collections-IEnumerable-GetEnumerator>d__40 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public TemplateList <>4__this; //Field offset: 0x0
		private Enumerator <>7__wrap1; //Field offset: 0x0

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
		public <System-Collections-IEnumerable-GetEnumerator>d__40(int <>1__state) { }

		private void <>m__Finally1() { }

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

	[CompilerGenerated]
	private bool <IsAlive>k__BackingField; //Field offset: 0x0
	protected List SortedItemsList; //Field offset: 0x0
	protected readonly Dictionary Views; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnItemsOrderChanged; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnItemAdded; //Field offset: 0x0
	private Func _itemFactory; //Field offset: 0x0
	private Func _containerAccessor; //Field offset: 0x0
	private Action _showAction; //Field offset: 0x0
	private bool _destroyOnKill; //Field offset: 0x0

	public event Action OnItemAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected event Action OnItemsOrderChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public int Count
	{
		 get { } //Length: 29
	}

	protected private bool IsAlive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[CanBeNull]
	public TView Item
	{
		 get { } //Length: 56
	}

	public List Keys
	{
		 get { } //Length: 164
	}

	protected TemplateList`2() { }

	public TView Add(TItem item) { }

	[CompilerGenerated]
	public void add_OnItemAdded(Action value) { }

	[CompilerGenerated]
	protected void add_OnItemsOrderChanged(Action value) { }

	public bool Any() { }

	public override void Clear() { }

	public bool Contains(TItem key) { }

	protected void CreateView(TItem item) { }

	public override void Dispose() { }

	public void FilterBy(Func condition = null) { }

	public int get_Count() { }

	[CompilerGenerated]
	protected bool get_IsAlive() { }

	public TView get_Item(TItem item) { }

	public List get_Keys() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__39))]
	public override IEnumerator GetEnumerator() { }

	public int IndexOf(TView view) { }

	protected void Init(List order, Func itemViewFactory, Func container, Action showAction, bool destroyOnKill = true) { }

	protected TView InstantiateViewCopy(TView template) { }

	private TItem ItemAt(int index) { }

	private void KillView(TView view) { }

	public KeyValuePair Last() { }

	public void OrderBy(Func order, IComparer comparer) { }

	public void OrderByDescending(Func order) { }

	public void Remove(TItem item) { }

	[CompilerGenerated]
	public void remove_OnItemAdded(Action value) { }

	[CompilerGenerated]
	protected void remove_OnItemsOrderChanged(Action value) { }

	[CompilerGenerated]
	private void set_IsAlive(bool value) { }

	public void SoftDispose() { }

	[IteratorStateMachine(typeof(<System-Collections-IEnumerable-GetEnumerator>d__40))]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void UpdateItems(Action updateAction) { }

	public void UpdateOrder(IEnumerable orderedItems) { }

	public TView ViewAt(int index) { }

}

