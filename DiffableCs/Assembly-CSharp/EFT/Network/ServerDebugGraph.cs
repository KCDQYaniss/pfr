namespace EFT.Network;

public class ServerDebugGraph : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8
		public static Func <>9__12_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <OnDrawGizmos>b__12_0(ValueTuple v) { }

		internal int <OnDrawGizmos>b__12_1(ValueTuple v) { }

	}

	private static ServerDebugGraph _instance; //Field offset: 0x0
	private CircularBuffer _values; //Field offset: 0x20
	private List _positions; //Field offset: 0x28
	private Vector3 _position; //Field offset: 0x30
	private Vector2 _size; //Field offset: 0x3C
	private Color _color; //Field offset: 0x44
	private int _min; //Field offset: 0x54
	private int _max; //Field offset: 0x58

	public static ServerDebugGraph Instance
	{
		 get { } //Length: 477
	}

	public ServerDebugGraph() { }

	public void AddValue(int value, Color color, Vector3 position, Vector2 size) { }

	public void AddValue(int value, Color color, Vector3 position, Vector2 size, int min, int max) { }

	public static ServerDebugGraph get_Instance() { }

	private void OnDrawGizmos() { }

}

