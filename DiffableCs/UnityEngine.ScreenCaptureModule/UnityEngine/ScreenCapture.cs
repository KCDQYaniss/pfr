namespace UnityEngine;

[NativeHeader("Modules/ScreenCapture/Public/CaptureScreenshot.h")]
public static class ScreenCapture
{
	internal enum StereoScreenCaptureMode
	{
		LeftEye = 1,
		RightEye = 2,
		BothEyes = 3,
	}


	public static void CaptureScreenshot(string filename) { }

	public static void CaptureScreenshot(string filename, int superSize) { }

	private static void CaptureScreenshot(string filename, int superSize, StereoScreenCaptureMode CaptureMode) { }

}

