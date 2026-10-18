namespace EFT;

public struct CharacterControllerFootprint
{
	public bool isEnabled; //Field offset: 0x0
	public Vector3 center; //Field offset: 0x4
	public bool detectCollisions; //Field offset: 0x10
	public float height; //Field offset: 0x14
	public float skinWidth; //Field offset: 0x18
	public float radius; //Field offset: 0x1C
	public float slopeLimit; //Field offset: 0x20
	public float stepOffset; //Field offset: 0x24
	public float contactOffset; //Field offset: 0x28

	public static CharacterControllerFootprint Create(ICharacterController characterController) { }

}

