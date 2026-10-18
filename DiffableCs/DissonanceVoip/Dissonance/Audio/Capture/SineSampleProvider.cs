namespace Dissonance.Audio.Capture;

internal class SineSampleProvider : ISampleProvider
{
	private const double TwoPi = 6.283185307179586; //Field offset: 0x0
	private readonly WaveFormat _format; //Field offset: 0x10
	private readonly float _frequency; //Field offset: 0x18
	private readonly double _step; //Field offset: 0x20
	private double _index; //Field offset: 0x28

	public float Frequency
	{
		 get { } //Length: 6
	}

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	public SineSampleProvider(WaveFormat format, float frequency) { }

	public float get_Frequency() { }

	public override WaveFormat get_WaveFormat() { }

	public override int Read(float[] buffer, int offset, int count) { }

}

