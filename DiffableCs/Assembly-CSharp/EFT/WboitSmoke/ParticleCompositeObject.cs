namespace EFT.WboitSmoke;

internal sealed class ParticleCompositeObject : IDisposable
{
	private const string GAME_OBJECT_NAME = "Composition Quad"; //Field offset: 0x0
	private const float MIN_BOUNDS_SIZE = 0.01; //Field offset: 0x0
	private static Mesh _sharedQuadMesh; //Field offset: 0x0
	private readonly GameObject _gameObject; //Field offset: 0x10
	private readonly MeshRenderer _renderer; //Field offset: 0x18
	private bool _isDisposed; //Field offset: 0x20
	private Bounds _localBounds; //Field offset: 0x24

	public Bounds LocalBounds
	{
		 get { } //Length: 21
	}

	public MeshRenderer Renderer
	{
		 get { } //Length: 5
	}

	public ParticleCompositeObject(Material material, Vector3 position, out ParticleCompositeBinder binder) { }

	public override void Dispose() { }

	private static Bounds ExpandSmallBounds(Bounds bounds) { }

	public Bounds get_LocalBounds() { }

	public MeshRenderer get_Renderer() { }

	private static Mesh GetSharedQuadMesh() { }

	public void ResetBounds() { }

	public void SetVisible(bool visible) { }

	public void UpdateBounds(Bounds localBounds) { }

}

