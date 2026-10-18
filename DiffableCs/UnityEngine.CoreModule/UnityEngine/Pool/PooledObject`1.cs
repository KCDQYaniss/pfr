namespace UnityEngine.Pool;

public struct PooledObject`1 : IDisposable
{
	private readonly T m_ToReturn; //Field offset: 0x0
	private readonly IObjectPool m_Pool; //Field offset: 0x0

	public PooledObject`1(T value, IObjectPool pool) { }

	private override void System.IDisposable.Dispose() { }

}

