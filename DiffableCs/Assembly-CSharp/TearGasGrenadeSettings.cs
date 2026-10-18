//Type is in global namespace

public class TearGasGrenadeSettings : GrenadeSettings
{
	[SerializeField]
	public Vector3 _torque; //Field offset: 0x40
	[SerializeField]
	public float _torqueDelta; //Field offset: 0x4C

	public TearGasGrenadeSettings() { }

}

