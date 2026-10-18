namespace EFT.Interactive;

public sealed class BrokenWindowPieceCollider : MonoBehaviour, IPhysicsTriggerWithStay, IPhysicsTrigger
{
	[CompilerGenerated]
	private Action OnPlayerCollision; //Field offset: 0x20
	public BoxCollider Collider; //Field offset: 0x28
	private float _dontCheckUntil; //Field offset: 0x30

	public event Action OnPlayerCollision
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override string Description
	{
		 get { } //Length: 49
	}

	public BrokenWindowPieceCollider() { }

	[CompilerGenerated]
	public void add_OnPlayerCollision(Action value) { }

	public override string get_Description() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private override void IPhysicsTriggerWithStay.OnTriggerStayCustom(Collider enteredCollider, Collider triggerCollider) { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	[CompilerGenerated]
	public void remove_OnPlayerCollision(Action value) { }

	public void UnsubscibeAction() { }

}

