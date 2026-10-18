namespace EFT.Hideout;

public class QTEResult
{
	public bool Succeed; //Field offset: 0x10
	public int ActionsPassed; //Field offset: 0x14
	public int ActionsFailed; //Field offset: 0x18
	public List SequenceResults; //Field offset: 0x20

	public QTEResult() { }

}

