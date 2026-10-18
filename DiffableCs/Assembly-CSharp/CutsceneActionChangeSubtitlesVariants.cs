//Type is in global namespace

public class CutsceneActionChangeSubtitlesVariants : CutsceneBaseAction
{
	public List subtitlesVariants; //Field offset: 0x40

	public CutsceneActionChangeSubtitlesVariants() { }

	public virtual void Init() { }

	private void InitSubtitles(CutsceneSubtitlesVariant subtitlesVariant) { }

}

