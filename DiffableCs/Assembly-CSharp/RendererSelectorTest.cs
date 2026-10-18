//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Collider))]
public class RendererSelectorTest : MonoBehaviour
{
	private Collider _collider; //Field offset: 0x20
	private Plane[] _planes; //Field offset: 0x28
	[SerializeField]
	private bool _updateRendersEveryFrame; //Field offset: 0x30
	[SerializeField]
	private bool _updatePlanesEveryFrame; //Field offset: 0x31
	[SerializeField]
	private bool _updateSelectionEveryFrame; //Field offset: 0x32
	private ICollection _renderers; //Field offset: 0x38
	[SerializeField]
	private List _selectedRenderers; //Field offset: 0x40

	public RendererSelectorTest() { }

	private void Awake() { }

	private void OnDrawGizmosSelected() { }

	private void Update() { }

	private void UpdatePlanes() { }

	private void UpdateRenderes() { }

	private void UpdateSelection() { }

}

