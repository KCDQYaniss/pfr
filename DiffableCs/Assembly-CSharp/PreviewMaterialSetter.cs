//Type is in global namespace

public class PreviewMaterialSetter : MonoBehaviour
{
	private static readonly int _color; //Field offset: 0x0
	private static readonly int _reflectColor; //Field offset: 0x4
	[SerializeField]
	private Color _availableColor; //Field offset: 0x20
	[SerializeField]
	private Color _availableReflectionColor; //Field offset: 0x30
	[SerializeField]
	private Color _unvailableColor; //Field offset: 0x40
	[SerializeField]
	private Color _unvailableReflectionColor; //Field offset: 0x50
	private Dictionary _renderers; //Field offset: 0x60
	private Material _previewMaterial; //Field offset: 0x68

	private static PreviewMaterialSetter() { }

	public PreviewMaterialSetter() { }

	private void Awake() { }

	private void CreatePreviewMaterial() { }

	private Material[] GetSavedMaterials(MeshRenderer renderer) { }

	private void InitRenderers() { }

	private void OnDestroy() { }

	public void SetAvailable(bool isAvailable) { }

	private void SetPreviewMaterials(MeshRenderer renderer, Material[] savedMaterials) { }

}

