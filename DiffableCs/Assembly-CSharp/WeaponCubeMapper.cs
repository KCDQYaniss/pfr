//Type is in global namespace

public class WeaponCubeMapper : CubeMapper
{
	private static readonly int _weaponDirection; //Field offset: 0x0
	private static readonly int _weaponDelta; //Field offset: 0x4
	private float _prevDot; //Field offset: 0x30

	private static WeaponCubeMapper() { }

	public WeaponCubeMapper() { }

	protected virtual void Update() { }

}

