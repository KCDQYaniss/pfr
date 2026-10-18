namespace Audio.SpatialSystem;

public class AudioBakeDataWriter
{

	public AudioBakeDataWriter() { }

	public void Write(SerializableAudioRoutesBakeData data, string pathToSave) { }

	private static void WriteAudioRouteDataArray(BinaryWriter writer, AudioRouteData[] audioRoutes) { }

	private void WriteRelevantRoomPairs(SerializableAudioRoutesBakeData data, BinaryWriter writer) { }

	private static void WriteRelevantRoomPairsIds(BinaryWriter writer, uint[] array) { }

	private void WriteRoomPairRoutes(SerializableAudioRoutesBakeData data, BinaryWriter writer) { }

	private void WriteRoomPairs(SerializableAudioRoutesBakeData data, BinaryWriter writer) { }

}

