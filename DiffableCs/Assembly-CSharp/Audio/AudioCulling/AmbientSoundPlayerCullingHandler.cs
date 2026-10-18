namespace Audio.AudioCulling;

public class AmbientSoundPlayerCullingHandler : ICullingHandler
{
	private struct AmbientPlayerData
	{
		public float sqrCullDistance; //Field offset: 0x0
		public float cachedMaxDistance; //Field offset: 0x4

	}

	private readonly AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0x10
	private readonly Dictionary _playerDataCache; //Field offset: 0x18

	public AmbientSoundPlayerCullingHandler(AudioSourcePriorityCalculator priorityCalculator) { }

	public override void ClearCache() { }

	public override Vector3 GetPosition(BaseAmbientSoundPlayer obj) { }

	public override float GetSqrMaxDistance(BaseAmbientSoundPlayer obj, bool wasInRange) { }

	public override bool IsValid(BaseAmbientSoundPlayer obj) { }

	public override void OnAfterRegister(BaseAmbientSoundPlayer obj, Transform listenerTransform, bool wasAlreadyRegistered) { }

	public override void OnEnterRange(BaseAmbientSoundPlayer obj) { }

	public override void OnExitRange(BaseAmbientSoundPlayer obj) { }

	public override void RegisterInHandler(BaseAmbientSoundPlayer obj, bool restartSource = false) { }

	public void RegisterPlayer(BaseAmbientSoundPlayer player) { }

	public override void RemoveFromHandler(BaseAmbientSoundPlayer obj) { }

	public override void TickCulled(BaseAmbientSoundPlayer obj) { }

	private void UpdatePlayerData(BaseAmbientSoundPlayer player, ref AmbientPlayerData data) { }

	public override void UpdatePriority(BaseAmbientSoundPlayer obj, float sqrDistance, float sqrMaxDistance) { }

}

