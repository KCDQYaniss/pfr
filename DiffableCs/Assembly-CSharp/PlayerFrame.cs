//Type is in global namespace

public class PlayerFrame
{
	public int ServerFrameIndex; //Field offset: 0x10
	public Vector3 Position; //Field offset: 0x14
	public Vector2 Rotation; //Field offset: 0x20
	public Vector3 LocalVelocity; //Field offset: 0x28
	public float PoseLevel; //Field offset: 0x34
	public float Speed; //Field offset: 0x38
	public PlayerStateInfo StateInfo; //Field offset: 0x40

	public PlayerFrame() { }

	public static PlayerFrame Lerp(PlayerFrame from, PlayerFrame to, float t) { }

	public override void ReadFromBuffer(byte[] buffer, ref int offset) { }

	public virtual string ToString() { }

	public override int WriteToBuffer(byte[] buffer, int offset = 0) { }

}

