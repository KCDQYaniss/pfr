namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
public struct NativeKeyValueArrays`2 : INativeDisposable, IDisposable
{
	public NativeArray Keys; //Field offset: 0x0
	public NativeArray Values; //Field offset: 0x0

	public int Length
	{
		 get { } //Length: 4
	}

	public NativeKeyValueArrays`2(int length, AllocatorHandle allocator, NativeArrayOptions options) { }

	public override void Dispose() { }

	public override JobHandle Dispose(JobHandle inputDeps) { }

	public int get_Length() { }

}

