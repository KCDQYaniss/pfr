//Type is in global namespace

public class GrenadeFactory
{

	public GrenadeFactory() { }

	protected override Grenade AddGrenade(GameObject gameObject) { }

	protected override SmokeGrenade AddSmokeGrenade(GameObject gameObject) { }

	protected override StunGrenade AddStunGrenade(GameObject gameObject) { }

	protected override TearGasGrenade AddTearGasGrenade(GameObject gameObject) { }

	public Grenade Create(GrenadeSettings grenadeSettings, Vector3 position, Quaternion rotation, Vector3 force, ThrowWeap item, int playerRaidId, float prewarm = 0, bool withBallisticCalculator = true, bool isBeingPlanted = false) { }

	public override Grenade CreateObservedGrenade(string itemId, string template, Vector3 position, Quaternion rotation, Vector3 force, int playerRaidId, float prewarm = 0, bool withBallisticCalculator = true) { }

	public override SmokeGrenade CreateStillSmokeGrenade(string itemId, string template, Vector3 position, Quaternion rotation, float time, MovingPlatform platform = null) { }

	public override TearGasGrenade CreateStillTearGasGrenade(string itemId, string template, Vector3 position, Quaternion rotation, float time, MovingPlatform platform = null) { }

}

