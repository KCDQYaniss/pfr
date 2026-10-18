namespace RaycastJobs;

public struct RaycastAllCommand
{
	private struct CombineResultsJob : IJob
	{
		public int MAXHits; //Field offset: 0x0
		public int Offset; //Field offset: 0x4
		[ReadOnly]
		public NativeArray SemiResults; //Field offset: 0x8
		[WriteOnly]
		public NativeArray Results; //Field offset: 0x18

		public override void Execute() { }

	}

	private struct CreateCommandsJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray PreviousCommands; //Field offset: 0x0
		[ReadOnly]
		public NativeArray RaycastHits; //Field offset: 0x10
		[WriteOnly]
		public NativeArray RaycastCommands; //Field offset: 0x20
		[ReadOnly]
		public float MINStep; //Field offset: 0x30

		public override void Execute(int index) { }

	}

	private struct RestoreDistancesJob : IJob
	{
		public int MAXHits; //Field offset: 0x0
		public NativeArray RaycastCommands; //Field offset: 0x8
		public NativeArray RaycastHits; //Field offset: 0x18

		public override void Execute() { }

	}

	private readonly NativeArray _results; //Field offset: 0x0
	[CompilerGenerated]
	private int <MaxHits>k__BackingField; //Field offset: 0x10
	public readonly float MINStep; //Field offset: 0x14
	private readonly NativeArray[] _semiResults; //Field offset: 0x18
	private readonly NativeArray[] _semiCommands; //Field offset: 0x20

	public private int MaxHits
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public RaycastAllCommand(NativeArray commands, NativeArray results, int maxHits, float minStep = 0.0001) { }

	public void Dispose() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_MaxHits() { }

	public JobHandle Schedule(JobHandle dependency) { }

	[CompilerGenerated]
	private void set_MaxHits(int value) { }

}

