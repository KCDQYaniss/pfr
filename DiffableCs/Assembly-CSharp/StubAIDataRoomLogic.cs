//Type is in global namespace

public class StubAIDataRoomLogic : IAIDataRoomLogic
{
	private List _stubPortals; //Field offset: 0x10

	public StubAIDataRoomLogic() { }

	public override void AddRoom(ISpatialRoom room) { }

	public override List GetPortals() { }

	public override bool HaveRoom() { }

	public override void RemoveRoom(ISpatialRoom room) { }

}

