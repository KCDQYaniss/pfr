//Type is in global namespace

public struct OverlapBoxJob : IJobParallelFor
{
	internal sealed class OverlapBoxJobParameters
	{
		public int Count; //Field offset: 0x10
		public BoxOverlapCommand[] Commands; //Field offset: 0x18
		public OBBTrigger[] Triggers; //Field offset: 0x20
		public int[] Result; //Field offset: 0x28

		public OverlapBoxJobParameters() { }

	}

	public static readonly OverlapBoxJobParameters[] JobParams; //Field offset: 0x0
	[ReadOnly]
	public int Index; //Field offset: 0x0

	private static OverlapBoxJob() { }

	public override void Execute(int executeIndex) { }

	public int GetExecutionLength() { }

	private void Process(OverlapBoxJobParameters pars, int index) { }

}

