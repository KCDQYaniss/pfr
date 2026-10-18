namespace CW2.Animations;

public class StateSerializer
{
	internal enum ActionState
	{
		Idle = 0,
		Fire = 1,
		Reload = 2,
		GetPistol = 3,
		GetRifle = 4,
		Misfire = 5,
	}

	internal enum PoseState
	{
		Stay = 0,
		Sit = 1,
		Lay = 2,
		Jump = 3,
	}

	internal enum SpeedState
	{
		Walk = 0,
		Run = 1,
		Sprint = 2,
	}

	public ActionState Action; //Field offset: 0x10
	public bool Aim; //Field offset: 0x14
	public int EquipedItem; //Field offset: 0x18
	public int Ammo; //Field offset: 0x1C
	public bool Forvard; //Field offset: 0x20
	public bool Backward; //Field offset: 0x21
	public bool Right; //Field offset: 0x22
	public bool Left; //Field offset: 0x23
	public PoseState Pose; //Field offset: 0x24
	public SpeedState Speed; //Field offset: 0x28
	public bool IsHit; //Field offset: 0x2C

	public StateSerializer() { }

	public void ReadState(int state) { }

	private void Serialize(bool write, ref int state) { }

	private static void Serialize(bool write, ref int state, ref int position, ref bool value) { }

	private static void Serialize(bool write, ref int state, ref int position, ref int value, int length) { }

	public int WriteState() { }

}

