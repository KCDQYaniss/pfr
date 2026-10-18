namespace CommonAssets.Scripts.Audio;

public class GlobalAudioSettings
{
	internal sealed class RadioBroadcastSettings
	{
		internal class RadioStationSettings
		{
			public ERadioStation Station; //Field offset: 0x10
			public bool Enabled; //Field offset: 0x11

			public RadioStationSettings() { }

		}

		public bool EnabledBroadcast; //Field offset: 0x10
		public List RadioStations; //Field offset: 0x18
		private Dictionary _radioStationEnabledState; //Field offset: 0x20

		public RadioBroadcastSettings() { }

		private void FillStationsState() { }

		public bool GetStationEnabledState(ERadioStation station) { }

	}

	[JsonProperty("RadioBroadcastSettings")]
	public RadioBroadcastSettings RadioSettings; //Field offset: 0x10

	public GlobalAudioSettings() { }

}

