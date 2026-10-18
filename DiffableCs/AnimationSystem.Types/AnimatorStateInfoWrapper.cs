//Type is in global namespace

[IsReadOnly]
public struct AnimatorStateInfoWrapper
{
	public readonly int fullPathHash; //Field offset: 0x0
	public readonly float normalizedTime; //Field offset: 0x4
	public readonly bool loop; //Field offset: 0x8
	public readonly int shortNameHash; //Field offset: 0xC
	public readonly int nameHash; //Field offset: 0x10
	public readonly float length; //Field offset: 0x14
	public readonly float speed; //Field offset: 0x18

	public AnimatorStateInfoWrapper(int fullPathHash, float normalizedTime, bool loop, int shortNameHash, int nameHash, float length, float speed) { }

	public bool IsName(string name) { }

}

