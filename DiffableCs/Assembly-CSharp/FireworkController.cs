//Type is in global namespace

public class FireworkController : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem _particleSystem; //Field offset: 0x20
	[SerializeField]
	private ParticleSystem _customSubEmitter; //Field offset: 0x28

	public FireworkController() { }

	private void Update() { }

}

