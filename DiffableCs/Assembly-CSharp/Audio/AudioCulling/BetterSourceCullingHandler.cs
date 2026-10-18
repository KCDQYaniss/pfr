namespace Audio.AudioCulling;

public class BetterSourceCullingHandler : ICullingHandler
{
	private struct BetterSourceData
	{
		public float sqrCullDistance; //Field offset: 0x0
		public float cachedMaxDistance; //Field offset: 0x4
		public bool wasRegisteredByCulling; //Field offset: 0x8
		public BetterSource source; //Field offset: 0x10

	}

	private readonly AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0x10
	private readonly Dictionary _sourceDataCache; //Field offset: 0x18
	private readonly AudioSourcePrewarmer _prewarmer; //Field offset: 0x20

	public BetterSourceCullingHandler(AudioSourcePriorityCalculator priorityCalculator) { }

	public override void ClearCache() { }

	public override Vector3 GetPosition(BetterSource obj) { }

	public override float GetSqrMaxDistance(BetterSource obj, bool wasInRange) { }

	public override bool IsValid(BetterSource obj) { }

	public override void OnAfterRegister(BetterSource obj, Transform listenerTransform, bool wasAlreadyRegistered) { }

	public override void OnEnterRange(BetterSource obj) { }

	public override void OnExitRange(BetterSource obj) { }

	public override void RegisterInHandler(BetterSource obj, bool restartSource = false) { }

	public void RegisterSource(BetterSource source) { }

	public override void RemoveFromHandler(BetterSource obj) { }

	public void RemoveSource(BetterSource source) { }

	public override void TickCulled(BetterSource obj) { }

	public override void UpdatePriority(BetterSource obj, float sqrDistance, float sqrMaxDistance) { }

	private void UpdateSourceData(BetterSource source, ref BetterSourceData data) { }

}

