//Type is in global namespace

public class MineDirectional : MonoBehaviour, IPhysicsTrigger
{
	internal class MineDirectionSerializer
	{
		private ArrayPool _serializationPool; //Field offset: 0x10

		public MineDirectionSerializer() { }

		public static Vector3 Deserialize(byte[] data) { }

		public byte[] Serialize(MineDirectional mineDirectional) { }

	}

	internal struct MineSettings : IExplosiveItem
	{
		[SerializeField]
		private Vector3 _blindness; //Field offset: 0x0
		[SerializeField]
		private Vector3 _contusion; //Field offset: 0xC
		[SerializeField]
		private Vector3 _armorDistanceDistanceDamage; //Field offset: 0x18
		[SerializeField]
		private float _minExplosionDistance; //Field offset: 0x24
		[SerializeField]
		private float _maxExplosionDistance; //Field offset: 0x28
		[SerializeField]
		private int _fragmentsCount; //Field offset: 0x2C
		[SerializeField]
		private float _strength; //Field offset: 0x30
		[SerializeField]
		private string _tag; //Field offset: 0x38
		[SerializeField]
		private float _armorDamage; //Field offset: 0x40
		[SerializeField]
		private float _staminaBurnRate; //Field offset: 0x44
		[SerializeField]
		private float _penetrationPower; //Field offset: 0x48
		[SerializeField]
		private string _fragmentType; //Field offset: 0x50
		[SerializeField]
		private string _fxName; //Field offset: 0x58
		[SerializeField]
		private WildSpawnType _ignoreRole; //Field offset: 0x60
		[SerializeField]
		private float _directionalDamageAngle; //Field offset: 0x64
		[SerializeField]
		private float _directionalDamageMultiplier; //Field offset: 0x68
		[CompilerGenerated]
		private readonly bool <IsDummy>k__BackingField; //Field offset: 0x6C

		public float ArmorDamage
		{
			 get { } //Length: 6
		}

		public override Vector3 ArmorDistanceDistanceDamage
		{
			 get { } //Length: 19
		}

		public override Vector3 Blindness
		{
			 get { } //Length: 18
		}

		public override Vector3 Contusion
		{
			 get { } //Length: 19
		}

		public override int FragmentsCount
		{
			 get { } //Length: 4
		}

		public string FragmentType
		{
			 get { } //Length: 5
		}

		public string FXName
		{
			 get { } //Length: 5
		}

		public float GetDirectionalDamageAngle
		{
			 get { } //Length: 6
		}

		public float GetDirectionalDamageMultiplier
		{
			 get { } //Length: 6
		}

		public override float GetStrength
		{
			 get { } //Length: 6
		}

		public WildSpawnType IgnoreRole
		{
			 get { } //Length: 4
		}

		public override bool IsDummy
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
		}

		public override float MaxExplosionDistance
		{
			 get { } //Length: 6
		}

		public override float MinExplosionDistance
		{
			 get { } //Length: 6
		}

		public float PenetrationPower
		{
			 get { } //Length: 6
		}

		public float StaminaBurnRate
		{
			 get { } //Length: 6
		}

		public string Tag
		{
			 get { } //Length: 5
		}

		public override Ammo CreateFragment() { }

		public float get_ArmorDamage() { }

		public override Vector3 get_ArmorDistanceDistanceDamage() { }

		public override Vector3 get_Blindness() { }

		public override Vector3 get_Contusion() { }

		public override int get_FragmentsCount() { }

		public string get_FragmentType() { }

		public string get_FXName() { }

		public float get_GetDirectionalDamageAngle() { }

		public float get_GetDirectionalDamageMultiplier() { }

		public override float get_GetStrength() { }

		public WildSpawnType get_IgnoreRole() { }

		[CompilerGenerated]
		[IsReadOnly]
		public override bool get_IsDummy() { }

		public override float get_MaxExplosionDistance() { }

		public override float get_MinExplosionDistance() { }

		public float get_PenetrationPower() { }

		public float get_StaminaBurnRate() { }

		public string get_Tag() { }

	}

	private static int GlobalFragmentNumber; //Field offset: 0x0
	public static List Mines; //Field offset: 0x8
	[SerializeField]
	private MineSettings _mineData; //Field offset: 0x20
	private bool _cleared; //Field offset: 0x90
	private bool _exploded; //Field offset: 0x91

	private static IBallisticsCalculator Calculator
	{
		private get { } //Length: 93
	}

	public override string Description
	{
		 get { } //Length: 49
	}

	public string Tag
	{
		 get { } //Length: 5
	}

	private static MineDirectional() { }

	public MineDirectional() { }

	private void Awake() { }

	public void Explosion() { }

	private void Explosion(MineSettings mineData, Vector3 explosionPosition, IBallisticsCalculator ballisticsCalculator) { }

	private static IBallisticsCalculator get_Calculator() { }

	public override string get_Description() { }

	public string get_Tag() { }

	private DamageInfo GetDamageInfo() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public override void OnTriggerEnter(Collider other) { }

	public override void OnTriggerExit(Collider collider) { }

	public void SetArmed(bool isArmed) { }

	private bool ShouldIgnore(Collider other) { }

	private bool ShouldIgnorePlayer(Player player) { }

}

