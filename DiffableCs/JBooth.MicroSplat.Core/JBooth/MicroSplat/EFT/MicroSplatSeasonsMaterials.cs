namespace JBooth.MicroSplat.EFT;

[CreateAssetMenu(fileName = "MicroSplatSeasonsMaterials", menuName = "Scriptable objects/MicroSplatSeasonsMaterials", order = 1)]
public sealed class MicroSplatSeasonsMaterials : ScriptableObject, IDisposable
{
	[SerializeField]
	private MicroSplatSeasonMaterial _highQuality; //Field offset: 0x18
	[SerializeField]
	private MicroSplatSeasonMaterial _medQuality; //Field offset: 0x20
	[SerializeField]
	private MicroSplatSeasonMaterial _lowQuality; //Field offset: 0x28

	public MicroSplatSeasonMaterial HighQuality
	{
		 get { } //Length: 5
	}

	public MicroSplatSeasonMaterial LowQuality
	{
		 get { } //Length: 5
	}

	public MicroSplatSeasonMaterial MediumQuality
	{
		 get { } //Length: 5
	}

	public MicroSplatSeasonsMaterials() { }

	public override void Dispose() { }

	public MicroSplatSeasonMaterial Get(QUALITY quality) { }

	public MicroSplatSeasonMaterial get_HighQuality() { }

	public MicroSplatSeasonMaterial get_LowQuality() { }

	public MicroSplatSeasonMaterial get_MediumQuality() { }

}

