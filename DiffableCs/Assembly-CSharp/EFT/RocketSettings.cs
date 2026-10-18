namespace EFT;

public class RocketSettings : ThrowableSettings, IRocketSettings
{
	[SerializeField]
	private GameObject _ammoObject; //Field offset: 0x30
	[SerializeField]
	private List _meshRenderers; //Field offset: 0x38
	[SerializeField]
	private float _weight; //Field offset: 0x40
	[SerializeField]
	private float _startVelocity; //Field offset: 0x44
	[SerializeField]
	private float _rigidbodyDrag; //Field offset: 0x48
	[SerializeField]
	private float _collisionDrag; //Field offset: 0x4C
	[SerializeField]
	private Collider _selfCollider; //Field offset: 0x50
	[SerializeField]
	private Rigidbody _rigidbody; //Field offset: 0x58
	[SerializeField]
	private Material _explosionParticleMaterial; //Field offset: 0x60
	[SerializeField]
	private Gradient _thermalGradient; //Field offset: 0x68
	[SerializeField]
	private Material _explosionDebugMaterial; //Field offset: 0x70
	[SerializeField]
	private GameObject _debugObject; //Field offset: 0x78
	[Header("Sound")]
	[SerializeField]
	[Space]
	private SoundBank _explosionSoundBank; //Field offset: 0x80

	public GameObject Ammo
	{
		 get { } //Length: 76
	}

	public GameObject DebugObject
	{
		 get { } //Length: 5
	}

	public override float Drag
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Material ExplosionDebugMaterial
	{
		 get { } //Length: 5
	}

	public override Material ExplosionParticleMaterial
	{
		 get { } //Length: 5
	}

	public SoundBank ExplosionSoundBank
	{
		 get { } //Length: 8
	}

	public override ICollection MeshRenderers
	{
		 get { } //Length: 5
	}

	public override Rigidbody Rigidbody
	{
		 get { } //Length: 5
	}

	public override Collider SelfCollider
	{
		 get { } //Length: 5
	}

	public override float StartSpeed
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Gradient ThermalGradient
	{
		 get { } //Length: 5
	}

	public override float Weight
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public RocketSettings() { }

	public GameObject get_Ammo() { }

	public GameObject get_DebugObject() { }

	public override float get_Drag() { }

	public Material get_ExplosionDebugMaterial() { }

	public override Material get_ExplosionParticleMaterial() { }

	public SoundBank get_ExplosionSoundBank() { }

	public override ICollection get_MeshRenderers() { }

	public override Rigidbody get_Rigidbody() { }

	public override Collider get_SelfCollider() { }

	public override float get_StartSpeed() { }

	public Gradient get_ThermalGradient() { }

	public override float get_Weight() { }

	public void set_Drag(float value) { }

	public void set_StartSpeed(float value) { }

	public void set_Weight(float value) { }

}

