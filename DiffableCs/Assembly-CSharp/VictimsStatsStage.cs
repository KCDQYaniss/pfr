//Type is in global namespace

public class VictimsStatsStage : FinalStatisticScreenStage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8
		public static Func <>9__2_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal DogtagComponent <ShowState>b__2_0(BarterOther x) { }

		internal bool <ShowState>b__2_1(DogtagComponent x) { }

	}

	[SerializeField]
	private StatisticPanel _statisticPanel; //Field offset: 0xC0
	[SerializeField]
	private SessionResultKillList _killListVictim; //Field offset: 0xC8

	public VictimsStatsStage() { }

	public virtual Task ShowState() { }

}

