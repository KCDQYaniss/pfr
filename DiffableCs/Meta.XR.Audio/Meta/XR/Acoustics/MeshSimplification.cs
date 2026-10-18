namespace Meta.XR.Acoustics;

public struct MeshSimplification
{
	public UIntPtr thisSize; //Field offset: 0x0
	public MeshFlags flags; //Field offset: 0x8
	public float unitScale; //Field offset: 0xC
	public float maxError; //Field offset: 0x10
	public float minDiffractionEdgeAngle; //Field offset: 0x14
	public float minDiffractionEdgeLength; //Field offset: 0x18
	public float flagLength; //Field offset: 0x1C
	public UIntPtr threadCount; //Field offset: 0x20

}

