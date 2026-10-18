namespace UnityEngine.ProBuilder;

internal sealed class ObjectPool`1 : IDisposable
{
	private bool m_IsDisposed; //Field offset: 0x0
	private Queue m_Pool; //Field offset: 0x0
	public int desiredSize; //Field offset: 0x0
	public Func constructor; //Field offset: 0x0
	public Action destructor; //Field offset: 0x0

	public ObjectPool`1(int initialSize, int desiredSize, Func constructor, Action destructor, bool lazyInitialization = false) { }

	public T Dequeue() { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	public void Empty() { }

	public void Enqueue(T obj) { }

}

