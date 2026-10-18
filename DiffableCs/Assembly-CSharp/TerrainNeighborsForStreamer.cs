//Type is in global namespace

[RequireComponent(typeof(Terrain))]
public class TerrainNeighborsForStreamer : MonoBehaviour
{
	private static TerrainNeighborsForStreamer[,] _array; //Field offset: 0x0
	public int X; //Field offset: 0x20
	public int Y; //Field offset: 0x24
	public int ArrayWidth; //Field offset: 0x28
	public int ArrayHeight; //Field offset: 0x2C
	[CompilerGenerated]
	private Terrain <Left>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Terrain <Right>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Terrain <Top>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Terrain <Bottom>k__BackingField; //Field offset: 0x48
	private Terrain _terrain; //Field offset: 0x50

	public private Terrain Bottom
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private Terrain Left
	{
		[CompilerGenerated]
		private get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private Terrain Right
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private Terrain Top
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public TerrainNeighborsForStreamer() { }

	private void Awake() { }

	[CompilerGenerated]
	private Terrain get_Bottom() { }

	[CompilerGenerated]
	private Terrain get_Left() { }

	[CompilerGenerated]
	private Terrain get_Right() { }

	[CompilerGenerated]
	private Terrain get_Top() { }

	private TerrainNeighborsForStreamer GetNeighbor(int x, int y) { }

	private void OnDestroy() { }

	private void ProcessNeighbors(bool remove) { }

	[CompilerGenerated]
	public void set_Bottom(Terrain value) { }

	[CompilerGenerated]
	public void set_Left(Terrain value) { }

	[CompilerGenerated]
	public void set_Right(Terrain value) { }

	[CompilerGenerated]
	public void set_Top(Terrain value) { }

	public void UpdateNeighbors() { }

}

