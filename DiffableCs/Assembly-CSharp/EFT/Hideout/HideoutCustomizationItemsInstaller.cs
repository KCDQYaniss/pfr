namespace EFT.Hideout;

public sealed class HideoutCustomizationItemsInstaller : MonoBehaviour
{
	[SerializeField]
	private HideoutCustomizationItemModelSpawnPoint _floorPoint; //Field offset: 0x20
	[SerializeField]
	private HideoutCustomizationItemModelSpawnPoint _wallPoint; //Field offset: 0x28
	[SerializeField]
	private HideoutCustomizationItemModelSpawnPoint _ceilingPoint; //Field offset: 0x30
	[SerializeField]
	private HideoutCustomizationItemModelSpawnPoint _lightingPoint; //Field offset: 0x38
	[SerializeField]
	private HideoutCustomizationItemModelSpawnPoint _shootingRangeMarkPoint; //Field offset: 0x40
	[SerializeField]
	private HideoutCustomizationItemModelSpawnPoint[] _postersPoints; //Field offset: 0x48
	[SerializeField]
	private HideoutCustomizationItemModelSpawnPoint[] _statuettesPoint; //Field offset: 0x50
	[SerializeField]
	private MeshRenderer[] _paperTargetsRenderers; //Field offset: 0x58
	[SerializeField]
	[Space(10)]
	private GameObject _wallPlugObject; //Field offset: 0x60
	[SerializeField]
	private GameObject _floorPlugObject; //Field offset: 0x68
	[SerializeField]
	private GameObject _ceilingPlugObject; //Field offset: 0x70
	[CompilerGenerated]
	private Dictionary <SlotsSpawnPoints>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private Dictionary <AllCustomizationPoints>k__BackingField; //Field offset: 0x80

	public private Dictionary AllCustomizationPoints
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Dictionary SlotsSpawnPoints
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HideoutCustomizationItemsInstaller() { }

	[CompilerGenerated]
	public Dictionary get_AllCustomizationPoints() { }

	[CompilerGenerated]
	public Dictionary get_SlotsSpawnPoints() { }

	private Transform GetSpawnPoint(EHideoutCustomizationType offerType) { }

	public void Init() { }

	[CompilerGenerated]
	private void set_AllCustomizationPoints(Dictionary value) { }

	[CompilerGenerated]
	private void set_SlotsSpawnPoints(Dictionary value) { }

	public void SetItem(EHideoutCustomizationType customizationType, StashItemModel itemObject) { }

	public void SetPaperTargetTexture(Texture texture) { }

}

