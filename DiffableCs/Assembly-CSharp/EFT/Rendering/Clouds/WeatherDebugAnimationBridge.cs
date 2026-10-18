namespace EFT.Rendering.Clouds;

[ExecuteAlways]
[RequireComponent(typeof(WeatherController))]
public class WeatherDebugAnimationBridge : AnimationBridge
{
	private WeatherController _controller; //Field offset: 0x38

	public WeatherDebugAnimationBridge() { }

	private void Awake() { }

	protected virtual void LateUpdate() { }

}

