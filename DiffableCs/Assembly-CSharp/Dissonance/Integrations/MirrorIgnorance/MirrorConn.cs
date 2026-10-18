namespace Dissonance.Integrations.MirrorIgnorance;

[IsReadOnly]
public struct MirrorConn : IEquatable
{
	public readonly NetworkConnection Connection; //Field offset: 0x0

	public MirrorConn(NetworkConnection connection) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(MirrorConn other) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

