namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public class JArray : JContainer, IList, ICollection, IEnumerable, IEnumerable
{
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
		private JArray <a>5__2; //Field offset: 0x38
		[Nullable(0)]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteToAsync>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonWriter writer; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public JArray <>4__this; //Field offset: 0x30
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public JsonConverter[] converters; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		private int <i>5__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly List _values; //Field offset: 0x58

	protected virtual IList ChildrenTokens
	{
		 get { } //Length: 5
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	[Nullable(2)]
	public virtual JToken Item
	{
		 get { } //Length: 363
		 set { } //Length: 383
	}

	public override JToken Item
	{
		 get { } //Length: 20
		 set { } //Length: 20
	}

	public virtual JTokenType Type
	{
		 get { } //Length: 6
	}

	public JArray() { }

	public JArray(JArray other) { }

	public JArray(object[] content) { }

	public JArray(object content) { }

	public override void Add(JToken item) { }

	public override void Clear() { }

	internal virtual JToken CloneToken() { }

	public override bool Contains(JToken item) { }

	public override void CopyTo(JToken[] array, int arrayIndex) { }

	internal virtual bool DeepEquals(JToken node) { }

	public static JArray FromObject(object o, JsonSerializer jsonSerializer) { }

	public static JArray FromObject(object o) { }

	protected virtual IList get_ChildrenTokens() { }

	public override bool get_IsReadOnly() { }

	public virtual JToken get_Item(object key) { }

	public override JToken get_Item(int index) { }

	public virtual JTokenType get_Type() { }

	internal virtual int GetDeepHashCode() { }

	public override IEnumerator GetEnumerator() { }

	public override int IndexOf(JToken item) { }

	[NullableContext(2)]
	internal virtual int IndexOfItem(JToken item) { }

	public override void Insert(int index, JToken item) { }

	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	public static JArray Load(JsonReader reader) { }

	public static Task LoadAsync(JsonReader reader, CancellationToken cancellationToken = null) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__2))]
	public static Task LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	internal virtual void MergeItem(object content, JsonMergeSettings settings) { }

	public static JArray Parse(string json) { }

	public static JArray Parse(string json, JsonLoadSettings settings) { }

	public override bool Remove(JToken item) { }

	public override void RemoveAt(int index) { }

	public override void set_Item(int index, JToken value) { }

	public virtual void set_Item(object key, JToken value) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[AsyncStateMachine(typeof(<WriteToAsync>d__0))]
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

