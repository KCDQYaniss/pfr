namespace EFT.Ballistics;

public static class TrajectoryCalculatorHistory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TrajectoryInfo[] <.cctor>b__1_0() { }

	}

	private static ObjectPool _historyPool; //Field offset: 0x0

	public static TrajectoryInfo[] Withdraw
	{
		 get { } //Length: 188
	}

	private static TrajectoryCalculatorHistory() { }

	public static TrajectoryInfo[] get_Withdraw() { }

	public static void Return(TrajectoryInfo[] history) { }

}

