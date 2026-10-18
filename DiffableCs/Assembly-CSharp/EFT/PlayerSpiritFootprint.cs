namespace EFT;

public struct PlayerSpiritFootprint : IDisposable
{
	public ulong frameIndex; //Field offset: 0x0
	public AnimatorFootprint bodyAnimator; //Field offset: 0x8
	public AnimatorFootprint armsAnimator; //Field offset: 0x10
	public CharacterControllerFootprint characterController; //Field offset: 0x18
	public Vector3 position; //Field offset: 0x44
	public Quaternion rotation; //Field offset: 0x50
	public Vector3 animatedPosition; //Field offset: 0x60
	public Quaternion animatedRotation; //Field offset: 0x6C
	public Vector2 lookRotation; //Field offset: 0x7C
	public Vector2 previousLookRotation; //Field offset: 0x84

	public static PlayerSpiritFootprint Create(IAnimator bodyAnimator, IAnimator armsAnimator, ICharacterController characterController, Vector3 position, Quaternion rotation, Vector3 animatedPosition, Quaternion animatedRotation, Vector2 lookRotation, Vector2 previousLookRotation) { }

	public override void Dispose() { }

}

