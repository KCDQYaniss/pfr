namespace Dissonance.Audio.Playback;

public struct SessionContext : IEquatable
{
	public readonly string PlayerName; //Field offset: 0x0
	public readonly uint Id; //Field offset: 0x8

	public SessionContext(string playerName, uint id) { }

	public override bool Equals(SessionContext other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

