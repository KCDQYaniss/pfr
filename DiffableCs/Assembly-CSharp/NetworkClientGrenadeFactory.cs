//Type is in global namespace

public class NetworkClientGrenadeFactory : GrenadeFactory
{

	public NetworkClientGrenadeFactory() { }

	protected virtual Grenade AddGrenade(GameObject gameObject) { }

	protected virtual SmokeGrenade AddSmokeGrenade(GameObject gameObject) { }

	protected virtual StunGrenade AddStunGrenade(GameObject gameObject) { }

	protected virtual TearGasGrenade AddTearGasGrenade(GameObject gameObject) { }

	public virtual Grenade CreateObservedGrenade(string itemId, string template, Vector3 position, Quaternion rotation, Vector3 force, int playerRaidId, float prewarm = 0, bool withBallisticCalculator = true) { }

	public virtual SmokeGrenade CreateStillSmokeGrenade(string itemId, string template, Vector3 position, Quaternion rotation, float time, MovingPlatform platform = null) { }

	public virtual TearGasGrenade CreateStillTearGasGrenade(string itemId, string template, Vector3 position, Quaternion rotation, float time, MovingPlatform platform = null) { }

}

