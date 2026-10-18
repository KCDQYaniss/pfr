//Type is in global namespace

public class BotNearDoorData : BotData
{
	public float RecentlyClosedDoorCheckTime; //Field offset: 0x18
	private readonly List _stubLinks; //Field offset: 0x20

	public BotNearDoorData(BotOwner owner) { }

	public void Activate() { }

	public List CurrentDoorLinks() { }

	public void DrawGizmosSelected() { }

	public NavMeshDoorLink GetNearestDoor() { }

	public void Update() { }

}

