namespace RaycastJobs;

public struct SpherecastAllCommand
{
	private struct CombineResultsJob : IJob
	{
		public int maxHits; //Field offset: 0x0
		public int offset; //Field offset: 0x4
		[ReadOnly]
		public NativeArray semiResults; //Field offset: 0x8
		[WriteOnly]
		public NativeArray results; //Field offset: 0x18

		public override void Execute() { }

	}

	private struct CreateCommandsJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray previousCommands; //Field offset: 0x0
		[ReadOnly]
		public NativeArray spherecastHits; //Field offset: 0x10
		[WriteOnly]
		public NativeArray spherecastCommands; //Field offset: 0x20

		public override void Execute(int index) { }

	}

	private struct RestoreDistancesJob : IJob
	{
		public int maxHits; //Field offset: 0x0
		public NativeArray spherecastCommands; //Field offset: 0x8
		public NativeArray spherecastHits; //Field offset: 0x18

		public override void Execute() { }

	}

	private NativeArray results; //Field offset: 0x0
	private int maxHits; //Field offset: 0x10
	private NativeArray[] semiResults; //Field offset: 0x18
	private NativeArray[] semiCommands; //Field offset: 0x20

	public int MaxHits
	{
		 get { } //Length: 164
	}

	public SpherecastAllCommand(NativeArray commands, NativeArray results, int maxHits) { }

	public void Dispose() { }

	public int get_MaxHits() { }

	public JobHandle Schedule(JobHandle dependency) { }

}

