//Type is in global namespace

internal class AnimationQueue
{
	private class Sample
	{
		public string Name; //Field offset: 0x10
		public float Time; //Field offset: 0x18

		public Sample(string name, float time) { }

	}

	private Animation _animation; //Field offset: 0x10
	private LinkedList _samples; //Field offset: 0x18
	private Sample _currentSample; //Field offset: 0x20
	private AnimationState _currentState; //Field offset: 0x28
	private float _endTime; //Field offset: 0x30
	public float FadeLength; //Field offset: 0x34

	public float Delta
	{
		 get { } //Length: 121
	}

	public bool WillChange
	{
		 get { } //Length: 122
	}

	public AnimationQueue(Animation animation) { }

	public void Add(string name, float time = -1) { }

	public float get_Delta() { }

	public bool get_WillChange() { }

	public void Reset() { }

	public void Update() { }

	private void UpdateOld() { }

}

