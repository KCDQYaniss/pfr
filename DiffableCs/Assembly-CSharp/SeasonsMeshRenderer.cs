//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
public class SeasonsMeshRenderer : MonoBehaviour, ISeasonsMaterial
{
	[SerializeField]
	private MeshRenderer _meshRenderer; //Field offset: 0x20
	[Header("Materials")]
	[SerializeField]
	private Material[] _summerMaterials; //Field offset: 0x28
	[SerializeField]
	private Material[] _winterMaterials; //Field offset: 0x30
	[SerializeField]
	private Material[] _springMaterials; //Field offset: 0x38
	[SerializeField]
	private Material[] _springEarlyMaterials; //Field offset: 0x40
	[SerializeField]
	private Material[] _autumnMaterials; //Field offset: 0x48
	[SerializeField]
	private Material[] _autumnLateMaterials; //Field offset: 0x50
	private Material[] _current; //Field offset: 0x58
	private Material[] _cached; //Field offset: 0x60

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public SeasonsMeshRenderer() { }

	private static void CheckAndThrow(Material[] materials, SeasonsMeshRenderer renderer) { }

	[ContextMenu("Check Length")]
	private void CheckMaterialsLength() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

	public override Task LoadAutumn() { }

	public override Task LoadAutumnLate() { }

	public override Task LoadSpring() { }

	public override Task LoadSpringEarly() { }

	public override Task LoadSummer() { }

	public override Task LoadWinter() { }

	private void OnDestroy() { }

	private void OnValidate() { }

	private void Start() { }

	public override void Unload() { }

}

