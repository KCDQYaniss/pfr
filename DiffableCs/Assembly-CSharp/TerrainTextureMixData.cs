//Type is in global namespace

public class TerrainTextureMixData
{
	private static float[] _preallocatedTextureMixData; //Field offset: 0x0
	public byte[,] data; //Field offset: 0x10
	public Vector3 size; //Field offset: 0x18
	public int alphamapWidth; //Field offset: 0x24
	public int alphamapHeight; //Field offset: 0x28

	private static TerrainTextureMixData() { }

	public TerrainTextureMixData() { }

	private static TerrainTextureMixData CalculateMicrosplatTextureMixData(MicroSplatTerrain terrain) { }

	public static void CreateTextureMixDataAsset(string path, MicroSplatTerrain terrain) { }

	public void Deserialize(BinaryReader reader) { }

	public static int GetMainTexture(Vector3 worldPos, TerrainData terrainData, Vector3 terrainWorldPosition) { }

	public int GetTextureMix(Vector3 worldPos, Vector3 terrainWorldPosition) { }

	private static int GetTextureMix(Vector3 worldPos, TerrainData terrainData, Vector3 terrainWorldPosition, ref float[] result) { }

	public static TerrainTextureMixData LoadFromAsset(TextAsset asset) { }

	public void Serialize(BinaryWriter writer) { }

}

