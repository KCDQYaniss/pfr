namespace uLipSync.Debugging;

[RequireComponent(typeof(uLipSync))]
public class DebugDump : MonoBehaviour
{
	[CompilerGenerated]
	private uLipSync <lipsync>k__BackingField; //Field offset: 0x20
	public string prefix; //Field offset: 0x28
	public string dataFile; //Field offset: 0x30
	public string spectrumFile; //Field offset: 0x38
	public string melSpectrumFile; //Field offset: 0x40
	public string melCepstrumFile; //Field offset: 0x48
	public string mfccFile; //Field offset: 0x50

	public private uLipSync lipsync
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public DebugDump() { }

	public void DumpAll() { }

	public void DumpData() { }

	public void DumpMelCepstrum() { }

	public void DumpMelSpectrum() { }

	public void DumpMfcc() { }

	public void DumpSpectrum() { }

	[CompilerGenerated]
	public uLipSync get_lipsync() { }

	[CompilerGenerated]
	private void set_lipsync(uLipSync value) { }

	private void Start() { }

}

