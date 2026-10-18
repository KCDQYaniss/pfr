namespace EFT.Achievements;

public sealed class AchievementNotificationManager : IConditionalNotificationManager
{
	[CompilerGenerated]
	private struct <DisplayNotificationAfterSpriteLoad>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Achievement achievement; //Field offset: 0x20
		public IImageLoader imageLoader; //Field offset: 0x28
		public AchievementNotificationManager <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly IImageLoader <ImageLoader>k__BackingField; //Field offset: 0x10

	public override IImageLoader ImageLoader
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AchievementNotificationManager(IImageLoader imageLoader) { }

	private void DisplayNotification(AchievementTemplate template) { }

	[AsyncStateMachine(typeof(<DisplayNotificationAfterSpriteLoad>d__8))]
	private Task DisplayNotificationAfterSpriteLoad(Achievement achievement, IImageLoader imageLoader) { }

	[CompilerGenerated]
	public override IImageLoader get_ImageLoader() { }

	public override void NotifyConditionalStatusChanged(Achievement achievement) { }

	public override void NotifyConditionChanged(Achievement quest) { }

	public override void NotifyReward(Achievement quest, EQuestStatus status) { }

}

