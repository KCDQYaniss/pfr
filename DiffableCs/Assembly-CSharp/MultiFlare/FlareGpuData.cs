namespace MultiFlare;

public struct FlareGpuData
{
	public float3 WorldPos; //Field offset: 0x0
	public float4 UvRect; //Field offset: 0xC
	public float2 Scale; //Field offset: 0x1C
	public float4 Color; //Field offset: 0x24
	public float MinDist; //Field offset: 0x34
	public float DistInverse; //Field offset: 0x38
	public float ScaleRange; //Field offset: 0x3C
	public float AlphaRange; //Field offset: 0x40
	public float CullDistance; //Field offset: 0x44

}

