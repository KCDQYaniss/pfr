//Type is in global namespace

public class ImageController : MonoBehaviour
{
	[SerializeField]
	private List _noGreyscaleImages; //Field offset: 0x20
	[SerializeField]
	private List _greyscaleImages; //Field offset: 0x28
	[SerializeField]
	private IconGreyscaleData _greyscaleData; //Field offset: 0x30
	[SerializeField]
	private IconBlurData _blurData; //Field offset: 0x40
	private List _originNoGreyscaleMaterials; //Field offset: 0x60
	private List _originGreyscaleMaterials; //Field offset: 0x68
	private Material _greyscaleOnlyMaterial; //Field offset: 0x70
	private Material _noGreyscaleMaterial; //Field offset: 0x78
	private ConstantBuffer _blurBuffer; //Field offset: 0x80
	private ConstantBuffer _greyScaleBuffer; //Field offset: 0x88

	public ImageController() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Update() { }

}

