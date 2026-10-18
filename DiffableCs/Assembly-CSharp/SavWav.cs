//Type is in global namespace

public static class SavWav
{
	private const int HEADER_SIZE = 44; //Field offset: 0x0

	private static void ConvertAndWrite(FileStream fileStream, AudioClip clip) { }

	private static FileStream CreateEmpty(string filepath) { }

	public static bool Save(string filename, AudioClip clip) { }

	public static AudioClip TrimSilence(AudioClip clip, float min) { }

	public static AudioClip TrimSilence(List samples, float min, int channels, int hz) { }

	public static AudioClip TrimSilence(List samples, float min, int channels, int hz, bool _3D, bool stream) { }

	private static void WriteHeader(FileStream fileStream, AudioClip clip) { }

}

