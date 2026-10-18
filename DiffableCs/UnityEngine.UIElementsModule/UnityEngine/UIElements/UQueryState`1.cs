namespace UnityEngine.UIElements;

public struct UQueryState`1 : IEnumerable, IEnumerable, IEquatable
{
	private class ActionQueryMatcher : UQueryMatcher
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private Action <callBack>k__BackingField; //Field offset: 0x0

		internal Action callBack
		{
			[CompilerGenerated]
			internal get { } //Length: 5
		}

		public ActionQueryMatcher() { }

		[CompilerGenerated]
		internal Action get_callBack() { }

		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	}

	internal struct Enumerator : IEnumerator, IEnumerator, IDisposable
	{
		private List iterationList; //Field offset: 0x0
		private int currentIndex; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 222
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 54
		}

		internal Enumerator(UQueryState queryState) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private class ListQueryMatcher`1 : UQueryMatcher
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private List <matches>k__BackingField; //Field offset: 0x0

		public List matches
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public ListQueryMatcher`1() { }

		[CompilerGenerated]
		public List get_matches() { }

		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

		public void Reset() { }

		[CompilerGenerated]
		public void set_matches(List value) { }

	}

	private static ActionQueryMatcher s_Action; //Field offset: 0x0
	private static readonly ListQueryMatcher s_List; //Field offset: 0x0
	private static readonly ListQueryMatcher s_EnumerationList; //Field offset: 0x0
	private readonly VisualElement m_Element; //Field offset: 0x0
	internal readonly List m_Matchers; //Field offset: 0x0

	private static UQueryState`1() { }

	internal UQueryState`1(VisualElement element, List matchers) { }

	public override bool Equals(UQueryState other) { }

	public virtual bool Equals(object obj) { }

	public T First() { }

	public Enumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	public UQueryState RebuildOn(VisualElement element) { }

	private T Single(SingleQueryMatcher matcher) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

