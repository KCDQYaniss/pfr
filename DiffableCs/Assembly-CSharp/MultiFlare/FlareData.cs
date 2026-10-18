namespace MultiFlare;

public struct FlareData
{
	public int LightIndex; //Field offset: 0x0
	public Vector2 Scale; //Field offset: 0x4
	public float Alpha; //Field offset: 0xC
	public float MinDist; //Field offset: 0x10
	public float MaxDist; //Field offset: 0x14
	public float MinScale; //Field offset: 0x18
	public float MaxScale; //Field offset: 0x1C
	public float MinAlpha; //Field offset: 0x20
	public float MaxAlpha; //Field offset: 0x24
	public Color Color; //Field offset: 0x28
	public Rect Uv; //Field offset: 0x38

	public FlareData(Flare flare, int lightIndex, Rect uv) { }

}

