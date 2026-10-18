namespace EFT.Character.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/FirstPersonPlayerHearingSettings", fileName = "FirstPersonPlayerHearingSettings")]
public class FirstPersonPlayerHearingSettings : ScriptableObject
{
	[SerializeField]
	private AnimationCurve _volumeCurve; //Field offset: 0x18
	[SerializeField]
	private AnimationCurve _lowpassFilterCurve; //Field offset: 0x20
	[SerializeField]
	private AnimationCurve _reverbCurve; //Field offset: 0x28

	public FirstPersonPlayerHearingSettings() { }

	private float Calculate(AnimationCurve curve, float value) { }

	public float GetLowpassFreq(float value) { }

	public float GetReverbLevel(float value) { }

	public float GetVolumeDB(float value) { }

}

