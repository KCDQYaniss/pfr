namespace Vuplex.WebView;

public struct TouchEvent
{
	public int TouchID; //Field offset: 0x0
	public TouchEventType Type; //Field offset: 0x4
	public Vector2 Point; //Field offset: 0x8
	public float RadiusX; //Field offset: 0x10
	public float RadiusY; //Field offset: 0x14
	public float RotationAngle; //Field offset: 0x18
	public float Pressure; //Field offset: 0x1C

}

