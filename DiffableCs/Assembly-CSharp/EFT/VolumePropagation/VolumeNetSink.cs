namespace EFT.VolumePropagation;

public sealed class VolumeNetSink : IVolumeNetSink
{
	private struct DeltaSlice
	{
		public int SourceId; //Field offset: 0x0
		public IReadOnlyList Source; //Field offset: 0x8
		public int FromIndex; //Field offset: 0x10
		public int Count; //Field offset: 0x14

	}

	public const int MAX_VOXELS_PER_DRAIN = 256; //Field offset: 0x0
	private readonly Queue _spawnQueue; //Field offset: 0x10
	private readonly Queue _removeQueue; //Field offset: 0x18
	private readonly List _pendingDeltas; //Field offset: 0x20

	public VolumeNetSink() { }

	public void Clear() { }

	public void DrainInto(ref GameWorldPacket packet) { }

	public override void EnqueueDelta(int sourceId, IReadOnlyList renderable, int fromIndex, int count) { }

	public override void EnqueueRemove(int sourceId) { }

	public override void EnqueueSpawn(int sourceId, Vector3 position, byte presetId) { }

}

