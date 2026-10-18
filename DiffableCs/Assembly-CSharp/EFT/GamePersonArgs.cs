namespace EFT;

public sealed class GamePersonArgs
{
	public int Id; //Field offset: 0x10
	public string ProfileId; //Field offset: 0x18
	public string Name; //Field offset: 0x20
	public Vector3 Position; //Field offset: 0x28
	public Quaternion Rotation; //Field offset: 0x34
	public ESpawnCategory Category; //Field offset: 0x44
	public EPlayerSide Side; //Field offset: 0x48
	public string GroupId; //Field offset: 0x50
	public string Infiltration; //Field offset: 0x58

	public GamePersonArgs() { }

	public static GamePersonArgs op_Explicit(GamePerson person) { }

}

