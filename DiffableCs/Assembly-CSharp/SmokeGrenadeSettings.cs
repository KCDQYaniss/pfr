//Type is in global namespace

public class SmokeGrenadeSettings : GrenadeSettings
{
	[SerializeField]
	public SphereCollider _emissionArea; //Field offset: 0x40
	[SerializeField]
	public AnimationCurve _sizeOverTime; //Field offset: 0x48
	[SerializeField]
	public float _initialRadius; //Field offset: 0x50
	[SerializeField]
	public float _radiusMultiplier; //Field offset: 0x54
	[SerializeField]
	public Vector3 _pivot; //Field offset: 0x58
	[SerializeField]
	public Vector3 _torque; //Field offset: 0x64
	[SerializeField]
	public float _torqueDelta; //Field offset: 0x70
	[SerializeField]
	public float _areaStartPosNorm; //Field offset: 0x74

	public SmokeGrenadeSettings() { }

	private void OnValidate() { }

}

