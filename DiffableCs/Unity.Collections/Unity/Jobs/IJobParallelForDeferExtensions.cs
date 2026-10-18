namespace Unity.Jobs;

[Extension]
public static class IJobParallelForDeferExtensions
{
	public struct JobParallelForDeferProducer`1
	{
		[CompilerGenerated]
		private static class <>O
		{
			public static ExecuteJobFunction <0>__Execute; //Field offset: 0x0

		}

		internal sealed class ExecuteJobFunction : MulticastDelegate
		{

			public ExecuteJobFunction(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref T jobData, ref JobRanges ranges, IAsyncResult result) { }

			public override void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		internal static readonly SharedStatic jobReflectionData; //Field offset: 0x0

		private static JobParallelForDeferProducer`1() { }

		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[BurstDiscard]
		internal static void Initialize() { }

	}


	public static void EarlyJobInit() { }

	[Extension]
	public static JobHandle Schedule(T jobData, NativeList list, int innerloopBatchCount, JobHandle dependsOn = null) { }

	[Extension]
	public static JobHandle Schedule(T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = null) { }

	[Extension]
	public static JobHandle ScheduleByRef(ref T jobData, NativeList list, int innerloopBatchCount, JobHandle dependsOn = null) { }

	[Extension]
	public static JobHandle ScheduleByRef(ref T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = null) { }

	private static JobHandle ScheduleInternal(ref T jobData, int innerloopBatchCount, void* forEachListPtr, void* atomicSafetyHandlePtr, JobHandle dependsOn) { }

}

