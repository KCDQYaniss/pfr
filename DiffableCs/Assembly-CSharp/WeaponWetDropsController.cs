//Type is in global namespace

[Obfuscation(Exclude = True)]
[Obsolete]
public class WeaponWetDropsController : WeaponCubeMapper
{
	private static readonly int _refr; //Field offset: 0x0
	private static readonly int _lerp; //Field offset: 0x4
	private static readonly int _dropsMap; //Field offset: 0x8
	private static readonly int _noise; //Field offset: 0xC
	[SerializeField]
	private Shader _shaderToReplace; //Field offset: 0x38
	[SerializeField]
	private float _refraction; //Field offset: 0x40
	[SerializeField]
	private Texture2D _refractionMap; //Field offset: 0x48
	[SerializeField]
	private Texture2D _mask; //Field offset: 0x50

	private static WeaponWetDropsController() { }

	public WeaponWetDropsController() { }

	public void Init(Texture2D rainDistort, Texture2D rainMask) { }

	private void InternalInit() { }

}

