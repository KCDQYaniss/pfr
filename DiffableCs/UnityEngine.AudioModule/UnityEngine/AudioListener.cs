namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioListenerBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioListener : AudioBehaviour
{

	[NativeProperty("ListenerPause")]
	public static bool pause
	{
		 set { } //Length: 78
	}

	public static void GetOutputData(float[] samples, int channel) { }

	[NativeThrows]
	private static void GetOutputDataHelper(out float[] samples, int channel) { }

	public static void set_pause(bool value) { }

}

