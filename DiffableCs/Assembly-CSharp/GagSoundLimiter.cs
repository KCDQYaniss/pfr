//Type is in global namespace

public class GagSoundLimiter
{
	private readonly Dictionary Gags; //Field offset: 0x10
	private readonly PoolWithoutAlloc _gagPool; //Field offset: 0x18

	public GagSoundLimiter() { }

	public bool CheckGagsLimit(Vector3 position, Vector3 listenerPos, float sqrDistance, string chokeKey = "") { }

	public void Clear() { }

	public void InitGag(Vector3 position, float clipLength, float rolloff, float chokeTime, Vector2 gagRadius, string chokeKey = "") { }

	public void PrecacheGag(string chokeKey) { }

}

