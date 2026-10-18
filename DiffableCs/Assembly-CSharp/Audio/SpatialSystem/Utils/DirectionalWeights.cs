namespace Audio.SpatialSystem.Utils;

public struct DirectionalWeights
{
	public float Front; //Field offset: 0x0
	public float Back; //Field offset: 0x4
	public float Up; //Field offset: 0x8
	public float Down; //Field offset: 0xC

	public DirectionalWeights(float front, float back, float up, float down) { }

}

