namespace UnityEngine;

public sealed class WaitUntil : CustomYieldInstruction
{
	private Func m_Predicate; //Field offset: 0x10

	public virtual bool keepWaiting
	{
		 get { } //Length: 42
	}

	public WaitUntil(Func predicate) { }

	public virtual bool get_keepWaiting() { }

}

