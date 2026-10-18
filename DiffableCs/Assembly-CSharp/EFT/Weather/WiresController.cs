namespace EFT.Weather;

public class WiresController
{
	private static readonly int _wireWind; //Field offset: 0x0
	private static readonly int _wireWindFreq; //Field offset: 0x4
	private static readonly int _wireWindScale; //Field offset: 0x8
	private static readonly int _wireDetailWindScale; //Field offset: 0xC
	private static readonly int _wireDetailWindFreq; //Field offset: 0x10
	private static readonly int _wireDetailWindAmp; //Field offset: 0x14
	private static readonly int _funcOffsetAndScale; //Field offset: 0x18
	public float StrengthMultiplyer; //Field offset: 0x10
	public float MaxValue; //Field offset: 0x14
	public float FreqDelta; //Field offset: 0x18
	public float WindScale; //Field offset: 0x1C
	public float WindFreq; //Field offset: 0x20
	public float MaxWinFreq; //Field offset: 0x24
	public float DetailWindAmp; //Field offset: 0x28
	public float DetailWindScale; //Field offset: 0x2C
	public float DetailWindFreq; //Field offset: 0x30
	public float WiresMaxWindOffsetMultiplier; //Field offset: 0x34
	public float WiresMaxWindAmplitudeMultiplier; //Field offset: 0x38
	private Vector2 _windFuncOffsetAndScale; //Field offset: 0x3C

	private static WiresController() { }

	public WiresController() { }

	private void SetShaderValues(Vector3 wind, float magnitudeNormalized, float freqMult) { }

	public void Update(Vector2 wind) { }

}

