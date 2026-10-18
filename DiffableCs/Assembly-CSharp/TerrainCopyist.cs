//Type is in global namespace

[ExecuteInEditMode]
public class TerrainCopyist : MonoBehaviour
{
	public Terrain SourceTerrain; //Field offset: 0x20
	public Terrain TargetTerrain; //Field offset: 0x28

	public TerrainCopyist() { }

	public void CloneTerrain(Terrain sourceTerrain, Terrain workTerrain) { }

}

