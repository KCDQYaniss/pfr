namespace EFT.Visual;

public sealed class JackOLantern : Dress
{
	[SerializeField]
	private VolumetricLight _volumetricLight; //Field offset: 0x40
	private Transform _originalParent; //Field offset: 0x48

	public JackOLantern() { }

	protected virtual void AdjustShadowMode(EPointOfView pointOfView) { }

	protected virtual IEnumerable GetRenderers() { }

	protected virtual void OnSkin(Transform playerTransform, Transform meshTransform) { }

	public virtual void Unskin() { }

}

