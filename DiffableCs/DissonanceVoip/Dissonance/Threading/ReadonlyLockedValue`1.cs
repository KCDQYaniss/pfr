namespace Dissonance.Threading;

internal class ReadonlyLockedValue`1
{
	internal class Unlocker : IDisposable
	{
		private readonly ReadonlyLockedValue _parent; //Field offset: 0x0

		public T Value
		{
			 get { } //Length: 26
		}

		public Unlocker(ReadonlyLockedValue parent) { }

		public override void Dispose() { }

		public T get_Value() { }

	}

	private readonly T _value; //Field offset: 0x0
	private readonly object _lockObject; //Field offset: 0x0
	private readonly Unlocker _unlocker; //Field offset: 0x0

	public ReadonlyLockedValue`1(T value) { }

	public Unlocker Lock() { }

	private void Unlock() { }

}

