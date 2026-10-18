//Type is in global namespace

internal class AudioQueue
{
	private class Sample
	{
		public AudioClip Clip; //Field offset: 0x10
		public double Start; //Field offset: 0x18
		public double End; //Field offset: 0x20

		public Sample(AudioClip clip, double start, double end) { }

	}

	private AudioSource[] _sources; //Field offset: 0x10
	private int _lastSource; //Field offset: 0x18
	private LinkedList _samples; //Field offset: 0x20
	private double _nextCheckTime; //Field offset: 0x28

	public int Count
	{
		 get { } //Length: 65
	}

	public AudioQueue(AudioSource source0, AudioSource source1) { }

	public void AddClip(AudioClip clip, double start, double end = 0) { }

	public void AddClipFTime(AudioClip clip, float start, float end = 0) { }

	public int get_Count() { }

	public void Update() { }

}

