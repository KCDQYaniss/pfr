namespace EFT.VolumePropagation;

public interface IVolumeNetSink
{

	public void EnqueueDelta(int sourceId, IReadOnlyList renderable, int fromIndex, int count) { }

	public void EnqueueRemove(int sourceId) { }

	public void EnqueueSpawn(int sourceId, Vector3 position, byte presetId) { }

}

