namespace UnityEngine;

[NativeHeader("Modules/Streaming/StreamingController.h")]
[RequireComponent(typeof(Camera))]
public class StreamingController : Behaviour
{

	public float streamingMipmapBias
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public float get_streamingMipmapBias() { }

	public void set_streamingMipmapBias(float value) { }

}

