namespace EFT.Airdrop;

[Obfuscation(Exclude = True)]
public class AirdropSurfaceSet
{
	public ESurfaceSound Surface; //Field offset: 0x10
	public SoundBank LandingSoundBank; //Field offset: 0x18

	public bool IsFull
	{
		 get { } //Length: 203
	}

	public AirdropSurfaceSet() { }

	public bool get_IsFull() { }

}

