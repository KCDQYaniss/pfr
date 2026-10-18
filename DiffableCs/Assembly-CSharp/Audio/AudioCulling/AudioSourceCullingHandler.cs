namespace Audio.AudioCulling;

public class AudioSourceCullingHandler : ICullingHandler
{
	private struct AudioSourceData
	{
		public float sqrCullDistance; //Field offset: 0x0
		public float cachedMaxDistance; //Field offset: 0x4
		public bool needRestart; //Field offset: 0x8

	}

	private readonly AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0x10
	private readonly Dictionary _sourceDataCache; //Field offset: 0x18

	public AudioSourceCullingHandler(AudioSourcePriorityCalculator priorityCalculator) { }

	public override void ClearCache() { }

	public override Vector3 GetPosition(AudioSource obj) { }

	public override float GetSqrMaxDistance(AudioSource obj, bool wasInRange) { }

	public override bool IsValid(AudioSource obj) { }

	public override void OnAfterRegister(AudioSource obj, Transform listenerTransform, bool wasAlreadyRegistered) { }

	public override void OnEnterRange(AudioSource obj) { }

	public override void OnExitRange(AudioSource obj) { }

	public override void RegisterInHandler(AudioSource obj, bool restartSource = false) { }

	public void RegisterSource(AudioSource source, bool restartSource = false) { }

	public override void RemoveFromHandler(AudioSource obj) { }

	public void RemoveSource(AudioSource source) { }

	public override void TickCulled(AudioSource obj) { }

	public override void UpdatePriority(AudioSource obj, float sqrDistance, float sqrMaxDistance) { }

	private void UpdateSourceData(AudioSource source, ref AudioSourceData data) { }

}

