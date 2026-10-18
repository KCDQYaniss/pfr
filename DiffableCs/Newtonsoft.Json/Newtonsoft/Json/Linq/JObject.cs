namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public class JObject : JContainer, IDictionary, ICollection, IEnumerable, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
{
	[CompilerGenerated]
	private struct <<WriteToAsync>g__AwaitProperties|0_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public Task task; //Field offset: 0x20
		[Nullable(0)]
		public JObject <>4__this; //Field offset: 0x28
		public int i; //Field offset: 0x30
		[Nullable(0)]
		public JsonWriter Writer; //Field offset: 0x38
		public CancellationToken CancellationToken; //Field offset: 0x40
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public JsonConverter[] Converters; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func <>9__30_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal JToken <PropertyValues>b__30_0(JProperty p) { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__63 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		private KeyValuePair <>2__current; //Field offset: 0x18
		[Nullable(0)]
		public JObject <>4__this; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerator <>7__wrap1; //Field offset: 0x30

		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 74
		}

		[DebuggerHidden]
		public <GetEnumerator>d__63(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <LoadAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public JsonLoadSettings settings; //Field offset: 0x30
		[Nullable(0)]
		private JObject <o>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
	private class JObjectDynamicProxy : DynamicProxy
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			[Nullable(0)]
			public static readonly <>c <>9; //Field offset: 0x0
			[Nullable(0)]
			public static Func <>9__2_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			[NullableContext(0)]
			internal string <GetDynamicMemberNames>b__2_0(JProperty p) { }

		}


		public JObjectDynamicProxy() { }

		public virtual IEnumerable GetDynamicMemberNames(JObject instance) { }

		public virtual bool TryGetMember(JObject instance, GetMemberBinder binder, out object result) { }

		public virtual bool TrySetMember(JObject instance, SetMemberBinder binder, object value) { }

	}

	private readonly JPropertyKeyedCollection _properties; //Field offset: 0x58
	[CompilerGenerated]
	[Nullable(2)]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x60
	[CompilerGenerated]
	[Nullable(2)]
	private PropertyChangingEventHandler PropertyChanging; //Field offset: 0x68

	[Nullable(2)]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 add { } //Length: 235
		[CompilerGenerated]
		[NullableContext(2)]
		 remove { } //Length: 235
	}

	[Nullable(2)]
	public override event PropertyChangingEventHandler PropertyChanging
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 add { } //Length: 235
		[CompilerGenerated]
		[NullableContext(2)]
		 remove { } //Length: 235
	}

	protected virtual IList ChildrenTokens
	{
		 get { } //Length: 5
	}

	[Nullable(2)]
	public virtual JToken Item
	{
		 get { } //Length: 411
		 set { } //Length: 342
	}

	[Nullable(2)]
	public override JToken Item
	{
		 get { } //Length: 202
		 set { } //Length: 305
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override ICollection System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys
	{
		private get { } //Length: 89
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	private override ICollection System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values
	{
		private get { } //Length: 62
	}

	public virtual JTokenType Type
	{
		 get { } //Length: 6
	}

	public JObject() { }

	public JObject(JObject other) { }

	public JObject(object[] content) { }

	public JObject(object content) { }

	[AsyncStateMachine(typeof(<<WriteToAsync>g__AwaitProperties|0_0>d))]
	[CompilerGenerated]
	private Task <WriteToAsync>g__AwaitProperties|0_0(Task task, int i, JsonWriter Writer, CancellationToken CancellationToken, JsonConverter[] Converters) { }

	public override void Add(string propertyName, JToken value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public override void add_PropertyChanging(PropertyChangingEventHandler value) { }

	internal virtual JToken CloneToken() { }

	public override bool ContainsKey(string propertyName) { }

	internal virtual bool DeepEquals(JToken node) { }

	public static JObject FromObject(object o, JsonSerializer jsonSerializer) { }

	public static JObject FromObject(object o) { }

	protected virtual IList get_ChildrenTokens() { }

	public virtual JToken get_Item(object key) { }

	public override JToken get_Item(string propertyName) { }

	public virtual JTokenType get_Type() { }

	internal virtual int GetDeepHashCode() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__63))]
	public override IEnumerator GetEnumerator() { }

	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	[NullableContext(2)]
	public JToken GetValue(string propertyName) { }

	[NullableContext(2)]
	public JToken GetValue(string propertyName, StringComparison comparison) { }

	[NullableContext(2)]
	internal virtual int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck) { }

	internal void InternalPropertyChanged(JProperty childProperty) { }

	internal void InternalPropertyChanging(JProperty childProperty) { }

	private static bool IsNull(JToken token) { }

	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	public static JObject Load(JsonReader reader) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__2))]
	public static Task LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	public static Task LoadAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	internal virtual void MergeItem(object content, JsonMergeSettings settings) { }

	protected override void OnPropertyChanged(string propertyName) { }

	protected override void OnPropertyChanging(string propertyName) { }

	public static JObject Parse(string json) { }

	public static JObject Parse(string json, JsonLoadSettings settings) { }

	public IEnumerable Properties() { }

	public JProperty Property(string name, StringComparison comparison) { }

	public JProperty Property(string name) { }

	public JEnumerable PropertyValues() { }

	public override bool Remove(string propertyName) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public override void remove_PropertyChanging(PropertyChangingEventHandler value) { }

	public override void set_Item(string propertyName, JToken value) { }

	public virtual void set_Item(object key, JToken value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair[] array, int arrayIndex) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair item) { }

	private override ICollection System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	private override ICollection System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	[NullableContext(2)]
	private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	[NullableContext(2)]
	private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	[NullableContext(2)]
	private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	[NullableContext(2)]
	private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	public override bool TryGetValue(string propertyName, out JToken value) { }

	public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value) { }

	internal virtual void ValidateToken(JToken o, JToken existing) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

