namespace Dissonance.Audio.Capture;

public interface IMicrophoneSubscriber
{

	public void ReceiveMicrophoneData(ArraySegment buffer, WaveFormat format) { }

	public void Reset() { }

}

