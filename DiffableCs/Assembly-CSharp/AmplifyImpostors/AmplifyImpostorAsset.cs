namespace AmplifyImpostors;

[CreateAssetMenu(fileName = "New Impostor", order = 85)]
public class AmplifyImpostorAsset : ScriptableObject
{
	[SerializeField]
	public Material Material; //Field offset: 0x18
	[SerializeField]
	public Mesh Mesh; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	public int Version; //Field offset: 0x28
	[SerializeField]
	public ImpostorType ImpostorType; //Field offset: 0x2C
	[HideInInspector]
	[SerializeField]
	public bool LockedSizes; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	public int SelectedSize; //Field offset: 0x34
	[SerializeField]
	public Vector2 TexSize; //Field offset: 0x38
	[HideInInspector]
	[SerializeField]
	public bool DecoupleAxisFrames; //Field offset: 0x40
	[Range(1, 32)]
	[SerializeField]
	public int HorizontalFrames; //Field offset: 0x44
	[Range(1, 33)]
	[SerializeField]
	public int VerticalFrames; //Field offset: 0x48
	[Range(0, 64)]
	[SerializeField]
	public int PixelPadding; //Field offset: 0x4C
	[Range(4, 16)]
	[SerializeField]
	public int MaxVertices; //Field offset: 0x50
	[Range(0, 0.2)]
	[SerializeField]
	public float Tolerance; //Field offset: 0x54
	[Range(0, 1)]
	[SerializeField]
	public float NormalScale; //Field offset: 0x58
	[SerializeField]
	public Vector2[] ShapePoints; //Field offset: 0x60
	[SerializeField]
	public AmplifyImpostorBakePreset Preset; //Field offset: 0x68
	[SerializeField]
	public List OverrideOutput; //Field offset: 0x70

	public AmplifyImpostorAsset() { }

}

