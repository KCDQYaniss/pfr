namespace EFT.WboitSmoke;

public sealed class ParticleCompositeBinder : MonoBehaviour
{
	private MeshRenderer _renderer; //Field offset: 0x20
	private IndirectParticlesProfile _profile; //Field offset: 0x28
	private Func _contextResolver; //Field offset: 0x30
	private Func _alphaProvider; //Field offset: 0x38
	private MaterialPropertyBlock _propertyBlock; //Field offset: 0x40

	public ParticleCompositeBinder() { }

	private void ApplyContext(ParticleCameraContext context) { }

	private void ApplyHiddenState() { }

	private MaterialPropertyBlock GetPropertyBlock() { }

	internal void Initialize(MeshRenderer rend, IndirectParticlesProfile profile, Func contextResolver, Func alphaProvider) { }

	private void OnWillRenderObject() { }

	private bool TryGetContextForCurrentCamera(out ParticleCameraContext context) { }

}

