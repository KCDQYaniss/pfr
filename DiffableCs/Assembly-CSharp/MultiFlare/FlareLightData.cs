namespace MultiFlare;

public struct FlareLightData
{
	public float Alpha; //Field offset: 0x0
	public float Scale; //Field offset: 0x4
	public float CullDistance; //Field offset: 0x8
	public bool Enabled; //Field offset: 0xC
	public Vector3 WorldPos; //Field offset: 0x10

	public FlareLightData(FlareLight flareLight) { }

}

