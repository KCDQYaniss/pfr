namespace Meta.XR.Acoustics;

public struct MapParameters
{
	public UIntPtr thisSize; //Field offset: 0x0
	public SceneIRCallbacks callbacks; //Field offset: 0x8
	public UIntPtr threadCount; //Field offset: 0x18
	public UIntPtr reflectionCount; //Field offset: 0x20
	public AcousticMapFlags flags; //Field offset: 0x28
	public float minResolution; //Field offset: 0x2C
	public float maxResolution; //Field offset: 0x30
	public float headHeight; //Field offset: 0x34
	public float maxHeight; //Field offset: 0x38
	public float gravityVectorX; //Field offset: 0x3C
	public float gravityVectorY; //Field offset: 0x40
	public float gravityVectorZ; //Field offset: 0x44

}

