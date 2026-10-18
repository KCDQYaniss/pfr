namespace EFT.Interactive;

[RequireComponent(typeof(Collider))]
public abstract class DamageTrigger : MonoBehaviour, IPhysicsTriggerWithStay, IPhysicsTrigger
{
	private Collider _collider; //Field offset: 0x20
	private Bounds _bounds; //Field offset: 0x28
	private Collider[] _bodyParts; //Field offset: 0x40
	private Dictionary _playersAnimatorSyncCooldown; //Field offset: 0x48
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x50

	protected Collider Collider
	{
		 get { } //Length: 5
	}

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected abstract bool IsStatic
	{
		 get { } //Length: 0
	}

	protected DamageTrigger() { }

	protected abstract void AddPenalty(IObserverToPlayerBridge player) { }

	private void Awake() { }

	protected Collider get_Collider() { }

	[CompilerGenerated]
	public override string get_Description() { }

	protected abstract bool get_IsStatic() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private override void IPhysicsTriggerWithStay.OnTriggerStayCustom(Collider enteredCollider, Collider triggerCollider) { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	protected abstract void PlaySound(Collider playerCollider, bool useOcclusion = false) { }

	protected abstract void ProceedDamage(IObserverToPlayerBridge player, BodyPartCollider bodyPart) { }

	protected abstract void RemovePenalty(IObserverToPlayerBridge player) { }

	private void Start() { }

	private void UpdateBounds() { }

}

