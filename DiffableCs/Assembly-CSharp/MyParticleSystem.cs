//Type is in global namespace

public class MyParticleSystem : MonoBehaviour
{
	public string Name; //Field offset: 0x20
	public ParticleSystem System; //Field offset: 0x28
	private int _initialPoolSize; //Field offset: 0x30
	private Transform _parent; //Field offset: 0x38
	private int _maxPoolSize; //Field offset: 0x40
	private List _usedSystems; //Field offset: 0x48
	private Queue _freeSystems; //Field offset: 0x50
	private int _poolSize; //Field offset: 0x58

	public int InitialPoolSize
	{
		 get { } //Length: 4
		 set { } //Length: 13
	}

	public int MaxPoolSize
	{
		 get { } //Length: 4
		 set { } //Length: 11
	}

	public MyParticleSystem() { }

	public int get_InitialPoolSize() { }

	public int get_MaxPoolSize() { }

	public void Play(Vector3 pos, Vector3 rot) { }

	private void ReturnItem(ParticlePoolItem item) { }

	public void set_InitialPoolSize(int value) { }

	public void set_MaxPoolSize(int value) { }

	public void Start() { }

}

