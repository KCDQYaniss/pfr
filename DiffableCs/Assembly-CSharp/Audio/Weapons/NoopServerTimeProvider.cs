namespace Audio.Weapons;

internal sealed class NoopServerTimeProvider : IServerTimeProvider
{

	public NoopServerTimeProvider() { }

	public override double GetCurrentServerTime() { }

	public override void Reset() { }

}

