//Type is in global namespace

public struct SmokeGrenadeNetworkData
{
	public Vector3 Position; //Field offset: 0x0
	public string Id; //Field offset: 0x10
	public string Template; //Field offset: 0x18
	public int Time; //Field offset: 0x20
	public Quaternion Orientation; //Field offset: 0x24
	public short PlatformId; //Field offset: 0x34

	public static SmokeGrenadeNetworkData Read(NetworkReader reader) { }

	public void Write(NetworkWriter writer) { }

}

