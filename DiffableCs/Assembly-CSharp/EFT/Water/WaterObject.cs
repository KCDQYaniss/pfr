namespace EFT.Water;

public class WaterObject
{
	[SerializeField]
	private MeshRenderer _renderer; //Field offset: 0x10
	[SerializeField]
	private MeshFilter _meshFilter; //Field offset: 0x18

	public bool Enabled
	{
		 get { } //Length: 480
	}

	public Mesh Mesh
	{
		 get { } //Length: 90
	}

	public MeshFilter MeshFilter
	{
		 get { } //Length: 5
	}

	public MeshRenderer Renderer
	{
		 get { } //Length: 5
	}

	public WaterObject(MeshRenderer renderer, MeshFilter meshFilter) { }

	public bool get_Enabled() { }

	public Mesh get_Mesh() { }

	public MeshFilter get_MeshFilter() { }

	public MeshRenderer get_Renderer() { }

}

