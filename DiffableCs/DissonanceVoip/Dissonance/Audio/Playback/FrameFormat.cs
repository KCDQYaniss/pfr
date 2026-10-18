namespace Dissonance.Audio.Playback;

internal struct FrameFormat : IEquatable
{
	public readonly Codec Codec; //Field offset: 0x0
	public readonly WaveFormat WaveFormat; //Field offset: 0x8
	public readonly uint FrameSize; //Field offset: 0x10

	public FrameFormat(Codec codec, WaveFormat waveFormat, uint frameSize) { }

	public override bool Equals(FrameFormat other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

