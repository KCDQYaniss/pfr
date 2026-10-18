namespace EFT.Water;

[ExecuteAlways]
public class DynamicWaterObject : MonoBehaviour
{
	[SerializeField]
	private TrailRenderer _renderer; //Field offset: 0x20
	[SerializeField]
	private Material _material; //Field offset: 0x28
	[SerializeField]
	private float _width; //Field offset: 0x30

	public bool Enabled
	{
		 get { } //Length: 383
	}

	public Material GetMaterial
	{
		 get { } //Length: 5
	}

	public Renderer GetRenderer
	{
		 get { } //Length: 5
	}

	public DynamicWaterObject() { }

	public bool get_Enabled() { }

	public Material get_GetMaterial() { }

	public Renderer get_GetRenderer() { }

	private void OnDisable() { }

	public void OnEnable() { }

	public void SetWidth(float width) { }

	private void Update() { }

}

