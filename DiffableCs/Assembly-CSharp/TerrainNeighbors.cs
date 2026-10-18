//Type is in global namespace

[RequireComponent(typeof(Terrain))]
public class TerrainNeighbors : MonoBehaviour
{
	public Terrain Left; //Field offset: 0x20
	public Terrain Right; //Field offset: 0x28
	public Terrain Top; //Field offset: 0x30
	public Terrain Bottom; //Field offset: 0x38

	public TerrainNeighbors() { }

	private void Awake() { }

	private void OnValidate() { }

	private void SetNeighbors() { }

}

