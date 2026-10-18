//Type is in global namespace

[CreateAssetMenu(menuName = "MetaXRAudio/Acoustic Material Properties")]
internal class MetaXRAcousticMaterialProperties : ScriptableObject, IMaterialDataProvider
{
	public enum BuiltinPreset
	{
		Custom = 0,
		AcousticTile = 1,
		Brick = 2,
		BrickPainted = 3,
		Cardboard = 4,
		Carpet = 5,
		CarpetHeavy = 6,
		CarpetHeavyPadded = 7,
		CeramicTile = 8,
		Concrete = 9,
		ConcreteRough = 10,
		ConcreteBlock = 11,
		ConcreteBlockPainted = 12,
		Curtain = 13,
		Foliage = 14,
		Glass = 15,
		GlassHeavy = 16,
		Grass = 17,
		Gravel = 18,
		GypsumBoard = 19,
		Marble = 20,
		Mud = 21,
		PlasterOnBrick = 22,
		PlasterOnConcreteBlock = 23,
		Rubber = 24,
		Soil = 25,
		SoundProof = 26,
		Snow = 27,
		Steel = 28,
		Stone = 29,
		Vent = 30,
		Water = 31,
		WoodThin = 32,
		WoodThick = 33,
		WoodFloor = 34,
		WoodOnConcrete = 35,
		MetaDefault = 36,
	}

	[SerializeField]
	private MaterialData data; //Field offset: 0x18
	[SerializeField]
	private BuiltinPreset preset; //Field offset: 0x20

	public override MaterialData Data
	{
		 get { } //Length: 5
	}

	internal BuiltinPreset Preset
	{
		internal get { } //Length: 4
		internal set { } //Length: 61
	}

	public MetaXRAcousticMaterialProperties() { }

	private static void AcousticTile(ref MaterialData data) { }

	private static void Brick(ref MaterialData data) { }

	private static void BrickPainted(ref MaterialData data) { }

	private static void Cardboard(ref MaterialData data) { }

	private static void Carpet(ref MaterialData data) { }

	private static void CarpetHeavy(ref MaterialData data) { }

	private static void CarpetHeavyPadded(ref MaterialData data) { }

	private static void CeramicTile(ref MaterialData data) { }

	private static void Concrete(ref MaterialData data) { }

	private static void ConcreteBlock(ref MaterialData data) { }

	private static void ConcreteBlockPainted(ref MaterialData data) { }

	private static void ConcreteRough(ref MaterialData data) { }

	private static void Curtain(ref MaterialData data) { }

	private static void Foliage(ref MaterialData data) { }

	public override MaterialData get_Data() { }

	internal BuiltinPreset get_Preset() { }

	private static void Glass(ref MaterialData data) { }

	private static void GlassHeavy(ref MaterialData data) { }

	private static void Grass(ref MaterialData data) { }

	private static void Gravel(ref MaterialData data) { }

	private static void GypsumBoard(ref MaterialData data) { }

	private static void Marble(ref MaterialData data) { }

	private override string Meta.XR.Acoustics.IMaterialDataProvider.get_name() { }

	private static void MetaDefault(ref MaterialData data) { }

	private static void Mud(ref MaterialData data) { }

	private static void PlasterOnBrick(ref MaterialData data) { }

	private static void PlasterOnConcreteBlock(ref MaterialData data) { }

	private static void Rubber(ref MaterialData data) { }

	internal void set_Preset(BuiltinPreset value) { }

	internal static void SetPreset(BuiltinPreset builtinPreset, ref MaterialData data) { }

	private static void Snow(ref MaterialData data) { }

	private static void Soil(ref MaterialData data) { }

	private static void SoundProof(ref MaterialData data) { }

	private static void Steel(ref MaterialData data) { }

	private static void Stone(ref MaterialData data) { }

	private static void Vent(ref MaterialData data) { }

	private static void Water(ref MaterialData data) { }

	private static void WoodFloor(ref MaterialData data) { }

	private static void WoodOnConcrete(ref MaterialData data) { }

	private static void WoodThick(ref MaterialData data) { }

	private static void WoodThin(ref MaterialData data) { }

}

