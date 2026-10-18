namespace Audio.AudioCulling;

public interface IAudioCullingController : IDisposable
{

	public void Register(IAudioCullingObject cullingObject) { }

	public void Unregister(IAudioCullingObject cullingObject) { }

}

