//Type is in global namespace

public sealed class SeasonsMaterialsFixer : MonoBehaviourSingleton
{
	[FormerlySerializedAs("WinterMaterials")]
	[SerializeField]
	private SeasonsMaterialsMap _materialsMap; //Field offset: 0x20
	private SeasonsMaterialsGroup _runtimeGroup; //Field offset: 0x28

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public SeasonsMaterialsFixer() { }

	public void Add(ISeasonsMaterial material) { }

	public virtual void Awake() { }

	public void FixMaterials() { }

	private static AbstractLogger get_Logger() { }

	internal Task LoadAutumn() { }

	internal Task LoadAutumnLate() { }

	internal Task LoadSpring() { }

	internal Task LoadSpringEarly() { }

	internal Task LoadSummer() { }

	internal Task LoadWinter() { }

	public void Remove(ISeasonsMaterial material) { }

	public void Unload() { }

}

