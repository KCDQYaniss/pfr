namespace EFT.VolumePropagation.Rendering;

[CreateAssetMenu(fileName = "VolumeRenderConfig", menuName = "EFT/VolumePropagation/VolumeRenderConfig")]
public class VolumeRenderConfig : ScriptableObject
{
	internal class Preset : IVolumeRenderSettings
	{
		public byte PresetId; //Field offset: 0x10
		public IndirectParticlesProfile Profile; //Field offset: 0x18

		private override IndirectParticlesProfile EFT.VolumePropagation.IVolumeRenderSettings.Profile
		{
			private get { } //Length: 5
		}

		public Preset() { }

		private override IndirectParticlesProfile EFT.VolumePropagation.IVolumeRenderSettings.get_Profile() { }

	}

	[FormerlySerializedAs("Presets")]
	[SerializeField]
	private List _presets; //Field offset: 0x18

	public VolumeRenderConfig() { }

	public Preset FindPreset(byte presetId) { }

	public static VolumeRenderConfig Load() { }

}

