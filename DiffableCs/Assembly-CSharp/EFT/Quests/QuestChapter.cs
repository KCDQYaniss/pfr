namespace EFT.Quests;

public sealed class QuestChapter : Quest
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8
		public static Func <>9__3_0; //Field offset: 0x10
		public static Func <>9__5_0; //Field offset: 0x18
		public static Func <>9__6_0; //Field offset: 0x20
		public static Func <>9__6_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal MongoID <.ctor>b__1_0(ConditionQuest condition) { }

		internal bool <GetActiveLinks>b__6_0(MainQuest quest) { }

		internal string <GetActiveLinks>b__6_1(MainQuest quest) { }

		internal bool <GetAllVisibleConditions>b__3_0(MainQuest quest) { }

		internal IEnumerable <GetLinks>b__5_0(QuestNote note) { }

	}

	[CompilerGenerated]
	private sealed class <GetActiveLinks>d__6 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private QuestNoteLinkItemBase <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public QuestChapter <>4__this; //Field offset: 0x28
		private QuestBook quests; //Field offset: 0x30
		public QuestBook <>3__quests; //Field offset: 0x38
		private Profile profile; //Field offset: 0x40
		public Profile <>3__profile; //Field offset: 0x48
		private List <activeQuests>5__2; //Field offset: 0x50
		private IEnumerator <>7__wrap2; //Field offset: 0x58

		private override QuestNoteLinkItemBase System.Collections.Generic.IEnumerator<EFT.Quests.QuestNoteLinkItemBase>.Current
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
		public <GetActiveLinks>d__6(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Quests.QuestNoteLinkItemBase>.GetEnumerator() { }

		[DebuggerHidden]
		private override QuestNoteLinkItemBase System.Collections.Generic.IEnumerator<EFT.Quests.QuestNoteLinkItemBase>.get_Current() { }

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
	private sealed class <GetAllVisibleConditions>d__3 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Quest", "Condition"})]
		private ValueTuple <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		public QuestChapter <>4__this; //Field offset: 0x30
		private QuestBook quests; //Field offset: 0x38
		public QuestBook <>3__quests; //Field offset: 0x40
		private bool includeInvisible; //Field offset: 0x48
		public bool <>3__includeInvisible; //Field offset: 0x49
		private IEnumerator <>7__wrap1; //Field offset: 0x50
		private MainQuest <quest>5__3; //Field offset: 0x58
		private IEnumerator <>7__wrap3; //Field offset: 0x60

		private override ValueTuple System.Collections.Generic.IEnumerator<(EFT.Quests.MainQuestQuest,EFT.Quests.ConditionCondition)>.Current
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
		public <GetAllVisibleConditions>d__3(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<(EFT.Quests.MainQuestQuest,EFT.Quests.ConditionCondition)>.GetEnumerator() { }

		[DebuggerHidden]
		private override ValueTuple System.Collections.Generic.IEnumerator<(EFT.Quests.MainQuestQuest,EFT.Quests.ConditionCondition)>.get_Current() { }

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
	private sealed class <GetNotes>d__4 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private QuestNote <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Profile profile; //Field offset: 0x28
		public Profile <>3__profile; //Field offset: 0x30
		public QuestChapter <>4__this; //Field offset: 0x38
		private IEnumerator <>7__wrap1; //Field offset: 0x40

		private override QuestNote System.Collections.Generic.IEnumerator<EFT.Quests.QuestNote>.Current
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
		public <GetNotes>d__4(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Quests.QuestNote>.GetEnumerator() { }

		[DebuggerHidden]
		private override QuestNote System.Collections.Generic.IEnumerator<EFT.Quests.QuestNote>.get_Current() { }

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
	private sealed class <GetSubQuests>d__2 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private MainQuest <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public QuestChapter <>4__this; //Field offset: 0x28
		private QuestBook quests; //Field offset: 0x30
		public QuestBook <>3__quests; //Field offset: 0x38
		private bool includeInvisible; //Field offset: 0x40
		public bool <>3__includeInvisible; //Field offset: 0x41
		private IEnumerator <>7__wrap1; //Field offset: 0x48

		private override MainQuest System.Collections.Generic.IEnumerator<EFT.Quests.MainQuest>.Current
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
		public <GetSubQuests>d__2(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Quests.MainQuest>.GetEnumerator() { }

		[DebuggerHidden]
		private override MainQuest System.Collections.Generic.IEnumerator<EFT.Quests.MainQuest>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public readonly IReadOnlyList SubQuests; //Field offset: 0x98

	public QuestChapter(QuestTemplate template, QuestStatusData statusData, Dictionary conditionCounters, bool fromServer, bool inRaid) { }

	[IteratorStateMachine(typeof(<GetActiveLinks>d__6))]
	public IEnumerable GetActiveLinks(Profile profile, QuestBook quests) { }

	[IteratorStateMachine(typeof(<GetAllVisibleConditions>d__3))]
	public IEnumerable GetAllVisibleConditions(QuestBook quests, bool includeInvisible) { }

	private IEnumerable GetLinks(Profile profile) { }

	[IteratorStateMachine(typeof(<GetNotes>d__4))]
	public IEnumerable GetNotes(Profile profile) { }

	[IteratorStateMachine(typeof(<GetSubQuests>d__2))]
	public IEnumerable GetSubQuests(QuestBook quests, bool includeInvisible) { }

}

