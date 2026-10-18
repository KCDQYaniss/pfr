namespace UnityStandardAssets.Water;

[ExecuteInEditMode]
public class WaterTile : MonoBehaviour
{
	public PlanarReflection reflection; //Field offset: 0x20
	public WaterBase waterBase; //Field offset: 0x28

	public WaterTile() { }

	private void AcquireComponents() { }

	public void OnWillRenderObject() { }

	public void Start() { }

}

