namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableGraphExtensions.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[StaticAccessor("AudioPlayableGraphExtensionsBindings", StaticAccessorType::DoubleColon (2))]
internal static class AudioPlayableGraphExtensions
{

	[NativeThrows]
	internal static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle) { }

}

