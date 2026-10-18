//Type is in global namespace

public class ColorDetailInstancing : MonoBehaviour
{
	internal struct MaterialControlls
	{
		public Material material; //Field offset: 0x0
		public Color Color; //Field offset: 0x8
		public int DetailTexIndex; //Field offset: 0x18
		public float DetailScale; //Field offset: 0x1C
		[HideInInspector]
		public MaterialLink[] Links; //Field offset: 0x20

	}

	internal struct MaterialLink
	{
		public MeshRenderer MeshRenderer; //Field offset: 0x0
		public int MaterialIndex; //Field offset: 0x8

		public MaterialLink(MeshRenderer meshRenderer, int materialIndex) { }

	}

	private static Shader _shader; //Field offset: 0x0
	private static readonly int _colorID; //Field offset: 0x8
	private static readonly int _detailValuesID; //Field offset: 0xC
	private static readonly int _detailArrayID; //Field offset: 0x10
	private static MaterialPropertyBlock _properties; //Field offset: 0x18
	[SerializeField]
	private MaterialControlls[] _materials; //Field offset: 0x20

	private static ColorDetailInstancing() { }

	public ColorDetailInstancing() { }

	private void Awake() { }

	private static void SetupMaterials(MaterialControlls[] controlls) { }

}

