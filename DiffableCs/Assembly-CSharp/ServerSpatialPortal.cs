//Type is in global namespace

public class ServerSpatialPortal : MonoBehaviour, ISpatialPortal
{
	public List ConnectedRoomsId; //Field offset: 0x20
	[SerializeField]
	private int _id; //Field offset: 0x28
	[SerializeField]
	private bool _alwaysOpen; //Field offset: 0x2C
	[SerializeField]
	private NavMeshDoorLink _connectedDoor; //Field offset: 0x30

	public int Id
	{
		 get { } //Length: 4
	}

	public ServerSpatialPortal() { }

	public void AlwaysOpen() { }

	public override Vector3 Center() { }

	public int get_Id() { }

	public override bool IsOpen() { }

	private void OnDrawGizmosSelected() { }

	public void SetDoorConnector(NavMeshDoorLink possibleDoor) { }

	public void SetId(int portalId) { }

	public void SetPosition(Vector3 center) { }

	private void Start() { }

}

