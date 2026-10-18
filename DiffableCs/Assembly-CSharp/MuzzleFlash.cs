//Type is in global namespace

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class MuzzleFlash : MonoBehaviour
{
	public int Count; //Field offset: 0x20
	public int TileSheetRows; //Field offset: 0x24
	public int TileSheetColumns; //Field offset: 0x28
	private Vector2[][] _tiles; //Field offset: 0x30
	private Vector3[] _vertices; //Field offset: 0x38
	private Vector2[] _uv; //Field offset: 0x40
	private Vector2[] _uv2Vals; //Field offset: 0x48
	private int[] _triangles; //Field offset: 0x50
	private Mesh _mesh; //Field offset: 0x58
	private int _tilesCount; //Field offset: 0x60
	private bool _oneTile; //Field offset: 0x64
	private int _lastTile; //Field offset: 0x68
	private Unrepeated _random; //Field offset: 0x70

	public MuzzleFlash() { }

	public void AddFlash(float radius, float durationTime, float addTime, bool randomRotation) { }

	private void Awake() { }

	private void LateUpdate() { }

}

