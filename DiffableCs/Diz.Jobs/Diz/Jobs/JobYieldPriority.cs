namespace Diz.Jobs;

[Extension]
public static class JobYieldPriority
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static YieldDelegate <>9__1_0; //Field offset: 0x8
		public static YieldDelegate <>9__3_0; //Field offset: 0x10
		public static YieldDelegate <>9__5_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal IJobAwaitable <get_General>b__1_0(JobYield jobYield) { }

		internal IJobAwaitable <get_Immediate>b__5_0(JobYield jobYield) { }

		internal IJobAwaitable <get_Low>b__3_0(JobYield jobYield) { }

	}


	public static YieldDelegate General
	{
		 get { } //Length: 318
	}

	public static YieldDelegate Immediate
	{
		 get { } //Length: 318
	}

	public static YieldDelegate Low
	{
		 get { } //Length: 318
	}

	public static YieldDelegate get_General() { }

	public static YieldDelegate get_Immediate() { }

	public static YieldDelegate get_Low() { }

	public static YieldDelegate GetYieldDelegate(EJobPriority priority) { }

	[Extension]
	public static EJobPriority Priority(YieldDelegate priorityDelegate) { }

}

