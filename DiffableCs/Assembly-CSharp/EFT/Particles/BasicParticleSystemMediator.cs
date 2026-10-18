namespace EFT.Particles;

public class BasicParticleSystemMediator : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem[] _particleSystems; //Field offset: 0x20
	private int _index; //Field offset: 0x28

	public BasicParticleSystemMediator() { }

	public void Emit(Vector3 position, Quaternion rotation) { }

}

