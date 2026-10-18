namespace AbsolutDecals;

public class DecalTester : MonoBehaviour
{
	public LayerMask Mask; //Field offset: 0x20
	public Material Mat; //Field offset: 0x28
	private List _transforms; //Field offset: 0x30
	private List _renderers; //Field offset: 0x38
	private int _meshCount; //Field offset: 0x40
	private int _tmpMeshCount; //Field offset: 0x44

	public DecalTester() { }

	private bool AddMeshToList(Renderer currentRenderer) { }

	private void Update() { }

}

