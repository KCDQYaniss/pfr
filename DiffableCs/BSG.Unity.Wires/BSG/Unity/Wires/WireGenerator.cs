namespace BSG.Unity.Wires;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class WireGenerator : MonoBehaviour
{
	public Wire[] Wires; //Field offset: 0x20
	public int ShapeDetails; //Field offset: 0x28
	public float ShapeSize; //Field offset: 0x2C
	public bool IsPlacePrefabsAlongWires; //Field offset: 0x30
	public GameObject[] Prefabs; //Field offset: 0x38
	public GameObject StartsWithPrefab; //Field offset: 0x40
	public bool StickAtStart; //Field offset: 0x48
	public GameObject EndsWithPrefab; //Field offset: 0x50
	public bool StickAtEnd; //Field offset: 0x58
	public float PlacePrefabShiftAtStart; //Field offset: 0x5C
	public float PlacePrefabShiftAtEnd; //Field offset: 0x60
	public Mesh Mesh; //Field offset: 0x68

	public WireGenerator() { }

}

