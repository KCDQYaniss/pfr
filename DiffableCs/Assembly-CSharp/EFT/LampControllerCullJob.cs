namespace EFT;

[BurstCompile]
public struct LampControllerCullJob : IJobParallelForTransform
{
	private CameraData _cameraData; //Field offset: 0x0
	[WriteOnly]
	private ParallelWriter _indexMap; //Field offset: 0x50

	public LampControllerCullJob(CameraData cameraData, NativeList indexMap) { }

	public override void Execute(int index, TransformAccess transform) { }

	private bool IsPointInsideViewFrustum(Vector3 position) { }

}

