namespace System.Text.Json;

[DefaultMember("Item")]
internal sealed class JsonPropertyDictionary`1
{
	[DefaultMember("Item")]
	private sealed class KeyCollection : IList, ICollection, IEnumerable, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__14 : IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x0
			private string <>2__current; //Field offset: 0x0
			public KeyCollection <>4__this; //Field offset: 0x0
			private Enumerator <>7__wrap1; //Field offset: 0x0

			private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
			public <GetEnumerator>d__14(int <>1__state) { }

			private void <>m__Finally1() { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class <System-Collections-IEnumerable-GetEnumerator>d__9 : IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x0
			private object <>2__current; //Field offset: 0x0
			public KeyCollection <>4__this; //Field offset: 0x0
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
			public <System-Collections-IEnumerable-GetEnumerator>d__9(int <>1__state) { }

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

		private readonly JsonPropertyDictionary _parent; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 35
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public override string Item
		{
			 get { } //Length: 79
			 set { } //Length: 27
		}

		public KeyCollection(JsonPropertyDictionary jsonObject) { }

		public override void Add(string propertyName) { }

		public override void Clear() { }

		public override bool Contains(string propertyName) { }

		public override void CopyTo(string[] propertyNameArray, int index) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		public override string get_Item(int index) { }

		[IteratorStateMachine(typeof(<GetEnumerator>d__14))]
		public override IEnumerator GetEnumerator() { }

		public override int IndexOf(string item) { }

		public override void Insert(int index, string item) { }

		public override void RemoveAt(int index) { }

		public override void set_Item(int index, string value) { }

		private override bool System.Collections.Generic.ICollection<System.String>.Remove(string propertyName) { }

		[IteratorStateMachine(typeof(<System-Collections-IEnumerable-GetEnumerator>d__9))]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[DefaultMember("Item")]
	private sealed class ValueCollection : IList, ICollection, IEnumerable, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__14 : IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x0
			private T <>2__current; //Field offset: 0x0
			public ValueCollection <>4__this; //Field offset: 0x0
			private Enumerator <>7__wrap1; //Field offset: 0x0

			private override T System.Collections.Generic.IEnumerator<T>.Current
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
			public <GetEnumerator>d__14(int <>1__state) { }

			private void <>m__Finally1() { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class <System-Collections-IEnumerable-GetEnumerator>d__9 : IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x0
			private object <>2__current; //Field offset: 0x0
			public ValueCollection <>4__this; //Field offset: 0x0
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
			public <System-Collections-IEnumerable-GetEnumerator>d__9(int <>1__state) { }

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

		private readonly JsonPropertyDictionary _parent; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 35
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public override T Item
		{
			 get { } //Length: 80
			 set { } //Length: 27
		}

		public ValueCollection(JsonPropertyDictionary jsonObject) { }

		public override void Add(T jsonNode) { }

		public override void Clear() { }

		public override bool Contains(T jsonNode) { }

		public override void CopyTo(T[] nodeArray, int index) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		public override T get_Item(int index) { }

		[IteratorStateMachine(typeof(<GetEnumerator>d__14))]
		public override IEnumerator GetEnumerator() { }

		public override int IndexOf(T item) { }

		public override void Insert(int index, T item) { }

		public override void RemoveAt(int index) { }

		public override void set_Item(int index, T value) { }

		private override bool System.Collections.Generic.ICollection<T>.Remove(T node) { }

		[IteratorStateMachine(typeof(<System-Collections-IEnumerable-GetEnumerator>d__9))]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private Dictionary _propertyDictionary; //Field offset: 0x0
	private readonly List _propertyList; //Field offset: 0x0
	private readonly StringComparer _stringComparer; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsReadOnly>k__BackingField; //Field offset: 0x0
	private KeyCollection _keyCollection; //Field offset: 0x0
	private ValueCollection _valueCollection; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 26
	}

	public bool IsReadOnly
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IList Keys
	{
		 get { } //Length: 258
	}

	public List List
	{
		 get { } //Length: 5
	}

	public IList Values
	{
		 get { } //Length: 23
	}

	public JsonPropertyDictionary`1(bool caseInsensitive) { }

	public JsonPropertyDictionary`1(bool caseInsensitive, int capacity) { }

	public void Add(KeyValuePair property) { }

	public void Add(string propertyName, T value) { }

	private void AddValue(string propertyName, T value) { }

	public void Clear() { }

	public bool Contains(KeyValuePair item) { }

	public bool ContainsKey(string propertyName) { }

	private bool ContainsProperty(string propertyName) { }

	internal bool ContainsValue(T value) { }

	public void CopyTo(KeyValuePair[] array, int index) { }

	private void CreateDictionaryIfThresholdMet() { }

	private int FindValueIndex(string propertyName) { }

	public int get_Count() { }

	[CompilerGenerated]
	public bool get_IsReadOnly() { }

	public IList get_Keys() { }

	public List get_List() { }

	public IList get_Values() { }

	public Enumerator GetEnumerator() { }

	public IList GetKeyCollection() { }

	public IList GetValueCollection() { }

	public T SetValue(string propertyName, T value, out bool valueAlreadyInDictionary) { }

	internal bool TryAddValue(string propertyName, T value) { }

	public bool TryGetValue(string propertyName, out T value) { }

	public bool TryRemoveProperty(string propertyName, out T existing) { }

}

