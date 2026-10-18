//Type is in global namespace

public class MuzzleParticleContainer : MonoBehaviour
{
	internal struct MuzzleParticlePlayerData
	{
		public ParticleSystem System; //Field offset: 0x0
		public ParticleSystemRenderer Renderer; //Field offset: 0x8
		public Material Material; //Field offset: 0x10

	}

	private ParticleSystem _rootParticleSystem; //Field offset: 0x20
	private MuzzleParticlePlayerData[] _muzzleParticlePlayerData; //Field offset: 0x28
	[SerializeField]
	private EMuzzleParticlePivot _pivot; //Field offset: 0x30

	public MuzzleParticlePlayerData[] MuzzleParticleData
	{
		 get { } //Length: 5
	}

	public EMuzzleParticlePivot Pivot
	{
		 get { } //Length: 4
	}

	public ParticleSystem RootParticleSystem
	{
		 get { } //Length: 5
	}

	public MuzzleParticleContainer() { }

	private void Awake() { }

	public MuzzleParticlePlayerData[] get_MuzzleParticleData() { }

	public EMuzzleParticlePivot get_Pivot() { }

	public ParticleSystem get_RootParticleSystem() { }

}

