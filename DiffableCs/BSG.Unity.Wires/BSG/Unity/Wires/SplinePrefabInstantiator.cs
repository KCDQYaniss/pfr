namespace BSG.Unity.Wires;

public class SplinePrefabInstantiator : MonoBehaviour
{
	internal enum Flip
	{
		None = 0,
		Flip180 = 1,
		Flip90 = 2,
	}

	internal struct Point
	{
		public Vector3 Position; //Field offset: 0x0
		public Vector3 Upward; //Field offset: 0xC
		public Vector3 Forward; //Field offset: 0x18
		public float Length; //Field offset: 0x24

	}

	internal class PrefabContainer
	{
		public GameObject Prefab; //Field offset: 0x10
		[Range(0, 100)]
		public float Probability; //Field offset: 0x18

		public PrefabContainer() { }

	}

	[CompilerGenerated]
	private Action OnGenerate; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnUpdatePoint; //Field offset: 0x28
	public SplinePrefabInstantiator Parent; //Field offset: 0x30
	public Vector3 ShiftRelativeToParent; //Field offset: 0x38
	public PrefabContainer[] Prefabs; //Field offset: 0x48
	public Vector3[] Positins; //Field offset: 0x50
	public Vector3[] Normals; //Field offset: 0x58
	public float DistanceBetweenPoints; //Field offset: 0x60
	public float Shift; //Field offset: 0x64
	public int Parts; //Field offset: 0x68
	public bool PlaceBetweenPoints; //Field offset: 0x6C
	public Vector3 EulerRotation; //Field offset: 0x70
	public bool HoldSplineRotation; //Field offset: 0x7C
	public Vector3 RandomRotationEulers; //Field offset: 0x80
	public float Scale; //Field offset: 0x8C
	public Vector3 RandomScale; //Field offset: 0x90
	public Flip FlipX; //Field offset: 0x9C
	public Flip FlipY; //Field offset: 0xA0
	public Flip FlipZ; //Field offset: 0xA4
	public bool ProjectOnTerrain; //Field offset: 0xA8
	public LayerMask Layer; //Field offset: 0xAC
	public float CheckRange; //Field offset: 0xB0
	public float TerrainOffset; //Field offset: 0xB4
	protected Vector3 _transformPosition; //Field offset: 0xB8
	protected Vector3 _parentFixPosition; //Field offset: 0xC4
	public Point[] QuantizedPoints; //Field offset: 0xD0

	public event Action OnGenerate
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnUpdatePoint
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public SplinePrefabInstantiator() { }

	[CompilerGenerated]
	public void add_OnGenerate(Action value) { }

	[CompilerGenerated]
	public void add_OnUpdatePoint(Action value) { }

	[CompilerGenerated]
	public void remove_OnGenerate(Action value) { }

	[CompilerGenerated]
	public void remove_OnUpdatePoint(Action value) { }

}

