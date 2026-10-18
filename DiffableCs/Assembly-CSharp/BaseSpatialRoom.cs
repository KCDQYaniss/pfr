//Type is in global namespace

public class BaseSpatialRoom : MonoBehaviour, ISpatialRoom
{
	public List Areas; //Field offset: 0x20
	private readonly Dictionary _playersEnteredAreasCount; //Field offset: 0x28
	[SerializeField]
	private short _id; //Field offset: 0x30
	private List _portals; //Field offset: 0x38

	public override short ID
	{
		 get { } //Length: 5
	}

	public BaseSpatialRoom() { }

	public void AddColliders(List roomColliders) { }

	public void AddPortal(ServerSpatialPortal serverSpatialPortal) { }

	private void AudioTriggerAreaEventArgsHandle(object sender, AudioTriggerAreaEventArgs eventArgs) { }

	public override short get_ID() { }

	public override List GetPortals() { }

	public void Init() { }

	private void OnDestroy() { }

	public void SetId(short servRoomId) { }

	public void SetPosition(Transform transformPosition) { }

	private void Unsubscribe() { }

}

