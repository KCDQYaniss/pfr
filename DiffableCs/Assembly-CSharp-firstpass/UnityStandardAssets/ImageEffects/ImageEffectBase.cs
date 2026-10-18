namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu(null)]
[RequireComponent(typeof(Camera))]
public class ImageEffectBase : MonoBehaviour
{
	public Shader shader; //Field offset: 0x20
	private Material m_Material; //Field offset: 0x28

	protected Material material
	{
		 get { } //Length: 435
	}

	public ImageEffectBase() { }

	protected Material get_material() { }

	protected override void OnDisable() { }

	protected override void Start() { }

}

