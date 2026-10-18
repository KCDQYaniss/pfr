namespace EFT.Weather;

[ExecuteAlways]
public class TodLightSetter : MonoBehaviour
{
	private static readonly int _forceIndoorId; //Field offset: 0x0
	private static readonly int _forceIndoorIntensityId; //Field offset: 0x4
	private static readonly int _sunVisibilityId; //Field offset: 0x8
	private static readonly int _clearSkyId; //Field offset: 0xC
	[SerializeField]
	private float _forceIndoorIntensity; //Field offset: 0x20
	[SerializeField]
	private AnimationCurve _sunVisibilityCurve; //Field offset: 0x28

	private static TodLightSetter() { }

	public TodLightSetter() { }

	private void LateUpdate() { }

}

