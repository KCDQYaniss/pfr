namespace EFT.Weather;

public struct WindParamsSet
{
	public WindParams Global; //Field offset: 0x0
	public WindParams Branch; //Field offset: 0x40
	public WindParams Leaf1Ripple; //Field offset: 0x80
	public WindParams Leaf2Ripple; //Field offset: 0xC0
	public WindParams Leaf1Tumble; //Field offset: 0x100
	public WindParams Leaf2Tumble; //Field offset: 0x140
	public WindParams Leaf1Twitch; //Field offset: 0x180
	public WindParams Leaf2Twitch; //Field offset: 0x1C0
	public WindParams FrondRipple; //Field offset: 0x200

	public static int Stride
	{
		 get { } //Length: 6
	}

	public static int get_Stride() { }

}

