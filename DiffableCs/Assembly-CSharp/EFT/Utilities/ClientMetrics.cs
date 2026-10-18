namespace EFT.Utilities;

public sealed class ClientMetrics
{
	public string sid; //Field offset: 0x10
	public GraphicsSettingsGroup Settings; //Field offset: 0x18
	public SharedSettingsClientMetricsInfo SharedSettings; //Field offset: 0x20
	public ClientHardwareDescription HardwareDescription; //Field offset: 0x28
	public string Location; //Field offset: 0x30
	public Metrics Metrics; //Field offset: 0x38
	public ClientMetricsEvents ClientEvents; //Field offset: 0x40
	public List SpikeSamples; //Field offset: 0x48
	public EClientMetrics mode; //Field offset: 0x50

	public ClientMetrics() { }

}

