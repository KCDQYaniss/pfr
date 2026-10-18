namespace Dissonance.Audio;

internal class AudioFileWriter : IDisposable
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly LockedValue _lock; //Field offset: 0x10
	private readonly bool _error; //Field offset: 0x18

	private static AudioFileWriter() { }

	public AudioFileWriter(string filename, WaveFormat format) { }

	public override void Dispose() { }

	public void Flush() { }

	public void WriteSamples(ArraySegment samples) { }

}

