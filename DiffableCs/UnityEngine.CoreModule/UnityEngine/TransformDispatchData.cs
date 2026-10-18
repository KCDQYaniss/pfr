namespace UnityEngine;

internal struct TransformDispatchData : IDisposable
{
	public NativeArray transformedID; //Field offset: 0x0
	public NativeArray parentID; //Field offset: 0x10
	public NativeArray localToWorldMatrices; //Field offset: 0x20
	public NativeArray positions; //Field offset: 0x30
	public NativeArray rotations; //Field offset: 0x40
	public NativeArray scales; //Field offset: 0x50

	public override void Dispose() { }

}

