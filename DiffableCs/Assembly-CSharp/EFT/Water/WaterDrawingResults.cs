namespace EFT.Water;

public struct WaterDrawingResults
{
	[CompilerGenerated]
	private Mesh <Mesh>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Renderer <Renderer>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private MaterialPropertyBlock <Block>k__BackingField; //Field offset: 0x10

	public private MaterialPropertyBlock Block
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Mesh Mesh
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Renderer Renderer
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public WaterDrawingResults(Mesh mesh, Renderer renderer, MaterialPropertyBlock block) { }

	[CompilerGenerated]
	[IsReadOnly]
	public MaterialPropertyBlock get_Block() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Mesh get_Mesh() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Renderer get_Renderer() { }

	[CompilerGenerated]
	private void set_Block(MaterialPropertyBlock value) { }

	[CompilerGenerated]
	private void set_Mesh(Mesh value) { }

	[CompilerGenerated]
	private void set_Renderer(Renderer value) { }

}

