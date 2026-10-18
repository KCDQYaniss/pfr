namespace System.Diagnostics;

[Nullable(0)]
[NullableContext(1)]
public class Activity : IDisposable
{
	[CompilerGenerated]
	private sealed class <<get_Baggage>g__Iterate|91_0>d : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private KeyValuePair <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		private Activity activity; //Field offset: 0x30
		public Activity <>3__activity; //Field offset: 0x38
		private DiagNode <current>5__2; //Field offset: 0x40

		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current
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
		public <<get_Baggage>g__Iterate|91_0>d(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

		[DebuggerHidden]
		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private sealed class BaggageLinkedList : IEnumerable, IEnumerable
	{
		private DiagNode _first; //Field offset: 0x10

		public DiagNode First
		{
			 get { } //Length: 5
		}

		public DiagNode get_First() { }

		public DiagEnumerator GetEnumerator() { }

		private override IEnumerator System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Flags]
	private enum State
	{
		None = 0,
		FormatUnknown = 0,
		FormatHierarchical = 1,
		FormatW3C = 2,
		FormatFlags = 3,
		IsStopped = 128,
	}

	public sealed class TagsLinkedList : IEnumerable, IEnumerable
	{
		private DiagNode _first; //Field offset: 0x10

		public DiagEnumerator GetEnumerator() { }

		private override IEnumerator System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private static readonly IEnumerable s_emptyBaggageTags; //Field offset: 0x0
	private static readonly IEnumerable s_emptyTagObjects; //Field offset: 0x8
	private static readonly IEnumerable s_emptyLinks; //Field offset: 0x10
	private static readonly IEnumerable s_emptyEvents; //Field offset: 0x18
	private static readonly ActivitySource s_defaultSource; //Field offset: 0x20
	private static readonly AsyncLocal s_current; //Field offset: 0x28
	private static readonly string s_uniqSuffix; //Field offset: 0x30
	private static long s_currentRootId; //Field offset: 0x38
	[CompilerGenerated]
	private static EventHandler CurrentChanged; //Field offset: 0x40
	private string _traceState; //Field offset: 0x10
	private State _state; //Field offset: 0x18
	private string _id; //Field offset: 0x20
	private string _rootId; //Field offset: 0x28
	private string _parentId; //Field offset: 0x30
	private string _parentSpanId; //Field offset: 0x38
	private string _traceId; //Field offset: 0x40
	private string _spanId; //Field offset: 0x48
	private byte _w3CIdFlags; //Field offset: 0x50
	private byte _parentTraceFlags; //Field offset: 0x51
	private TagsLinkedList _tags; //Field offset: 0x58
	private BaggageLinkedList _baggage; //Field offset: 0x60
	private Dictionary _customProperties; //Field offset: 0x68
	private Activity _previousActiveActivity; //Field offset: 0x70
	[CompilerGenerated]
	private ActivitySource <Source>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private Activity <Parent>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private TimeSpan <Duration>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private DateTime <StartTimeUtc>k__BackingField; //Field offset: 0x90

	public ActivityTraceFlags ActivityTraceFlags
	{
		 get { } //Length: 36
		 set { } //Length: 7
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 1, 2})]
	public IEnumerable Baggage
	{
		 get { } //Length: 150
	}

	[Nullable(2)]
	public static Activity Current
	{
		[NullableContext(2)]
		 get { } //Length: 122
	}

	public private TimeSpan Duration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[Nullable(2)]
	public string Id
	{
		[NullableContext(2)]
		 get { } //Length: 463
	}

	public ActivityIdFormat IdFormat
	{
		 get { } //Length: 8
	}

	public private bool IsStopped
	{
		 get { } //Length: 8
		private set { } //Length: 33
	}

	[Nullable(2)]
	public Activity Parent
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 8
	}

	[Nullable(2)]
	public string ParentId
	{
		[NullableContext(2)]
		 get { } //Length: 484
	}

	public ActivitySpanId ParentSpanId
	{
		 get { } //Length: 641
	}

	[Nullable(2)]
	public string RootId
	{
		[NullableContext(2)]
		 get { } //Length: 214
	}

	public ActivitySource Source
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ActivitySpanId SpanId
	{
		 get { } //Length: 317
	}

	public DateTime StartTimeUtc
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 1, 2})]
	public IEnumerable TagObjects
	{
		 get { } //Length: 99
	}

	public ActivityTraceId TraceId
	{
		 get { } //Length: 124
	}

	[Nullable(2)]
	public string TraceStateString
	{
		[NullableContext(2)]
		 get { } //Length: 29
	}

	private bool W3CIdFlagsSet
	{
		private get { } //Length: 8
	}

	private static Activity() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<get_Baggage>g__Iterate|91_0>d))]
	internal static IEnumerable <get_Baggage>g__Iterate|91_0(Activity activity) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public ActivityTraceFlags get_ActivityTraceFlags() { }

	public IEnumerable get_Baggage() { }

	[NullableContext(2)]
	public static Activity get_Current() { }

	[CompilerGenerated]
	public TimeSpan get_Duration() { }

	[NullableContext(2)]
	public string get_Id() { }

	public ActivityIdFormat get_IdFormat() { }

	public bool get_IsStopped() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public Activity get_Parent() { }

	[NullableContext(2)]
	public string get_ParentId() { }

	public ActivitySpanId get_ParentSpanId() { }

	[NullableContext(2)]
	public string get_RootId() { }

	[CompilerGenerated]
	public ActivitySource get_Source() { }

	public ActivitySpanId get_SpanId() { }

	[CompilerGenerated]
	public DateTime get_StartTimeUtc() { }

	public IEnumerable get_TagObjects() { }

	public ActivityTraceId get_TraceId() { }

	[NullableContext(2)]
	public string get_TraceStateString() { }

	private bool get_W3CIdFlagsSet() { }

	public object GetCustomProperty(string propertyName) { }

	private static long GetRandomNumber() { }

	private string GetRootId(string id) { }

	internal static DateTime GetUtcNow() { }

	private static bool IsW3CId(string id) { }

	private static void NotifyError(Exception exception) { }

	public void set_ActivityTraceFlags(ActivityTraceFlags value) { }

	[CompilerGenerated]
	private void set_Duration(TimeSpan value) { }

	private void set_IsStopped(bool value) { }

	private static void SetCurrent(Activity activity) { }

	public void SetCustomProperty(string propertyName, object propertyValue) { }

	public Activity SetEndTime(DateTime endTimeUtc) { }

	public void Stop() { }

	private void TrySetTraceFlagsFromParent() { }

	private bool TrySetTraceIdFromParent() { }

}

