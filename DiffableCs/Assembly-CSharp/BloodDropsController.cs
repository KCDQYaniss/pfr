//Type is in global namespace

public class BloodDropsController
{
	private const int MaxDrops = 64; //Field offset: 0x0
	private int _initialBloodDrops; //Field offset: 0x10
	private int _renderTextureDimension; //Field offset: 0x14
	private Vector2 _dropLifetimeDistribution; //Field offset: 0x18
	private Queue _dropsToRender; //Field offset: 0x20
	private Queue _freeDrops; //Field offset: 0x28
	private readonly RenderTexture _dropsTex; //Field offset: 0x30
	public BloodDropPlacer DropPlacer; //Field offset: 0x38
	public Action OnImageRendered; //Field offset: 0x40
	private float _offGlassLifetimeMultiplier; //Field offset: 0x48
	private float _currentLifetimeMultiplier; //Field offset: 0x4C

	public private int InitialBloodDrops
	{
		private get { } //Length: 164
		 set { } //Length: 16
	}

	public BloodDropsController(float aspect, int renderTextureDimension, Material dropMaterial, Vector2 dropLifetimeDistribution, float offGlassLifetimeMultiplier) { }

	public void CaptureBloodShot(Vector3 direction) { }

	public void CaptureBloodShotBleeding(Vector3 direction, bool isArterial) { }

	public void ChangeGlassState(bool hasGlasses) { }

	public void Destroy() { }

	private int get_InitialBloodDrops() { }

	public void set_InitialBloodDrops(int value) { }

	public void Update() { }

}

