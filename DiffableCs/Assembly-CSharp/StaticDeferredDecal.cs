//Type is in global namespace

[ExecuteInEditMode]
public class StaticDeferredDecal : MonoBehaviour
{
	[CompilerGenerated]
	private static Action OnDecalRegister; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnDecalUnregister; //Field offset: 0x8
	private static readonly int _mainTex; //Field offset: 0x10
	private static readonly int _uvStartEnd; //Field offset: 0x14
	private static readonly int _tintID; //Field offset: 0x18
	public Vector2 LowerLeftPixel; //Field offset: 0x20
	public Vector2 UpperRightPixel; //Field offset: 0x28
	[SerializeField]
	public Material _material; //Field offset: 0x30
	[Range(0, 9)]
	[SerializeField]
	private int _decalQueue; //Field offset: 0x38
	[Range(-1, 1)]
	[SerializeField]
	private float _normalClip; //Field offset: 0x3C
	[SerializeField]
	private float _normalAlphaFadeoff; //Field offset: 0x40
	[Range(0, 1)]
	[SerializeField]
	private float _edgeClip; //Field offset: 0x44
	[SerializeField]
	private float _edgeAlphaFadeoff; //Field offset: 0x48
	[SerializeField]
	private Color _tint; //Field offset: 0x4C
	private Action _updateInstancesBuffersDelegate; //Field offset: 0x60
	private Action _refreshDelegate; //Field offset: 0x68
	private Vector3 _prevPos; //Field offset: 0x70
	private Quaternion _prevRot; //Field offset: 0x7C
	private Vector3 _prevScale; //Field offset: 0x8C
	[CompilerGenerated]
	private Texture2D <Tex>k__BackingField; //Field offset: 0x98
	[HideInInspector]
	public Vector2 LastTexSize; //Field offset: 0xA0

	public static event Action OnDecalRegister
	{
		[CompilerGenerated]
		 add { } //Length: 347
		[CompilerGenerated]
		 remove { } //Length: 347
	}

	public static event Action OnDecalUnregister
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public private Material DecalMaterial
	{
		 get { } //Length: 76
		private set { } //Length: 82
	}

	public int DecalQueue
	{
		 get { } //Length: 4
	}

	public private Texture2D Tex
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Color Tint
	{
		 get { } //Length: 11
	}

	private static StaticDeferredDecal() { }

	public StaticDeferredDecal() { }

	[CompilerGenerated]
	public static void add_OnDecalRegister(Action value) { }

	[CompilerGenerated]
	public static void add_OnDecalUnregister(Action value) { }

	public void Awake() { }

	public Material get_DecalMaterial() { }

	public int get_DecalQueue() { }

	[CompilerGenerated]
	public Texture2D get_Tex() { }

	public Color get_Tint() { }

	public Vector4 GetNormalEdgeClipAndFadeoff() { }

	public Vector4 GetUVStartEnd() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void Refresh() { }

	[CompilerGenerated]
	public static void remove_OnDecalRegister(Action value) { }

	[CompilerGenerated]
	public static void remove_OnDecalUnregister(Action value) { }

	public void RescaleGameObject() { }

	private void set_DecalMaterial(Material value) { }

	[CompilerGenerated]
	private void set_Tex(Texture2D value) { }

	private void SetTex() { }

}

