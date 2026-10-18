namespace Audio.SpatialSystem;

public sealed class AsyncSoundObstructionCalculator : SoundObstructionCalculator
{
	private readonly List _checkRays; //Field offset: 0x28
	private readonly AsyncRaycaster _raycaster; //Field offset: 0x30
	private readonly Vector3 _verticalOffset; //Field offset: 0x38
	private float _totalObstructionEffect; //Field offset: 0x44
	private bool _isNeedVerticalOcclusion; //Field offset: 0x48

	public AsyncSoundObstructionCalculator(SpatialAudioSystem audioSystem) { }

	private void CastRays() { }

	private float CheckObstacles(RaycastHit[] hits) { }

	private void FillCheckRays(Vector3 soundPos, Vector3 listenerPos) { }

	private void FillRaycasterCommandsData() { }

	public virtual float GetScore() { }

	protected virtual void OnDispose() { }

	protected virtual void OnLateUpdate() { }

	protected virtual void OnUpdate(AudioSourceContainer sourceContainer, Vector3 listenerPosition, bool forceUpdate = false) { }

	private void UpdateObstructionEffect() { }

}

