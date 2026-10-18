//Type is in global namespace

[DisallowMultipleComponent]
[ExecuteInEditMode]
[ScriptOrder(-100)]
public class StencilShadow : MonoBehaviour
{
	public Color Ambient; //Field offset: 0x20
	public CullingSettings Culling; //Field offset: 0x30
	[CompilerGenerated]
	private Renderer <Renderer>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Bounds <Bounds>k__BackingField; //Field offset: 0x40
	public int DesiredDrawPriority; //Field offset: 0x58
	[Range(0, 1)]
	public float FogAttenuation; //Field offset: 0x5C
	[HideInInspector]
	[SerializeField]
	private int _drawPriority; //Field offset: 0x60
	private Mesh _sharedMesh; //Field offset: 0x68

	public int ActualDrawPriority
	{
		 get { } //Length: 4
	}

	public override Bounds Bounds
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 18
	}

	public private Renderer Renderer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public StencilShadow() { }

	[ContextMenu("Awake")]
	public void Awake() { }

	public int get_ActualDrawPriority() { }

	[CompilerGenerated]
	public override Bounds get_Bounds() { }

	[CompilerGenerated]
	public Renderer get_Renderer() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnValidate() { }

	[CompilerGenerated]
	protected override void set_Bounds(Bounds value) { }

	[CompilerGenerated]
	private void set_Renderer(Renderer value) { }

}

