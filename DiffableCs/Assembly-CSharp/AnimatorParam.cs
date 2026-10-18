//Type is in global namespace

public struct AnimatorParam
{
	public int hash; //Field offset: 0x0
	public AnimatorControllerParameterType type; //Field offset: 0x4
	public bool bool; //Field offset: 0x8
	public int int; //Field offset: 0xC
	public float float; //Field offset: 0x10

	public void Apply(IAnimator animator) { }

	public static AnimatorParam[] GetAnimatorParams(IAnimator animator) { }

	private void GetData(IAnimator animator, int paramIndex) { }

	public void ReadFromBuffer(byte[] buffer, ref int offset) { }

	public int WriteToBuffer(byte[] buffer, int offset = 0) { }

}

