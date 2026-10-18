namespace EFT.VolumePropagation;

public sealed class PlayerCollisionProbe
{
	private const int COLLIDER_BUFFER_SIZE = 64; //Field offset: 0x0
	private readonly Collider[] _buffer; //Field offset: 0x10
	private readonly List _scratch; //Field offset: 0x18
	private readonly HashSet _dedup; //Field offset: 0x20

	public PlayerCollisionProbe() { }

	public bool IntersectsAnyFilled(IPlayer player, VolumePropagationSource source) { }

	public IReadOnlyList Probe(Vector3 center, float radius) { }

}

