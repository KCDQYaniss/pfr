namespace UnityEngine;

[NativeHeader("Runtime/Input/TimeManager.h")]
[StaticAccessor("GetTimeManager()", StaticAccessorType::Dot (0))]
public class Time
{

	public static float deltaTime
	{
		 get { } //Length: 69
	}

	public static float fixedDeltaTime
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	public static float fixedTime
	{
		 get { } //Length: 69
	}

	public static float fixedUnscaledDeltaTime
	{
		 get { } //Length: 69
	}

	public static int frameCount
	{
		 get { } //Length: 69
	}

	public static float maximumDeltaTime
	{
		 get { } //Length: 69
	}

	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup
	{
		 get { } //Length: 69
	}

	[NativeProperty("Realtime")]
	public static double realtimeSinceStartupAsDouble
	{
		 get { } //Length: 69
	}

	[NativeProperty("RenderFrameCount")]
	public static int renderedFrameCount
	{
		 get { } //Length: 69
	}

	public static float smoothDeltaTime
	{
		 get { } //Length: 69
	}

	[NativeProperty("CurTime")]
	public static float time
	{
		 get { } //Length: 69
	}

	public static float timeScale
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	[NativeProperty("TimeSinceSceneLoad")]
	public static float timeSinceLevelLoad
	{
		 get { } //Length: 69
	}

	public static float unscaledDeltaTime
	{
		 get { } //Length: 69
	}

	public static float unscaledTime
	{
		 get { } //Length: 69
	}

	public static float get_deltaTime() { }

	public static float get_fixedDeltaTime() { }

	public static float get_fixedTime() { }

	public static float get_fixedUnscaledDeltaTime() { }

	public static int get_frameCount() { }

	public static float get_maximumDeltaTime() { }

	public static float get_realtimeSinceStartup() { }

	public static double get_realtimeSinceStartupAsDouble() { }

	public static int get_renderedFrameCount() { }

	public static float get_smoothDeltaTime() { }

	public static float get_time() { }

	public static float get_timeScale() { }

	public static float get_timeSinceLevelLoad() { }

	public static float get_unscaledDeltaTime() { }

	public static float get_unscaledTime() { }

	public static void set_fixedDeltaTime(float value) { }

	public static void set_timeScale(float value) { }

}

