namespace UnityEngine.Audio;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
public class AudioMixer : Object
{

	internal AudioMixer() { }

	[NativeMethod("AudioMixerBindings::FindMatchingGroups", IsFreeFunction = True, HasExplicitThis = True)]
	public AudioMixerGroup[] FindMatchingGroups(string subPath) { }

	[NativeMethod("FindSnapshotFromName")]
	public AudioMixerSnapshot FindSnapshot(string name) { }

	[NativeMethod]
	public bool GetFloat(string name, out float value) { }

	[NativeMethod]
	public bool SetFloat(string name, float value) { }

	internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethod("TransitionToSnapshot")]
	private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) { }

}

