namespace EFT.Rendering.Clouds;

public struct WeatherDebugProxy : IRelay
{
	[Range(0, 24)]
	public float Hour; //Field offset: 0x0
	[Range(0, 0.255)]
	public float Fog; //Field offset: 0x4
	[Range(0, 1)]
	public float Rain; //Field offset: 0x8

	public override void Init(WeatherDebug original) { }

	public override void Relay(WeatherDebug original) { }

}

