//Type is in global namespace

public class InteractionReciver : MonoBehaviour
{
	private class MicroLocation
	{
		private int _hash; //Field offset: 0x10
		private HashSet _recivers; //Field offset: 0x18

		public bool IsEmpty
		{
			 get { } //Length: 69
		}

		public MicroLocation(int coordinate) { }

		public void Add(InteractionReciver reciver) { }

		public void FillRecivers(LinkedList recivers) { }

		public bool get_IsEmpty() { }

		public void Remove(InteractionReciver reciver) { }

	}

	public const float Size = 4; //Field offset: 0x0
	private const float InvSize = 0.25; //Field offset: 0x0
	private static Dictionary _locations; //Field offset: 0x0
	[CompilerGenerated]
	private int <Hash>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; //Field offset: 0x24

	public private int Hash
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	private static InteractionReciver() { }

	public InteractionReciver() { }

	private void Destroy() { }

	public static void FillRecivers(IntVec2 worldPosition, LinkedList recivers) { }

	[CompilerGenerated]
	public int get_Hash() { }

	[CompilerGenerated]
	public Vector3 get_Position() { }

	public static IntVec2 GetCoordinates(Vector3 worldPosition) { }

	public static int GetHash(Vector3 worldPosition) { }

	public static int GetHash(IntVec2 worldPosition) { }

	private static MicroLocation Getlocation(int hash) { }

	public static bool IsEmpty(IntVec2 worldPosition) { }

	[CompilerGenerated]
	private void set_Hash(int value) { }

	[CompilerGenerated]
	private void set_Position(Vector3 value) { }

	private void Start() { }

}

