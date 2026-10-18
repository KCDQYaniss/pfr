namespace UnityEngine.Video;

[NativeHeader("Modules/Video/Public/VideoClip.h")]
[RequiredByNativeCode]
public sealed class VideoClip : Object
{

	[NativeName("Duration")]
	public double length
	{
		 get { } //Length: 78
	}

	private VideoClip() { }

	public double get_length() { }

}

