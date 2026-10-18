//Type is in global namespace

internal class HideoutGameWorld : ClientLocalGameWorld
{

	public HideoutGameWorld() { }

	protected virtual void BallisticsTick(float dt) { }

	protected virtual void GetOrAddAudioSourceCulling(GameObject gameObject, TGameWorld gameWorld) { }

	public virtual void RegisterInteractiveObject(Turnable t) { }

	protected virtual void UpdateSynchronizableObjectLogic(float dt) { }

}

