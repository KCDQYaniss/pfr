//Type is in global namespace

[Obsolete]
public sealed class BloodOnScreenOld : Posteffect
{
	internal struct BloodData
	{
		public Texture DuDv; //Field offset: 0x0
		public Texture Blood; //Field offset: 0x8

	}

	private static readonly int _inputMin; //Field offset: 0x0
	private static readonly int _inputMax; //Field offset: 0x4
	private static readonly int _inputGamma; //Field offset: 0x8
	private static readonly int _outputMin; //Field offset: 0xC
	private static readonly int _outputMax; //Field offset: 0x10
	private static readonly int _blured; //Field offset: 0x14
	[Header("Blood")]
	[SerializeField]
	private BloodData[] _bloodData; //Field offset: 0x40
	[SerializeField]
	private string _dudvPropertyName; //Field offset: 0x48
	[SerializeField]
	private string _bloodPropertyName; //Field offset: 0x50
	[SerializeField]
	private string _bloodAmountPropertyName; //Field offset: 0x58
	[SerializeField]
	private string _cutoutPropertyName; //Field offset: 0x60
	[Range(0, 1)]
	[SerializeField]
	private float _cutout; //Field offset: 0x68
	[Range(0, 1)]
	[SerializeField]
	private float _bloodTextureAmount; //Field offset: 0x6C
	[Header("Refraction")]
	[Range(0, 1)]
	[SerializeField]
	private float _refraction; //Field offset: 0x70
	[SerializeField]
	private string _refractionPropertyName; //Field offset: 0x78
	[Header("Downsampling")]
	[Range(0, 4)]
	[SerializeField]
	private int _downsampling; //Field offset: 0x80
	[Header("Color corection")]
	[HideInInspector]
	[SerializeField]
	public int Mode; //Field offset: 0x84
	[HideInInspector]
	[SerializeField]
	public float InputMinL; //Field offset: 0x88
	[HideInInspector]
	[SerializeField]
	public float InputMaxL; //Field offset: 0x8C
	[HideInInspector]
	[SerializeField]
	public float InputGammaL; //Field offset: 0x90
	[HideInInspector]
	[SerializeField]
	public float InputMinR; //Field offset: 0x94
	[HideInInspector]
	[SerializeField]
	public float InputMaxR; //Field offset: 0x98
	[HideInInspector]
	[SerializeField]
	public float InputGammaR; //Field offset: 0x9C
	[HideInInspector]
	[SerializeField]
	public float InputMinG; //Field offset: 0xA0
	[HideInInspector]
	[SerializeField]
	public float InputMaxG; //Field offset: 0xA4
	[HideInInspector]
	[SerializeField]
	public float InputGammaG; //Field offset: 0xA8
	[HideInInspector]
	[SerializeField]
	public float InputMinB; //Field offset: 0xAC
	[HideInInspector]
	[SerializeField]
	public float InputMaxB; //Field offset: 0xB0
	[HideInInspector]
	[SerializeField]
	public float InputGammaB; //Field offset: 0xB4
	[HideInInspector]
	[SerializeField]
	public float OutputMinL; //Field offset: 0xB8
	[HideInInspector]
	[SerializeField]
	public float OutputMaxL; //Field offset: 0xBC
	[HideInInspector]
	[SerializeField]
	public float OutputMinR; //Field offset: 0xC0
	[HideInInspector]
	[SerializeField]
	public float OutputMaxR; //Field offset: 0xC4
	[HideInInspector]
	[SerializeField]
	public float OutputMinG; //Field offset: 0xC8
	[HideInInspector]
	[SerializeField]
	public float OutputMaxG; //Field offset: 0xCC
	[HideInInspector]
	[SerializeField]
	public float OutputMinB; //Field offset: 0xD0
	[HideInInspector]
	[SerializeField]
	public float OutputMaxB; //Field offset: 0xD4
	private Dictionary _blood; //Field offset: 0xD8

	public float Cutout
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public int TextureSetsAmount
	{
		 get { } //Length: 26
	}

	private static BloodOnScreenOld() { }

	public BloodOnScreenOld() { }

	public float get_Cutout() { }

	public int get_TextureSetsAmount() { }

	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destanation) { }

	public void set_Cutout(float value) { }

	public void SetTexture(int setNumber) { }

	protected virtual void Start() { }

}

