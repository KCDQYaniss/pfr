namespace EFT.Vehicle;

public struct ShapshotBTRMessage
{
	public Vector3 position; //Field offset: 0x0
	public Quaternion rotation; //Field offset: 0xC
	public float turretRotation; //Field offset: 0x1C
	public float gunsBlockRotation; //Field offset: 0x20
	public byte State; //Field offset: 0x24
	public byte RouteState; //Field offset: 0x25
	public byte LeftSideState; //Field offset: 0x26
	public byte LeftSlot0State; //Field offset: 0x27
	public byte LeftSlot1State; //Field offset: 0x28
	public byte RightSideState; //Field offset: 0x29
	public byte RightSlot0State; //Field offset: 0x2A
	public byte RightSlot1State; //Field offset: 0x2B
	public float currentSpeed; //Field offset: 0x2C
	public float timeToEndPause; //Field offset: 0x30
	public byte moveDirection; //Field offset: 0x34
	public float MoveSpeed; //Field offset: 0x38
	public int BtrBotId; //Field offset: 0x3C

	public void Deserialize(NetworkReader reader) { }

	public void Serialize(NetworkWriter writer) { }

}

