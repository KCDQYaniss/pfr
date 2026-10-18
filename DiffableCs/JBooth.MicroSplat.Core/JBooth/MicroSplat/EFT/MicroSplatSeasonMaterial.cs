namespace JBooth.MicroSplat.EFT;

[CreateAssetMenu(fileName = "MicroSplatSeasonMaterial", menuName = "Scriptable objects/MicroSplatSeasonMaterial", order = 1)]
public sealed class MicroSplatSeasonMaterial : ScriptableObject, IDisposable
{
	[SerializeField]
	private Material _material; //Field offset: 0x18
	[SerializeField]
	private MicroSplatKeywords _keywords; //Field offset: 0x20
	[SerializeField]
	private MicroSplatPropData _propData; //Field offset: 0x28

	public MicroSplatKeywords Keywords
	{
		 get { } //Length: 5
	}

	public Material Material
	{
		 get { } //Length: 5
	}

	public MicroSplatPropData PropData
	{
		 get { } //Length: 5
	}

	public MicroSplatSeasonMaterial() { }

	public override void Dispose() { }

	public MicroSplatKeywords get_Keywords() { }

	public Material get_Material() { }

	public MicroSplatPropData get_PropData() { }

}

