namespace TerrainStitch;

public class TerrainNeighbours : MonoBehaviour
{
	private Terrain[] _terrains; //Field offset: 0x20
	private Dictionary _terrainDict; //Field offset: 0x28
	public Vector2 firstPosition; //Field offset: 0x30

	public TerrainNeighbours() { }

	public void CreateNeighbours() { }

	private void Start() { }

}

