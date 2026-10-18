//Type is in global namespace

public class GrassValues
{
	public float AngleInRads; //Field offset: 0x10
	public float TailLength; //Field offset: 0x14
	[Range(0.01, 16)]
	public float Radius; //Field offset: 0x18
	[Range(0.01, 16)]
	public float PressedRadius; //Field offset: 0x1C
	public float ReturnTime; //Field offset: 0x20

	public GrassValues() { }

	public GrassValues(float angleInRads, float tailLength, float radius, float pressedRadius, float returnTime) { }

	public void Lerp(GrassValues from, GrassValues to, float t) { }

	public Vector4 ToVector4ExceptReturnTime() { }

}

