namespace EFT.PrefabSettings;

public sealed class FlareCartridgeSettings : ThrowableSettings
{
	[SerializeField]
	private GameObject _projectileAmmo; //Field offset: 0x30
	[SerializeField]
	private List _meshRenderers; //Field offset: 0x38
	[SerializeField]
	private float _succesfullHeight; //Field offset: 0x40
	[SerializeField]
	private FlareColorType _flareColorType; //Field offset: 0x44
	[SerializeField]
	private string _airDropTemplateId; //Field offset: 0x48
	[SerializeField]
	private float _initialSpeed; //Field offset: 0x50
	[SerializeField]
	private float _flareTimeAfterStart; //Field offset: 0x54
	[SerializeField]
	private float _flareLifetime; //Field offset: 0x58
	[SerializeField]
	private float _weight; //Field offset: 0x5C
	[SerializeField]
	private float _rigidbodyDrag; //Field offset: 0x60
	[SerializeField]
	private float _collisionDrag; //Field offset: 0x64
	[SerializeField]
	private GameObject _flareEffectPrefab; //Field offset: 0x68

	public string AirDropTemplateId
	{
		 get { } //Length: 18
	}

	public float CollisionDrag
	{
		 get { } //Length: 6
	}

	public FlareColorType FlareColorType
	{
		 get { } //Length: 4
	}

	public GameObject FlareEffectPrefab
	{
		 get { } //Length: 5
	}

	public float FlareLifetime
	{
		 get { } //Length: 6
	}

	public float FlareTimeAfterStart
	{
		 get { } //Length: 6
	}

	public float InitialSpeed
	{
		 get { } //Length: 6
	}

	public GameObject ProjectileAmmo
	{
		 get { } //Length: 76
	}

	public float RigidbodyDrag
	{
		 get { } //Length: 6
	}

	public float SuccesfullHeight
	{
		 get { } //Length: 6
	}

	public float Weight
	{
		 get { } //Length: 6
	}

	public FlareCartridgeSettings() { }

	public string get_AirDropTemplateId() { }

	public float get_CollisionDrag() { }

	public FlareColorType get_FlareColorType() { }

	public GameObject get_FlareEffectPrefab() { }

	public float get_FlareLifetime() { }

	public float get_FlareTimeAfterStart() { }

	public float get_InitialSpeed() { }

	public GameObject get_ProjectileAmmo() { }

	public float get_RigidbodyDrag() { }

	public float get_SuccesfullHeight() { }

	public float get_Weight() { }

	public void SwitchMeshRenderersActive(bool value) { }

}

