namespace Dissonance.Threading;

internal class LockedValue`1
{
	internal class Unlocker : IDisposable
	{
		private readonly LockedValue _parent; //Field offset: 0x0

		[CanBeNull]
		public T Value
		{
			 get { } //Length: 27
			 set { } //Length: 27
		}

		public Unlocker(LockedValue parent) { }

		public override void Dispose() { }

		public T get_Value() { }

		public void set_Value(T value) { }

	}

	private T _value; //Field offset: 0x0
	private readonly object _lockObject; //Field offset: 0x0
	private readonly Unlocker _unlocker; //Field offset: 0x0

	public LockedValue`1(T value) { }

	public Unlocker Lock() { }

	private void Unlock() { }

}

