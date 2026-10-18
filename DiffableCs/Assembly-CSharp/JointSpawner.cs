//Type is in global namespace

[DisallowMultipleComponent]
public abstract class JointSpawner : MonoBehaviour
{
	public RigidbodySpawner connectedBody; //Field offset: 0x20
	public Vector3 anchor; //Field offset: 0x28
	public Vector3 axis; //Field offset: 0x34
	public bool autoConfigureConnectedAnchor; //Field offset: 0x40
	public Vector3 connectedAnchor; //Field offset: 0x44
	public bool enableCollision; //Field offset: 0x50
	public bool enablePreprocessing; //Field offset: 0x51
	protected Joint _joint; //Field offset: 0x58

	protected JointSpawner() { }

	public override Joint Create() { }

	protected override Joint CreateComponent() { }

	public void Remove() { }

}

