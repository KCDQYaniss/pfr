namespace EFT;

public struct AnimatorStateFootprint
{
	public int shortNameHash; //Field offset: 0x0
	public int fullNameHash; //Field offset: 0x4
	public float normalizedTime; //Field offset: 0x8

	public static AnimatorStateFootprint Create(in AnimatorStateInfoWrapper stateInfo) { }

}

