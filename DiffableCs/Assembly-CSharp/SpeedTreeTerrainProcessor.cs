//Type is in global namespace

public class SpeedTreeTerrainProcessor : MonoBehaviour
{
	private enum ObjType
	{
		SpeedTree = 0,
		Billboard = 1,
		Mesh = 2,
	}

	private class Prototype
	{
		public PrototypeRenderer[][] LodsRenderers; //Field offset: 0x10
		public float[] CullingRates; //Field offset: 0x18

		public Prototype(LODGroup lodGroup) { }

		private static PrototypeRenderer[][] CountLodsVertex(LOD[] lods) { }

		private static void FindSameRenderers(PrototypeRenderer[][] lodsRenderers, LOD[] lods) { }

		private static float[] GetCullingRates(LOD[] lods) { }

	}

	private class PrototypeRenderer
	{
		public int VertexCount; //Field offset: 0x10
		public int SubMeshCount; //Field offset: 0x14
		public GameObject Prefab; //Field offset: 0x18
		public ObjType Type; //Field offset: 0x20
		public int SameRendererLodNum; //Field offset: 0x24
		public Material[] Materials; //Field offset: 0x28
		private ShadowCastingMode _shadowCastingMode; //Field offset: 0x30
		private bool _receiveShadows; //Field offset: 0x34
		private LightProbeUsage _useLightProbes; //Field offset: 0x38
		private ReflectionProbeUsage _reflectionProbeUsage; //Field offset: 0x3C

		public PrototypeRenderer(Renderer renderer) { }

		private static GameObject CreatePtefab(Renderer renderer) { }

		private void GetRendererSettings(Renderer renderer) { }

		public void SetRendererSettings(Renderer renderer) { }

	}

	public Terrain Terrain; //Field offset: 0x20
	public Shader SpeedTreeShader; //Field offset: 0x28
	public bool SpawnTerrainPrefabs; //Field offset: 0x30
	public Transform SpawnTarget; //Field offset: 0x38
	public bool CombineOrdinaryMeshes; //Field offset: 0x40
	public float CellSize; //Field offset: 0x44

	public SpeedTreeTerrainProcessor() { }

	private MeshRenderer Combine(LinkedList meshFiltersList, PrototypeRenderer prototypeRenderer) { }

	private static void CombineBillboards(List[] lodsRenderersList, LOD[][] lods, int lodNum, int rendererNum, PrototypeRenderer prototypeRenderer) { }

	private void CombineGrid(LODGroup[][,] grid, Dictionary prototypes) { }

	private void CombineGroup(LODGroup[] cellGroups, Dictionary prototypes, string name) { }

	private void CombineMeshs(List[] lodsRenderersList, LOD[][] lods, int lodNum, int rendererNum, PrototypeRenderer prototypeRenderer) { }

	private List[] CombinePrototype(Prototype prototype, LOD[][] lods) { }

	private static Mesh CombineSimple(MeshFilter[] meshFilters, Vector3 commonPosition) { }

	private void CombineSpeedTree(List[] lodsRenderersList, LOD[][] lods, int lodNum, int rendererNum, PrototypeRenderer prototypeRenderer) { }

	private static void ConfigurateLodGroup(LODGroup lodGroup, List[] lodsRenderersList, float[] cullingRates) { }

	private static void CopyRenderers(List[] lodsRenderersList, int lodNum, PrototypeRenderer prototypeRenderer) { }

	private void CreateLodGroupGO(List[] lodsRenderersList, Prototype prototype, string name) { }

	private static LODGroup[][,] Distribute(Terrain terrain, IEnumerable lodGroups, float cellSize) { }

	private static int GetID(LODGroup lodGroup) { }

	private static Dictionary GetPrototypes(IEnumerable lodGroups) { }

	private void OnDrawGizmosSelected() { }

	private static Dictionary SeparateByPrototype(LODGroup[] groups) { }

	private static void SpawnPrefabs(Terrain terrain, Transform spawnTarget) { }

	public static void UpdateTreesInteractiveParts(Terrain terrain) { }

}

