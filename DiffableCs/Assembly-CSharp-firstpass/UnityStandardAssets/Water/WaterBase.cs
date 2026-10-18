namespace UnityStandardAssets.Water;

[ExecuteInEditMode]
public class WaterBase : MonoBehaviour
{
	public Material sharedMaterial; //Field offset: 0x20
	public WaterQuality waterQuality; //Field offset: 0x28
	public bool edgeBlend; //Field offset: 0x2C

	public WaterBase() { }

	public void Start() { }

	public void Update() { }

	public void UpdateShader() { }

	public void WaterTileBeingRendered(Transform tr, Camera currentCam) { }

}

