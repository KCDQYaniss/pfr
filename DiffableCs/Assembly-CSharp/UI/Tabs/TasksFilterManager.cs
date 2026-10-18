namespace UI.Tabs;

public class TasksFilterManager
{
	[CompilerGenerated]
	private sealed class <<ManageItems>g__AllItemTemplates|23_0>d : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IReadOnlyList[] lists; //Field offset: 0x28
		public IReadOnlyList[] <>3__lists; //Field offset: 0x30
		private IReadOnlyList[] <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private IEnumerator <>7__wrap3; //Field offset: 0x48
		private FlatItem[] <>7__wrap4; //Field offset: 0x50
		private int <>7__wrap5; //Field offset: 0x58

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
		public <<ManageItems>g__AllItemTemplates|23_0>d(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

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
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__24_0; //Field offset: 0x8
		public static Func <>9__24_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Validate>b__24_0(KeyValuePair k) { }

		internal int <Validate>b__24_1(KeyValuePair v) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass23_0
	{
		public string filter; //Field offset: 0x0

	}

	private const string SPACE = " "; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnFilterChanged; //Field offset: 0x10
	private string _filterInput; //Field offset: 0x18
	private IEnumerable _quests; //Field offset: 0x20
	private readonly Dictionary _filteredQuests; //Field offset: 0x28
	[CompilerGenerated]
	private readonly HashSet <FilterMask>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private QuestSpecificOrderComparer <Comparer>k__BackingField; //Field offset: 0x38

	public event Action OnFilterChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private QuestSpecificOrderComparer Comparer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HashSet FilterMask
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public TasksFilterManager() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<ManageItems>g__AllItemTemplates|23_0>d))]
	internal static IEnumerable <ManageItems>g__AllItemTemplates|23_0(IReadOnlyList[] lists) { }

	[CompilerGenerated]
	internal static bool <ManageItems>g__NameMatch|23_1(string id, ref <>c__DisplayClass23_0 unnamed_param_1) { }

	[CompilerGenerated]
	internal static bool <ManageItems>g__ShortNameMatch|23_2(string id, ref <>c__DisplayClass23_0 unnamed_param_1) { }

	[CompilerGenerated]
	private string <SetFilterString>g__GetMaskStr|14_0() { }

	[CompilerGenerated]
	public void add_OnFilterChanged(Action value) { }

	public bool Filter(Quest quest) { }

	[CompilerGenerated]
	public QuestSpecificOrderComparer get_Comparer() { }

	[CompilerGenerated]
	public HashSet get_FilterMask() { }

	private static void ManageDescription(Quest quest, string filter, ref EFilterSource source) { }

	private static void ManageItems(Quest quest, string filter, ref EFilterSource source) { }

	private static void ManageLocation(Quest quest, string filter, ref EFilterSource source) { }

	private static void ManageName(Quest quest, string filter, ref EFilterSource source) { }

	private static void ManageTargets(Quest quest, string filter, ref EFilterSource source) { }

	private static void ManageTrader(Quest quest, string filter, ref EFilterSource source) { }

	private static bool Match(string source, string value) { }

	[CompilerGenerated]
	public void remove_OnFilterChanged(Action value) { }

	[CompilerGenerated]
	private void set_Comparer(QuestSpecificOrderComparer value) { }

	public void SetFilterString(string value, bool force = false) { }

	public void SetQuests(IEnumerable quests) { }

	private void Validate() { }

}

