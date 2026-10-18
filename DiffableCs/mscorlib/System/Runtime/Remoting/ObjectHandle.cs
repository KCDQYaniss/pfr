namespace System.Runtime.Remoting;

[ClassInterface(ClassInterfaceType::AutoDual (2))]
[ComVisible(True)]
public class ObjectHandle : MarshalByRefObject
{
	private object _wrapped; //Field offset: 0x18

	public ObjectHandle(object o) { }

	public virtual object InitializeLifetimeService() { }

	public override object Unwrap() { }

}

