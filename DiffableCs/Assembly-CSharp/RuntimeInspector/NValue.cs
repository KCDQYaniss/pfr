namespace RuntimeInspector;

public class NValue : N
{
	private Func func; //Field offset: 0x50

	public NValue(MemberInfo info, object parent) { }

	public virtual void Info() { }

}

