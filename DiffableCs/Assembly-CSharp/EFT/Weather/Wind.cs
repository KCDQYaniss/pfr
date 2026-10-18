namespace EFT.Weather;

public struct Wind
{
	public Vector4 Global; //Field offset: 0x0
	public Vector4 Branch; //Field offset: 0x10
	public Vector4 Leaf1Ripple; //Field offset: 0x20
	public Vector4 Leaf2Ripple; //Field offset: 0x30
	public Vector4 Leaf1Tumble; //Field offset: 0x40
	public Vector4 Leaf2Tumble; //Field offset: 0x50
	public Vector4 Leaf1Twitch; //Field offset: 0x60
	public Vector4 Leaf2Twitch; //Field offset: 0x70
	public Vector4 FrondRipple; //Field offset: 0x80

	public static int Stride
	{
		 get { } //Length: 6
	}

	public static int get_Stride() { }

}

