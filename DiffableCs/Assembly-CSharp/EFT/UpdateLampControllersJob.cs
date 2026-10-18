namespace EFT;

public struct UpdateLampControllersJob : IJobParallelForBatch
{
	[NativeDisableUnsafePtrRestriction]
	private IntPtr _collectionPtr; //Field offset: 0x0
	private float _time; //Field offset: 0x8
	private float _deltaTime; //Field offset: 0xC

	public UpdateLampControllersJob(IntPtr collectionPtr, float time, float deltaTime) { }

	public override void Execute(int startIndex, int count) { }

}

