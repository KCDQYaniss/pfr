namespace EFT.Animations;

public class AimingZone
{
	private readonly float _aimingZoneRadius; //Field offset: 0x10
	private readonly float _aimingSensitivity; //Field offset: 0x14
	private Vector2 _rotation; //Field offset: 0x18
	private Vector2 _cachedAimingRotation; //Field offset: 0x20

	public AimingZone() { }

	public Vector3 GetAimingRotation() { }

	public Vector2 GetBodyRotation() { }

	public void Reset() { }

	public void Rotate(Vector2 deltaRotation) { }

}

