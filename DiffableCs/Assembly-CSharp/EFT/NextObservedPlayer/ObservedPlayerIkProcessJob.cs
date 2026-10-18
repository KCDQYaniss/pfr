namespace EFT.NextObservedPlayer;

[BurstCompile]
public struct ObservedPlayerIkProcessJob : IJobParallelFor
{
	[ReadOnly]
	public NativeArray MarkerPositions; //Field offset: 0x0
	[ReadOnly]
	public NativeArray MarkerRotations; //Field offset: 0x10
	[ReadOnly]
	public NativeArray GripReferencePositions; //Field offset: 0x20
	[ReadOnly]
	public NativeArray TargetPositions; //Field offset: 0x30
	[ReadOnly]
	public NativeArray TargetRotations; //Field offset: 0x40
	[ReadOnly]
	public NativeArray MarkerValid; //Field offset: 0x50
	[ReadOnly]
	public NativeArray GripReferenceValid; //Field offset: 0x60
	[ReadOnly]
	public NativeArray TargetValid; //Field offset: 0x70
	[ReadOnly]
	public NativeArray LimbActive; //Field offset: 0x80
	[ReadOnly]
	public NativeArray DistanceToCamera; //Field offset: 0x90
	public float GripCullDistance; //Field offset: 0xA0
	public float HandAnimationBlendThreshold; //Field offset: 0xA4
	[ReadOnly]
	public NativeArray InteractionTargetValid; //Field offset: 0xA8
	[ReadOnly]
	public NativeArray InteractionTargetPosition; //Field offset: 0xB8
	[ReadOnly]
	public NativeArray InteractionTargetRotation; //Field offset: 0xC8
	[ReadOnly]
	public NativeArray InteractionTargetBlend; //Field offset: 0xD8
	[WriteOnly]
	public NativeArray ResultPositions; //Field offset: 0xE8
	[WriteOnly]
	public NativeArray ResultRotations; //Field offset: 0xF8
	[WriteOnly]
	public NativeArray ResultGripWeights; //Field offset: 0x108
	[WriteOnly]
	public NativeArray ShouldSetGripWeight; //Field offset: 0x118
	[WriteOnly]
	public NativeArray ResultValid; //Field offset: 0x128

	public override void Execute(int index) { }

}

