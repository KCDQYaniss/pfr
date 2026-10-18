namespace Unity.Jobs.LowLevel.Unsafe;

public struct BatchQueryJob`2
{
	[ReadOnly]
	internal NativeArray commands; //Field offset: 0x0
	internal NativeArray results; //Field offset: 0x0

	public BatchQueryJob`2(NativeArray commands, NativeArray results) { }

}

