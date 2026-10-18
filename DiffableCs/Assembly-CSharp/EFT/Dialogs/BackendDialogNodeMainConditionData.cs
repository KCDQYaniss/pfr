namespace EFT.Dialogs;

public sealed class BackendDialogNodeMainConditionData
{
	[CompilerGenerated]
	private sealed class <GetConditions>d__13`1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public BackendDialogNodeMainConditionData <>4__this; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

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
		public <GetConditions>d__13`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

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
	private MongoID <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ELogicalCompareMethod <CompareMethod>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private IReadOnlyList <SubGroups>k__BackingField; //Field offset: 0x30

	[JsonProperty("operator")]
	public private ELogicalCompareMethod CompareMethod
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("id")]
	public private MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	[JsonProperty("conditions")]
	public private IReadOnlyList SubGroups
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonConstructor]
	public BackendDialogNodeMainConditionData(MongoID id, ELogicalCompareMethod compareMethod, IReadOnlyList subGroups) { }

	[CompilerGenerated]
	public ELogicalCompareMethod get_CompareMethod() { }

	[CompilerGenerated]
	public MongoID get_Id() { }

	[CompilerGenerated]
	public IReadOnlyList get_SubGroups() { }

	[IteratorStateMachine(typeof(<GetConditions>d__13`1))]
	public IEnumerable GetConditions() { }

	[CompilerGenerated]
	private void set_CompareMethod(ELogicalCompareMethod value) { }

	[CompilerGenerated]
	private void set_Id(MongoID value) { }

	[CompilerGenerated]
	private void set_SubGroups(IReadOnlyList value) { }

}

