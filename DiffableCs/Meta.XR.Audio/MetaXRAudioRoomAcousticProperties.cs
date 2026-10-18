//Type is in global namespace

public sealed class MetaXRAudioRoomAcousticProperties : MonoBehaviour
{
	internal enum MaterialPreset
	{
		AcousticTile = 0,
		Brick = 1,
		BrickPainted = 2,
		Cardboard = 3,
		Carpet = 4,
		CarpetHeavy = 5,
		CarpetHeavyPadded = 6,
		CeramicTile = 7,
		Concrete = 8,
		ConcreteRough = 9,
		ConcreteBlock = 10,
		ConcreteBlockPainted = 11,
		Curtain = 12,
		Foliage = 13,
		Glass = 14,
		GlassHeavy = 15,
		Grass = 16,
		Gravel = 17,
		GypsumBoard = 18,
		Marble = 19,
		Mud = 20,
		PlasterOnBrick = 21,
		PlasterOnConcreteBlock = 22,
		Rubber = 23,
		Soil = 24,
		SoundProof = 25,
		Snow = 26,
		Steel = 27,
		Stone = 28,
		Vent = 29,
		Water = 30,
		WoodThin = 31,
		WoodThick = 32,
		WoodFloor = 33,
		WoodOnConcrete = 34,
		MetaDefault = 35,
	}

	private const int kAudioBandCount = 4; //Field offset: 0x0
	[Tooltip("Center the room model on the listener. When disabled, center the room model on the GameObject this script is attached to.")]
	public bool lockPositionToListener; //Field offset: 0x20
	[Tooltip("Width of the room model in meters")]
	public float width; //Field offset: 0x24
	[Tooltip("Height of the room model in meters")]
	public float height; //Field offset: 0x28
	[Tooltip("Depth of the room model in meters")]
	public float depth; //Field offset: 0x2C
	[Tooltip("Material of the left wall of the room model")]
	public MaterialPreset leftMaterial; //Field offset: 0x30
	[Tooltip("Material of the right wall of the room model")]
	public MaterialPreset rightMaterial; //Field offset: 0x34
	[Tooltip("Material of the ceiling of the room model")]
	public MaterialPreset ceilingMaterial; //Field offset: 0x38
	[Tooltip("Material of the floor of the room model")]
	public MaterialPreset floorMaterial; //Field offset: 0x3C
	[Tooltip("Material of the front wall of the room model")]
	public MaterialPreset frontMaterial; //Field offset: 0x40
	[Tooltip("Material of the back wall of the room model")]
	public MaterialPreset backMaterial; //Field offset: 0x44
	[Range(0, 1)]
	[Tooltip("Diffuses the reflections and reverberation to simulate objects inside the room. Zero represents a completely empty room.")]
	public float clutterFactor; //Field offset: 0x48
	private float[] clutterFactorBands; //Field offset: 0x50
	private float[] wallMaterials; //Field offset: 0x58

	public MetaXRAudioRoomAcousticProperties() { }

	[RuntimeInitializeOnLoadMethod]
	private static void CheckSceneHasRoom() { }

	private void SetWallMaterialPreset(int wallIndex, MaterialPreset materialPreset) { }

	private void SetWallMaterialProperties(int wallIndex, float band0, float band1, float band2, float band3) { }

	private void Update() { }

}

