namespace CommonAssets.Scripts.ArtilleryShelling.Client.Audio;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/ArtilleryShellingSounds", fileName = "ArtilleryShellingSounds")]
public class ArtilleryShellingSoundsSO : ScriptableObject
{
	[Header("Shell Whistle")]
	public AudioMultipleClipContainer shellWhistleLoop; //Field offset: 0x18
	public Vector2 whistleVolumeRange; //Field offset: 0x20
	public Vector2 whistlePitchRange; //Field offset: 0x28
	[Range(0, 1)]
	public float shellWhistleDopplerLevel; //Field offset: 0x30
	public AnimationCurve whistleRolloffCurve; //Field offset: 0x38
	[Header("MortarShot")]
	[Space]
	public AudioMultipleClipContainer mortarShots; //Field offset: 0x40
	public Vector2 mortarShotPitchRange; //Field offset: 0x48

	public ArtilleryShellingSoundsSO() { }

}

