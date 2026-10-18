namespace MirzaBeig.Scripting.Effects;

public class TurbulenceParticleAffectorMT : MonoBehaviour
{
	public float force; //Field offset: 0x20
	public float speed; //Field offset: 0x24
	private ParticleSystem particleSystem; //Field offset: 0x28
	private Particle[] particles; //Field offset: 0x30
	private float randomX; //Field offset: 0x38
	private float randomY; //Field offset: 0x3C
	private float randomZ; //Field offset: 0x40
	private float offsetX; //Field offset: 0x44
	private float offsetY; //Field offset: 0x48
	private float offsetZ; //Field offset: 0x4C
	private float deltaTime; //Field offset: 0x50
	private Thread t; //Field offset: 0x58
	private readonly object locker; //Field offset: 0x60
	private bool processing; //Field offset: 0x68
	private bool isDoneAssigning; //Field offset: 0x69

	public TurbulenceParticleAffectorMT() { }

	private void Awake() { }

	private void LateUpdate() { }

	private void OnApplicationQuit() { }

	private void OnDisable() { }

	private void process() { }

	private void Start() { }

}

