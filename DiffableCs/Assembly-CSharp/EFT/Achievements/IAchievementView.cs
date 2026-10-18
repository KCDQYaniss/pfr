namespace EFT.Achievements;

public interface IAchievementView : IUIView, IDisposable
{

	public Achievement Achievement
	{
		 get { } //Length: 0
	}

	public Achievement get_Achievement() { }

	public void Show(Achievement model, AchievementsController achievementsController, NotesTaskDescriptionShort description, IClientSession session) { }

}

