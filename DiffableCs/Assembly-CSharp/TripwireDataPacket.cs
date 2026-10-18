//Type is in global namespace

public struct TripwireDataPacket
{
	public ETripwireState State; //Field offset: 0x0
	public string GrenadeTemplateId; //Field offset: 0x8
	public string GrenadeItemId; //Field offset: 0x10
	public int PlayerRaidId; //Field offset: 0x18
	public Vector3 FromPosition; //Field offset: 0x1C
	public Vector3 ToPosition; //Field offset: 0x28

}

