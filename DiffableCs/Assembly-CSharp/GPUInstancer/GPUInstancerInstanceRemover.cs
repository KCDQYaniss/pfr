namespace GPUInstancer;

public class GPUInstancerInstanceRemover : MonoBehaviour
{
	public bool useBounds; //Field offset: 0x20
	public List selectedColliders; //Field offset: 0x28
	public bool removeFromDetailManagers; //Field offset: 0x30
	public bool removeFromTreeManagers; //Field offset: 0x31
	public bool removeFromPrefabManagers; //Field offset: 0x32
	public bool removeAtUpdate; //Field offset: 0x33
	public float offset; //Field offset: 0x34
	public bool onlyRemoveSelectedPrototypes; //Field offset: 0x38
	public List selectedPrototypes; //Field offset: 0x40

	public GPUInstancerInstanceRemover() { }

	private void Reset() { }

	private void Start() { }

	private void Update() { }

}

