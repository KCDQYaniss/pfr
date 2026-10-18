namespace EFT.UI;

public class PrestigeAnimationData
{
	public int Level; //Field offset: 0x10
	public VideoClip VideoClip; //Field offset: 0x18
	[Tooltip("Relative path in StreamingAssets (e.g. Folder_name/Video_name.webm). Used when VideoClip is null.")]
	public string VideoPath; //Field offset: 0x20
	public AudioClip AudioClip; //Field offset: 0x28

	public PrestigeAnimationData() { }

}

