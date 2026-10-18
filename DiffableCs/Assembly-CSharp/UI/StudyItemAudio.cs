namespace UI;

public class StudyItemAudio : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public InventoryController inventoryController; //Field offset: 0x10
		public StudyItemAudio <>4__this; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <Init>b__0() { }

	}

	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0x70
	[SerializeField]
	private SoundBank _soundBank; //Field offset: 0x78
	private EStudyState _currentState; //Field offset: 0x80
	private Item _currentItem; //Field offset: 0x88

	public StudyItemAudio() { }

	public AudioClip FindClip(string clipName) { }

	public void Init(InventoryController inventoryController) { }

	private void StudyItemProgressChangeHandler(Item item, float progress, EStudyState state) { }

}

