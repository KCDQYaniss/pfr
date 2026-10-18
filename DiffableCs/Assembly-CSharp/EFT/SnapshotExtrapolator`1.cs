namespace EFT;

public class SnapshotExtrapolator`1
{
	private const float MAXIMUM_DURATION = 0.25; //Field offset: 0x0
	private const float MINIMUM_REMOTE_DURATION = 0.01; //Field offset: 0x0
	private T[] _snapshots; //Field offset: 0x0
	private int _snapshotCount; //Field offset: 0x0

	public SnapshotExtrapolator`1() { }

	public void Add(T message) { }

	public bool TryExtrapolate(float localTime, Func interpolateFunc, out T snapshot) { }

}

