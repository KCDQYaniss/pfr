namespace JBooth.MicroSplat.EFT;

[CreateAssetMenu(fileName = "MicroSplatSeasons", menuName = "Scriptable objects/MicroSplatSeasons", order = 1)]
public sealed class MicroSplatSeasons : ScriptableObject, IDisposable
{
	[SerializeField]
	private MicroSplatSeasonsMaterials _summerMaterials; //Field offset: 0x18
	[SerializeField]
	private MicroSplatSeasonsMaterials _autumnMaterials; //Field offset: 0x20
	[SerializeField]
	private MicroSplatSeasonsMaterials _autumnLateMaterials; //Field offset: 0x28
	[SerializeField]
	private MicroSplatSeasonsMaterials _winterMaterials; //Field offset: 0x30
	[SerializeField]
	private MicroSplatSeasonsMaterials _springEarlyMaterials; //Field offset: 0x38
	[SerializeField]
	private MicroSplatSeasonsMaterials _springMaterials; //Field offset: 0x40

	public MicroSplatSeasonsMaterials AutumnLateMaterials
	{
		 get { } //Length: 5
	}

	public MicroSplatSeasonsMaterials AutumnMaterials
	{
		 get { } //Length: 5
	}

	public MicroSplatSeasonsMaterials SpringEarlyMaterials
	{
		 get { } //Length: 5
	}

	public MicroSplatSeasonsMaterials SpringMaterials
	{
		 get { } //Length: 5
	}

	public MicroSplatSeasonsMaterials SummerMaterials
	{
		 get { } //Length: 5
	}

	public MicroSplatSeasonsMaterials WinterMaterials
	{
		 get { } //Length: 76
	}

	public MicroSplatSeasons() { }

	public override void Dispose() { }

	public MicroSplatSeasonMaterial Get(Season season, QUALITY quality) { }

	public MicroSplatSeasonsMaterials Get(Season season) { }

	public MicroSplatSeasonsMaterials get_AutumnLateMaterials() { }

	public MicroSplatSeasonsMaterials get_AutumnMaterials() { }

	public MicroSplatSeasonsMaterials get_SpringEarlyMaterials() { }

	public MicroSplatSeasonsMaterials get_SpringMaterials() { }

	public MicroSplatSeasonsMaterials get_SummerMaterials() { }

	public MicroSplatSeasonsMaterials get_WinterMaterials() { }

}

