namespace EFT.Visual;

public class Dress : MonoBehaviour, IDress
{
	public EDecalTextureType DecalTextureType; //Field offset: 0x20
	protected PlayerBody PlayerBody; //Field offset: 0x28
	protected readonly CompositeDisposable CompositeDisposable; //Field offset: 0x30
	[SerializeField]
	protected Renderer[] Renderers; //Field offset: 0x38

	public Dress() { }

	protected override void AdjustShadowMode(EPointOfView pointOfView) { }

	public override void Deinit() { }

	public BodyRenderer GetBodyRenderer() { }

	protected override IEnumerable GetRenderers() { }

	public override void Init(PlayerBody playerBody) { }

	public override void Init(Item item, bool isAnimated) { }

	protected override void OnSkin(Transform playerTransform, Transform meshTransform) { }

	public void Skin(Transform playerTransform, Transform meshTransform) { }

	public override void Unskin() { }

}

