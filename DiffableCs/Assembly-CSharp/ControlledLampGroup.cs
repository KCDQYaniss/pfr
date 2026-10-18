//Type is in global namespace

public class ControlledLampGroup : ISyncAble
{
	private enum EMaterialEmissionType
	{
		EmissionVisibility = 0,
		EmissionColor = 1,
	}

	private struct MaterialEmissionInfo
	{
		public EMaterialEmissionType EmissionType; //Field offset: 0x0
		public Color InitialEmissionColor; //Field offset: 0x4
		public float InitialEmission; //Field offset: 0x14
		public MaterialPropertyBlock MaterialPropertyBlock; //Field offset: 0x18
		[CanBeNull]
		public LampController ParentLampController; //Field offset: 0x20

	}

	private static readonly int _emissionVisibility; //Field offset: 0x0
	private static readonly int _emissionColor; //Field offset: 0x4
	[SerializeField]
	private LampController[] _lampControllers; //Field offset: 0x28
	[SerializeField]
	private CullingAdvancedLightObject[] _cullingAdvancedLightObjects; //Field offset: 0x30
	[SerializeField]
	private CullingLightObject[] _cullingLightObjects; //Field offset: 0x38
	[SerializeField]
	private Light[] _lights; //Field offset: 0x40
	[SerializeField]
	private MeshRenderer[] _meshRenderers; //Field offset: 0x48
	[SerializeField]
	private VolumetricLight[] _volumetricLights; //Field offset: 0x50
	[SerializeField]
	private BaseLight[] _baseLights; //Field offset: 0x58
	[SerializeField]
	[Tooltip("Drag root light object here")]
	private GameObject _fillLightFrom; //Field offset: 0x60
	[SerializeField]
	private AudioClip _turnOnSFX; //Field offset: 0x68
	[SerializeField]
	private AudioClip _turnOffSFX; //Field offset: 0x70
	[SerializeField]
	private Transform _sfxRootPosition; //Field offset: 0x78
	[SerializeField]
	private int _soundRolloff; //Field offset: 0x80
	[SerializeField]
	private EOcclusionTest _occlusionTest; //Field offset: 0x84
	[SerializeField]
	private FlareLight[] _multiFlareLights; //Field offset: 0x88
	[SerializeField]
	private bool _initialLightState; //Field offset: 0x90
	private bool _currentLightState; //Field offset: 0x91
	private bool _stateExternalApplied; //Field offset: 0x92
	private readonly Dictionary _materialInitialEmissionMap; //Field offset: 0x98
	private readonly Dictionary _lightInitialValues; //Field offset: 0xA0
	private Color _emptyColor; //Field offset: 0xA8

	public ulong ID
	{
		 get { } //Length: 7
	}

	private static ControlledLampGroup() { }

	public ControlledLampGroup() { }

	private void ApplyMaterialInfoColor(MeshRenderer meshRenderer, Material sharedMaterial, int index, MaterialEmissionInfo materialInfo, bool state, ref int infoIndex) { }

	private void ApplyMaterialInfoVisibility(MeshRenderer meshRenderer, Material sharedMaterial, int index, MaterialEmissionInfo materialInfo, bool state, ref int infoIndex) { }

	public virtual void Deserialize(IBitReaderStream readerStream) { }

	public ulong get_ID() { }

	private void OnLampDestroyed() { }

	private void OnLightStateChanged(bool nextState) { }

	private void PlaySfx(AudioClip clip) { }

	private void Record(List materialEmissionInfos, Material sharedMaterial, LampController lampController) { }

	private void RecordColor(List materialEmissionInfos, Material sharedMaterial, LampController lampController) { }

	private void RecordInitial() { }

	private void RecordVisibility(List materialEmissionInfos, Material sharedMaterial, LampController lampController) { }

	public virtual void Serialize(IBitWriterStream writerStream) { }

	private void SetLightState(bool state) { }

	public void SetLightStateExternal(bool state) { }

	private void Start() { }

	public void ToggleState() { }

}

