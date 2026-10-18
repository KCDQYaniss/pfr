namespace EFT.Utilities;

public sealed class ServerMetricsConfig
{
	public uint[] Keys; //Field offset: 0x10
	public uint[] NetProcessingBins; //Field offset: 0x18
	public uint[] RenderBins; //Field offset: 0x20
	public uint[] GameUpdateBins; //Field offset: 0x28
	public uint[] MaxRtt; //Field offset: 0x30
	public uint[] MaxLoss; //Field offset: 0x38
	public uint[] MaxClientServerTimeDiff; //Field offset: 0x40
	public uint[] MaxClientServerTimeDiffByPlayer; //Field offset: 0x48
	public uint[] MaxPacketsQueueCount; //Field offset: 0x50
	public uint[] MaxPacketsQueueTime; //Field offset: 0x58
	public uint[] FixedUpdate; //Field offset: 0x60
	public uint[] FrameWithoutFixedUpdates; //Field offset: 0x68
	public uint[] ReceivedPacketsCount; //Field offset: 0x70
	public uint[] UnprocessedPacketsCount; //Field offset: 0x78
	public Nullable MemoryMeasureInterval; //Field offset: 0x80

	public ServerMetricsConfig() { }

}

