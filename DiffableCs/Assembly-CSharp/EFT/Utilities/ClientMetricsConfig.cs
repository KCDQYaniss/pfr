namespace EFT.Utilities;

public sealed class ClientMetricsConfig
{
	public uint[] Keys; //Field offset: 0x10
	public uint[] NetProcessingBins; //Field offset: 0x18
	public uint[] RenderBins; //Field offset: 0x20
	public uint[] GameUpdateBins; //Field offset: 0x28
	public Nullable MemoryMeasureInterval; //Field offset: 0x30
	public EPauseReason[] PauseReasons; //Field offset: 0x38

	public ClientMetricsConfig() { }

}

