//Type is in global namespace

public class SonicBulletSoundPlayer : BulletSoundPlayer
{
	internal class SonicAudio
	{
		public SonicType Type; //Field offset: 0x10
		public AudioClip Clip; //Field offset: 0x18

		public SonicAudio() { }

	}

	internal class SonicInfo
	{
		public Ammo Ammo; //Field offset: 0x10
		public Vector3 ShotPosition; //Field offset: 0x18
		public Vector3 ShotDirection; //Field offset: 0x24
		public Camera Camera; //Field offset: 0x30
		public float Rolloff; //Field offset: 0x38
		public bool IsOccluded; //Field offset: 0x3C

		public SonicInfo(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, Camera camera, float rolloff, bool isOccluded) { }

	}

	private class SonicTimeQueueItem : ITimeQueueItem
	{
		private const string LIMITER_KEY = "SonicCracle"; //Field offset: 0x0
		private const float LIMIT_TIME = 0.3; //Field offset: 0x0
		private readonly Vector2 _limitRadius; //Field offset: 0x10
		private PoolWithoutAlloc _pool; //Field offset: 0x18
		private Vector3 _start; //Field offset: 0x20
		private AudioClip _clip; //Field offset: 0x30
		private float _distance; //Field offset: 0x38
		private int _rollOff; //Field offset: 0x3C
		private float _volume; //Field offset: 0x40

		public SonicTimeQueueItem() { }

		public void Initialize(PoolWithoutAlloc pool, Vector3 start, AudioClip clip, float distance, int rollOff, float volume) { }

		public override void Release() { }

	}

	internal enum SonicType
	{
		Sonic9 = 0,
		Sonic545 = 1,
		Sonic762 = 2,
		SonicShotgun = 3,
	}

	[SerializeField]
	private List _sources; //Field offset: 0x20
	[SerializeField]
	private AnimationCurve _soundCurve; //Field offset: 0x28
	[SerializeField]
	private float _minDistance; //Field offset: 0x30
	private readonly PoolWithoutAlloc _sonicQueueItemsPool; //Field offset: 0x38
	private readonly Dictionary _sonicAudioClipMap; //Field offset: 0x40

	public SonicBulletSoundPlayer() { }

	private void Awake() { }

	private int CalculateRollOff(SonicInfo sonicInfo, float distance) { }

	private void FillSonicAudioMap() { }

	public void FireBullet(SonicInfo sonicInfo) { }

	private void OnDestroy() { }

}

