namespace EFT.Interactive.Passcodes;

public class InteractableNoteHint : InteractableObject, IHintObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ApplyHint>b__6_0(TutorialHintLine x) { }

	}

	[SerializeField]
	private TutorialHintData _hintData; //Field offset: 0x48
	[SerializeField]
	private string _localizationInteractionText; //Field offset: 0x50

	public TutorialHintData HintData
	{
		 get { } //Length: 5
	}

	public string LocalizationInteractionText
	{
		 get { } //Length: 5
	}

	public InteractableNoteHint() { }

	public override void ApplyHint(string formattedHintData) { }

	public TutorialHintData get_HintData() { }

	public string get_LocalizationInteractionText() { }

}

