//Type is in global namespace

public class ServerRoomColliderArea : MonoBehaviour, IPhysicsTriggerWithStay, IPhysicsTrigger
{
	[SerializeField]
	private BoxCollider areaCollider; //Field offset: 0x20
	[SerializeField]
	private bool _validatePlayerCenterInside; //Field offset: 0x28
	private Dictionary _playersTriggerCounter; //Field offset: 0x30
	private Dictionary _playersColliders; //Field offset: 0x38
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private EventHandler OnTriggerArea; //Field offset: 0x48

	public event EventHandler OnTriggerArea
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BoxCollider AreaCollider
	{
		 get { } //Length: 5
	}

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ServerRoomColliderArea() { }

	[CompilerGenerated]
	public void add_OnTriggerArea(EventHandler value) { }

	private void Awake() { }

	private void ExecuteOnEnter(IPlayer player) { }

	private void ExecuteOnExit(IPlayer player) { }

	public BoxCollider get_AreaCollider() { }

	[CompilerGenerated]
	public override string get_Description() { }

	public BoxCollider GetCollider() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	private override void IPhysicsTriggerWithStay.OnTriggerStayCustom(Collider coll, Collider triggerCollider) { }

	public override void OnTriggerEnter(Collider coll) { }

	public override void OnTriggerExit(Collider coll) { }

	[CompilerGenerated]
	public void remove_OnTriggerArea(EventHandler value) { }

}

