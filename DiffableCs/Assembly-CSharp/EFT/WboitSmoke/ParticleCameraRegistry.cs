namespace EFT.WboitSmoke;

internal sealed class ParticleCameraRegistry : IDisposable
{
	private const CameraEvent INJECTION_EVENT = 16; //Field offset: 0x0
	private readonly ParticleCameraContext _fpsContext; //Field offset: 0x10
	private readonly ParticleCameraContext _opticContext; //Field offset: 0x18
	private bool _opticEventsSubscribed; //Field offset: 0x20
	private bool _isDisposed; //Field offset: 0x21

	public ParticleCameraContext FpsContext
	{
		 get { } //Length: 5
	}

	public bool HasAnyCamera
	{
		 get { } //Length: 407
	}

	public ParticleCameraContext OpticContext
	{
		 get { } //Length: 5
	}

	public ParticleCameraRegistry(IndirectParticlesProfile profile) { }

	public void ClearCommands() { }

	public override void Dispose() { }

	public ParticleCameraContext get_FpsContext() { }

	public bool get_HasAnyCamera() { }

	public ParticleCameraContext get_OpticContext() { }

	private static Camera GetFpsCamera() { }

	private static Camera GetOpticCamera() { }

	public Camera GetReferenceCamera() { }

	public SSAA GetSsaa(ParticleCameraContext context) { }

	private void OnOpticDisabled() { }

	private void OnOpticEnabled() { }

	public void Refresh() { }

	public ParticleCameraContext Resolve(Camera camera) { }

	public void SetParticleCount(int particleCount) { }

	private void SubscribeOpticEvents() { }

	private void UnsubscribeOpticEvents() { }

	public void UploadParticleRange(List particles, int startIndex, int count) { }

}

