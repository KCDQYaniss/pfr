//Type is in global namespace

public class BaseBallistic : MonoBehaviour
{
	internal enum ESurfaceSound
	{
		Concrete = 0,
		Metal = 1,
		Wood = 2,
		Soil = 3,
		Grass = 4,
		Asphalt = 5,
		Glass = 6,
		Gravel = 7,
		MetalThin = 8,
		Puddle = 9,
		Slate = 10,
		Tile = 11,
		WoodThick = 12,
		Swamp = 13,
		Garbage = 14,
		GarbageMetal = 15,
		Plastic = 16,
		WholeGlass = 17,
		WoodThin = 18,
		Snow = 19,
	}

	[HideInInspector]
	public ESurfaceSound SurfaceSound; //Field offset: 0x20

	public BaseBallistic() { }

	public void Associate(MaterialType typeOfMaterial) { }

	public override BallisticCollider Get(Vector3 pos) { }

	public override ESurfaceSound GetSurfaceSound(Vector3 position) { }

	public override void TakeSettingsFrom(BaseBallistic collider) { }

}

