namespace Unity.Jobs;

[Extension]
public static class IJobFilterExtensions
{
	public struct JobFilterProducer`1
	{
		[CompilerGenerated]
		private static class <>O
		{
			public static ExecuteJobFunction <0>__Execute; //Field offset: 0x0

		}

		internal sealed class ExecuteJobFunction : MulticastDelegate
		{

			public ExecuteJobFunction(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(ref JobWrapper jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref JobWrapper jobWrapper, ref JobRanges ranges, IAsyncResult result) { }

			public override void Invoke(ref JobWrapper jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		internal struct JobWrapper
		{
			[NativeDisableParallelForRestriction]
			public NativeList outputIndices; //Field offset: 0x0
			public int appendCount; //Field offset: 0x0
			public T JobData; //Field offset: 0x0

		}

		internal static readonly SharedStatic jobReflectionData; //Field offset: 0x0

		private static JobFilterProducer`1() { }

		public static void Execute(ref JobWrapper jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		public static void ExecuteAppend(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData) { }

		public static void ExecuteFilter(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData) { }

		[BurstDiscard]
		internal static void Initialize() { }

	}


	public static void EarlyJobInit() { }

	private static IntPtr GetReflectionData() { }

	[Extension]
	public static void RunAppend(T jobData, NativeList indices, int arrayLength) { }

	[Extension]
	public static void RunAppendByRef(ref T jobData, NativeList indices, int arrayLength) { }

	[Extension]
	public static void RunFilter(T jobData, NativeList indices) { }

	[Extension]
	public static void RunFilterByRef(ref T jobData, NativeList indices) { }

	[Extension]
	public static JobHandle ScheduleAppend(T jobData, NativeList indices, int arrayLength, JobHandle dependsOn = null) { }

	[Extension]
	public static JobHandle ScheduleAppendByRef(ref T jobData, NativeList indices, int arrayLength, JobHandle dependsOn = null) { }

	[Extension]
	public static JobHandle ScheduleFilter(T jobData, NativeList indices, JobHandle dependsOn = null) { }

	[Extension]
	public static JobHandle ScheduleFilterByRef(ref T jobData, NativeList indices, JobHandle dependsOn = null) { }

}

