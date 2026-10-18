namespace EFT.Interactive;

public abstract class InteractableObject : PoolSafeMonoBehaviour, IKillable, IInteractive
{
	public ESpecificInteractionContext specificInteractionContext; //Field offset: 0x28
	private float _stateUpdateTime; //Field offset: 0x2C
	public float InteractionDot; //Field offset: 0x30
	public Vector3 InteractionDirection; //Field offset: 0x34
	private BetterSource _source; //Field offset: 0x40

	public float StateUpdateTime
	{
		 get { } //Length: 6
	}

	public override Transform TrackableTransform
	{
		 get { } //Length: 78
	}

	public Vector3 WorldInteractionDirection
	{
		 get { } //Length: 275
	}

	protected InteractableObject() { }

	public float get_StateUpdateTime() { }

	public override Transform get_TrackableTransform() { }

	public Vector3 get_WorldInteractionDirection() { }

	public bool InteractsFromAppropriateDirection(Vector3 playerForward) { }

	public override void Kill() { }

	public override void OnDrawGizmosSelected() { }

	protected void SetStateUpdateTime() { }

}

