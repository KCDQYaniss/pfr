namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public abstract class JContainer : JToken, IList, ICollection, IEnumerable, IEnumerable, ITypedList, IBindingList, ICollection, IList, INotifyCollectionChanged
{
	[CompilerGenerated]
	private sealed class <GetDescendants>d__36 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private JToken <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private bool self; //Field offset: 0x24
		public bool <>3__self; //Field offset: 0x25
		[Nullable(0)]
		public JContainer <>4__this; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerator <>7__wrap1; //Field offset: 0x30
		[Nullable(0)]
		private JToken <o>5__3; //Field offset: 0x38
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerator <>7__wrap3; //Field offset: 0x40

		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
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
		public <GetDescendants>d__36(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[DebuggerHidden]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

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
	private struct <ReadContentFromAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		[Nullable(0)]
		public JContainer <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public JsonLoadSettings settings; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		[Nullable(0)]
		private IJsonLineInfo <lineInfo>5__2; //Field offset: 0x40
		[Nullable(0)]
		private JContainer <parent>5__3; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50
		[Nullable(0)]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadTokenFromAsync>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public JContainer <>4__this; //Field offset: 0x30
		[Nullable(0)]
		public JsonLoadSettings options; //Field offset: 0x38
		private int <startDepth>5__2; //Field offset: 0x40
		[Nullable(0)]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Nullable(2)]
	internal ListChangedEventHandler _listChanged; //Field offset: 0x30
	[Nullable(2)]
	internal AddingNewEventHandler _addingNew; //Field offset: 0x38
	[Nullable(2)]
	internal NotifyCollectionChangedEventHandler _collectionChanged; //Field offset: 0x40
	[Nullable(2)]
	private object _syncRoot; //Field offset: 0x48
	private bool _busy; //Field offset: 0x50

	public event AddingNewEventHandler AddingNew
	{
		 add { } //Length: 224
		 remove { } //Length: 224
	}

	public override event NotifyCollectionChangedEventHandler CollectionChanged
	{
		 add { } //Length: 224
		 remove { } //Length: 224
	}

	public override event ListChangedEventHandler ListChanged
	{
		 add { } //Length: 224
		 remove { } //Length: 224
	}

	protected abstract IList ChildrenTokens
	{
		 get { } //Length: 0
	}

	public override int Count
	{
		 get { } //Length: 96
	}

	[Nullable(2)]
	public virtual JToken First
	{
		[NullableContext(2)]
		 get { } //Length: 146
	}

	public virtual bool HasValues
	{
		 get { } //Length: 102
	}

	[Nullable(2)]
	public virtual JToken Last
	{
		[NullableContext(2)]
		 get { } //Length: 147
	}

	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item
	{
		private get { } //Length: 20
		private set { } //Length: 20
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 170
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 20
		private set { } //Length: 67
	}

	private override bool System.ComponentModel.IBindingList.AllowEdit
	{
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.AllowNew
	{
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.AllowRemove
	{
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.IsSorted
	{
		private get { } //Length: 3
	}

	private override ListSortDirection System.ComponentModel.IBindingList.SortDirection
	{
		private get { } //Length: 3
	}

	[Nullable(2)]
	private override PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
	{
		[NullableContext(2)]
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.SupportsChangeNotification
	{
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.SupportsSearching
	{
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.SupportsSorting
	{
		private get { } //Length: 3
	}

	internal JContainer() { }

	internal JContainer(JContainer other) { }

	[NullableContext(2)]
	public override void Add(object content) { }

	public void add_AddingNew(AddingNewEventHandler value) { }

	public override void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	public override void add_ListChanged(ListChangedEventHandler value) { }

	internal void AddAndSkipParentCheck(JToken token) { }

	[NullableContext(2)]
	public void AddFirst(object content) { }

	internal void CheckReentrancy() { }

	public virtual JEnumerable Children() { }

	internal override void ClearItems() { }

	[NullableContext(2)]
	internal override bool ContainsItem(JToken item) { }

	internal bool ContentsEqual(JContainer container) { }

	internal int ContentsHashCode() { }

	internal override void CopyItemsTo(Array array, int arrayIndex) { }

	internal override IList CreateChildrenCollection() { }

	internal static JToken CreateFromContent(object content) { }

	public JsonWriter CreateWriter() { }

	public IEnumerable Descendants() { }

	public IEnumerable DescendantsAndSelf() { }

	internal JToken EnsureParentToken(JToken item, bool skipParentCheck) { }

	private JToken EnsureValue(object value) { }

	protected abstract IList get_ChildrenTokens() { }

	public override int get_Count() { }

	[NullableContext(2)]
	public virtual JToken get_First() { }

	public virtual bool get_HasValues() { }

	[NullableContext(2)]
	public virtual JToken get_Last() { }

	[IteratorStateMachine(typeof(<GetDescendants>d__36))]
	internal IEnumerable GetDescendants(bool self) { }

	internal override JToken GetItem(int index) { }

	[NullableContext(2)]
	internal abstract int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck) { }

	[NullableContext(2)]
	internal bool IsMultiContent(object content) { }

	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	public void Merge(object content, JsonMergeSettings settings) { }

	public void Merge(object content) { }

	internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings) { }

	internal abstract void MergeItem(object content, JsonMergeSettings settings) { }

	protected override void OnAddingNew(AddingNewEventArgs e) { }

	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	protected override void OnListChanged(ListChangedEventArgs e) { }

	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	[AsyncStateMachine(typeof(<ReadContentFromAsync>d__1))]
	private Task ReadContentFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	[NullableContext(2)]
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	[AsyncStateMachine(typeof(<ReadTokenFromAsync>d__0))]
	internal Task ReadTokenFromAsync(JsonReader reader, JsonLoadSettings options, CancellationToken cancellationToken = null) { }

	public void remove_AddingNew(AddingNewEventHandler value) { }

	public override void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	public override void remove_ListChanged(ListChangedEventHandler value) { }

	public void RemoveAll() { }

	[NullableContext(2)]
	internal override bool RemoveItem(JToken item) { }

	internal override void RemoveItemAt(int index) { }

	public void ReplaceAll(object content) { }

	internal override void ReplaceItem(JToken existing, JToken replacement) { }

	[NullableContext(2)]
	internal override void SetItem(int index, JToken item) { }

	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	private override JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	private override int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

	private override void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	private override object System.ComponentModel.IBindingList.AddNew() { }

	private override void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	private override int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	private override bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	private override bool System.ComponentModel.IBindingList.get_AllowNew() { }

	private override bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	private override bool System.ComponentModel.IBindingList.get_IsSorted() { }

	private override ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	[NullableContext(2)]
	private override PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	private override bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	private override bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	private override bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	private override void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	private override void System.ComponentModel.IBindingList.RemoveSort() { }

	private override PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	private override string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	[NullableContext(2)]
	internal bool TryAdd(object content) { }

	[NullableContext(2)]
	internal bool TryAddInternal(int index, object content, bool skipParentCheck) { }

	internal override void ValidateToken(JToken o, JToken existing) { }

	[NullableContext(2)]
	public virtual IEnumerable Values() { }

}

