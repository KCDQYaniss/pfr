//Type is in global namespace

public class AchievementsStatsStage : FinalStatisticScreenStage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x8
		public static Func <>9__7_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetUnlockedAchievements>b__7_0(Achievement a) { }

		internal DateTime <GetUnlockedAchievements>b__7_1(Achievement a) { }

	}

	[CompilerGenerated]
	private sealed class <ShowAchievements>d__6 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AchievementsStatsStage <>4__this; //Field offset: 0x20
		private Enumerator <>7__wrap1; //Field offset: 0x28

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
		public <ShowAchievements>d__6(int <>1__state) { }

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

	[SerializeField]
	private FinalStatisticsAchievement _achievementViewTemplate; //Field offset: 0xC0
	[SerializeField]
	private StatisticPanel _statisticPanel; //Field offset: 0xC8
	[SerializeField]
	private FinalAchievementTooltip _finalAchievementTooltip; //Field offset: 0xD0

	private AchievementsController AchievementsController
	{
		private get { } //Length: 30
	}

	public AchievementsStatsStage() { }

	private AchievementsController get_AchievementsController() { }

	private List GetUnlockedAchievements() { }

	[IteratorStateMachine(typeof(<ShowAchievements>d__6))]
	private IEnumerator ShowAchievements() { }

	public virtual Task ShowState() { }

}

