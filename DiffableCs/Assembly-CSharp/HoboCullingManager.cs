//Type is in global namespace

public class HoboCullingManager : ComponentSystem
{
	private Action _unsubscribe; //Field offset: 0x30
	private Collider[] _triggerHits; //Field offset: 0x38
	private Collider[] _triggerHitsBuffer; //Field offset: 0x40
	private int _cullingTriggerLayerRaidId; //Field offset: 0x48

	protected virtual bool HasLateUpdate
	{
		 get { } //Length: 3
	}

	protected virtual bool HasUpdate
	{
		 get { } //Length: 3
	}

	public HoboCullingManager() { }

	protected virtual void Awake() { }

	protected virtual bool get_HasLateUpdate() { }

	protected virtual bool get_HasUpdate() { }

	protected virtual void LateUpdateComponent(DisablerCullingObjectBase component) { }

	protected virtual void OnDestroy() { }

	private void OnSpectatorTargetChanged(LocalSpectatorTargetChangedEvent targetEvent) { }

	private void RefreshSpectatorTarget(int newTargetRaidId) { }

	private static void SetObservedPlayerCullingTriggerLayerEnabled(int raidId, bool enabled) { }

	private void SimulateTriggersEnterForTarget(ICharacterController characterController) { }

	protected virtual void UpdateComponent(DisablerCullingObjectBase component) { }

}

