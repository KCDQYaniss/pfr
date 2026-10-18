namespace BSG.Unity.Wires;

public class Wire
{
	private struct Point
	{
		public Vector3 Position; //Field offset: 0x0
		public Vector3 Up; //Field offset: 0xC
		public Vector3 Right; //Field offset: 0x18

	}

	public Vector3 A; //Field offset: 0x10
	public Vector3 B; //Field offset: 0x1C
	public float Gravity; //Field offset: 0x28
	public int Parts; //Field offset: 0x2C
	public int Objects; //Field offset: 0x30

	public Wire() { }

}

