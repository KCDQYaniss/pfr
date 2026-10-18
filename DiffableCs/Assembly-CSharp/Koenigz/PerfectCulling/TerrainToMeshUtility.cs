namespace Koenigz.PerfectCulling;

[RequireComponent(typeof(Terrain))]
public class TerrainToMeshUtility : MonoBehaviour
{
	private readonly string EditorOnlyTag; //Field offset: 0x20
	[Range(1, 512)]
	public int MeshResolutionX; //Field offset: 0x28
	[Range(1, 512)]
	public int MeshResolutionZ; //Field offset: 0x2C
	public MeshRenderer meshRendererReference; //Field offset: 0x30

	public TerrainToMeshUtility() { }

	public void CreateOrUpdateMesh() { }

}

