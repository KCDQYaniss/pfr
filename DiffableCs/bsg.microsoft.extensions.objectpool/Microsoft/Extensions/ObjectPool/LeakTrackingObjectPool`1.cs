namespace Microsoft.Extensions.ObjectPool;

public class LeakTrackingObjectPool`1 : ObjectPool
{
	private class Tracker : IDisposable
	{
		private readonly string _stack; //Field offset: 0x0
		private bool _disposed; //Field offset: 0x0

		public Tracker() { }

		public override void Dispose() { }

		protected virtual void Finalize() { }

	}

	private readonly ConditionalWeakTable _trackers; //Field offset: 0x0
	private readonly ObjectPool _inner; //Field offset: 0x0

	public LeakTrackingObjectPool`1(ObjectPool inner) { }

	public virtual T Get() { }

	public virtual void Return(T obj) { }

}

