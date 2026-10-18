//Type is in global namespace

public class ObservedPlayerFrame : PlayerFrame
{
	public AnimatorParam[] AnimatorParams; //Field offset: 0x48
	public int StateHash; //Field offset: 0x50

	public ObservedPlayerFrame() { }

	public virtual void ReadFromBuffer(byte[] buffer, ref int offset) { }

	public virtual int WriteToBuffer(byte[] buffer, int offset = 0) { }

}

