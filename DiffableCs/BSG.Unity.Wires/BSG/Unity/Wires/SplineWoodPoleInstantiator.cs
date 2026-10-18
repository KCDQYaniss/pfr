namespace BSG.Unity.Wires;

public class SplineWoodPoleInstantiator : SplinePrefabInstantiator
{
	public Vector2 RandomOffset; //Field offset: 0xD8
	private List _instantiatedPrefabs; //Field offset: 0xE0
	public float WireShapeSize; //Field offset: 0xE8
	public int WireShapeDetails; //Field offset: 0xEC
	public int WireRestart; //Field offset: 0xF0
	public int WireParts; //Field offset: 0xF4
	public float Gravity; //Field offset: 0xF8
	public Vector2 GravityRandom; //Field offset: 0xFC
	public Material WireMaterial; //Field offset: 0x108
	public bool AutoGenerateWires; //Field offset: 0x110
	public bool AddLods; //Field offset: 0x111
	public float CullingRate; //Field offset: 0x114
	public bool OrientationByWorldUp; //Field offset: 0x118
	public List WireGenerators; //Field offset: 0x120
	public float WireSpawnProbability; //Field offset: 0x128
	public bool DontGenerateWires; //Field offset: 0x12C
	public bool CastShadows; //Field offset: 0x12D
	private int _wiresOnPoleCount; //Field offset: 0x130
	private string[] _names; //Field offset: 0x138
	private Transform _wireGeneratorParent; //Field offset: 0x140
	private bool _generateWireDelayed; //Field offset: 0x148
	public bool Hold; //Field offset: 0x149

	public SplineWoodPoleInstantiator() { }

}

