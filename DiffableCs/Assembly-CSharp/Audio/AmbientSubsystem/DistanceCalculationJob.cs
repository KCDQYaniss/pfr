namespace Audio.AmbientSubsystem;

[BurstCompile]
internal struct DistanceCalculationJob : IJobParallelFor
{
	[ReadOnly]
	public Vector3 ListenerPosition; //Field offset: 0x0
	[ReadOnly]
	public NativeArray PortalsData; //Field offset: 0x10
	[WriteOnly]
	public NativeArray DistancesToListener; //Field offset: 0x20

	public override void Execute(int index) { }

}

