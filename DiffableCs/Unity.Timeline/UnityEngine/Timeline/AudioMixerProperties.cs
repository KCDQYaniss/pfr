namespace UnityEngine.Timeline;

internal class AudioMixerProperties : PlayableBehaviour
{
	[Range(0, 1)]
	public float volume; //Field offset: 0x10
	[Range(-1, 1)]
	public float stereoPan; //Field offset: 0x14
	[Range(0, 1)]
	public float spatialBlend; //Field offset: 0x18

	public AudioMixerProperties() { }

	public virtual void PrepareFrame(Playable playable, FrameData info) { }

}

