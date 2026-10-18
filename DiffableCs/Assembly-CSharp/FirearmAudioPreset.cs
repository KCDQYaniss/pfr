//Type is in global namespace

[CreateAssetMenu(fileName = "FirearmAudioPreset", menuName = "Audio/Firefight/FirearmAudioPreset", order = 0)]
public class FirearmAudioPreset : ScriptableObject
{
	internal class LoopTailSet
	{
		private const int LOOP_BEATS_COUNT = 16; //Field offset: 0x0
		private const float MIN_LOOP_DURATION = 0.01; //Field offset: 0x0
		public SoundBank Loop; //Field offset: 0x10
		public SoundBank Tail; //Field offset: 0x18
		public float RPM; //Field offset: 0x20

		public LoopTailSet() { }

		public float ComputeBeatDurationSec(float baseLoopDurationSec) { }

	}

	public SoundBank[] SingleShots; //Field offset: 0x18
	public LoopTailSet[] LoopTailSets; //Field offset: 0x20
	public SoundBank[] GrenadeBanks; //Field offset: 0x28

	public bool HasGrenades
	{
		 get { } //Length: 30
	}

	public bool HasLoopTail
	{
		 get { } //Length: 30
	}

	public bool HasSingleShots
	{
		 get { } //Length: 30
	}

	public FirearmAudioPreset() { }

	public bool get_HasGrenades() { }

	public bool get_HasLoopTail() { }

	public bool get_HasSingleShots() { }

	public void LoadBanks() { }

	public bool TryGetLoopTailSet(out LoopTailSet set) { }

	public bool TryGetRandomGrenade(out SoundBank bank) { }

	public bool TryGetRandomSingle(out SoundBank bank) { }

	public void UnloadBanks() { }

}

