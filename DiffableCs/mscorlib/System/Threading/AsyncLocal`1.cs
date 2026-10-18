namespace System.Threading;

public sealed class AsyncLocal`1 : IAsyncLocal
{
	private readonly Action m_valueChangedHandler; //Field offset: 0x0

	public T Value
	{
		 get { } //Length: 170
		 set { } //Length: 115
	}

	public AsyncLocal`1() { }

	public T get_Value() { }

	public void set_Value(T value) { }

	private override void System.Threading.IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged) { }

}

