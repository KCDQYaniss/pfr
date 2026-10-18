namespace EFT;

public class NPCCurveToShape : MonoBehaviour
{
	internal class NamedBlendshape
	{
		public string name; //Field offset: 0x10
		[Range(0, 100)]
		public float targetWeight; //Field offset: 0x18
		[HideInInspector]
		public int index; //Field offset: 0x1C

		public NamedBlendshape() { }

	}

	[SerializeField]
	private Animator _animator; //Field offset: 0x20
	[SerializeField]
	private SkinnedMeshRenderer _meshRenderer; //Field offset: 0x28
	[SerializeField]
	private string _curveName; //Field offset: 0x30
	[SerializeField]
	private List _blendshapes; //Field offset: 0x38
	private int _curveHash; //Field offset: 0x40

	public NPCCurveToShape() { }

	private void Awake() { }

	private void CacheBlendshapeIndices() { }

	private void Update() { }

}

