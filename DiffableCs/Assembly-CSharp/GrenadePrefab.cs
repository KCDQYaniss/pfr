//Type is in global namespace

[DisallowMultipleComponent]
public class GrenadePrefab : WeaponPrefab
{
	[Header("Element 0 defines grenade initial position!")]
	public string[] ThrowingParts; //Field offset: 0x228
	public GrenadeSettings GrenadeItself; //Field offset: 0x230
	public TripwireVisual TripwireItself; //Field offset: 0x238

	public GrenadePrefab() { }

	protected virtual void ReturnToPool() { }

}

