//Type is in global namespace

public class MineDirectionalColliders : MonoBehaviour, IPhysicsTrigger
{
	private MineDirectional _parent; //Field offset: 0x20

	public override string Description
	{
		 get { } //Length: 49
	}

	public MineDirectionalColliders() { }

	private void Awake() { }

	public override string get_Description() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public override void OnTriggerEnter(Collider collider) { }

	public override void OnTriggerExit(Collider collider) { }

}

