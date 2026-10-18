//Type is in global namespace

public class VolumetricExplosion
{
	private static readonly int BufferId; //Field offset: 0x0
	private static readonly int BufferLengthId; //Field offset: 0x4
	private readonly GraphicsBuffer _buffer; //Field offset: 0x10
	private readonly ParticleSystem _system; //Field offset: 0x18
	private readonly ParticleSystemRenderer _renderer; //Field offset: 0x20
	private readonly int _maxParticles; //Field offset: 0x28

	private static VolumetricExplosion() { }

	public VolumetricExplosion(ParticleSystem system) { }

	public void Dispose() { }

	public void Play(List points) { }

}

