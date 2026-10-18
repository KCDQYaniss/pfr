namespace Audio.AudioCulling;

public interface ICullingHandler`1
{

	public void ClearCache() { }

	public Vector3 GetPosition(T obj) { }

	public float GetSqrMaxDistance(T obj, bool wasInRange) { }

	public bool IsValid(T obj) { }

	public void OnAfterRegister(T obj, Transform listenerTransform, bool wasAlreadyRegistered) { }

	public void OnEnterRange(T obj) { }

	public void OnExitRange(T obj) { }

	public void RegisterInHandler(T obj, bool restartSource = false) { }

	public void RemoveFromHandler(T obj) { }

	public void TickCulled(T obj) { }

	public void UpdatePriority(T obj, float sqrDistance, float sqrMaxDistance) { }

}

