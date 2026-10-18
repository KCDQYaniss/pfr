namespace EFT.ActiveHeadphones;

public class EQBand
{
	public float Frequency; //Field offset: 0x10
	public float Gain; //Field offset: 0x14
	public float Q; //Field offset: 0x18

	public EQBand() { }

	public EQBand(float frequency, float gain, float q) { }

}

