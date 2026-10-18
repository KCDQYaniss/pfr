namespace EFT.Settings.Game;

public sealed class GameSettingsGroup : SettingsGroup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__41_0; //Field offset: 0x8
		public static Func <>9__41_1; //Field offset: 0x10
		public static Func <>9__41_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__41_0(int x) { }

		internal float <.ctor>b__41_1(float x) { }

		internal int <.ctor>b__41_2(int x) { }

	}

	internal enum EAutoAddToWishlist
	{
		Disabled = 0,
		Recipes = 1,
		Zones = 2,
		AllHideout = 3,
	}

	internal enum EAutoVaultingUseMode
	{
		Automatic = 0,
		Hotkey = 1,
	}

	internal enum EContinuousHealMode
	{
		Disabled = 0,
		Enabled = 1,
	}

	internal enum EItemQuickUseMode
	{
		Disabled = 0,
		InRaidOnly = 1,
		InRaidAndInLobby = 2,
	}

	internal enum EPriorityWindowMode
	{
		Disabled = 0,
		Auto = 1,
		Manual = 2,
	}

	internal enum EQuestItemNotificationMode
	{
		Disabled = 0,
		Enabled = 1,
	}

	internal enum EQuestItemSearchMode
	{
		Enabled = 0,
		Disabled = 1,
	}

	internal enum ETacticalInputMode
	{
		Press = 0,
		Hold = 1,
	}

	internal enum EWishlistNotificationsType
	{
		Disabled = 0,
		RaidOnly = 1,
		MenuOnly = 2,
		All = 3,
	}

	public const int MIN_FIELD_OF_VIEW = 50; //Field offset: 0x0
	public const int MAX_FIELD_OF_VIEW = 75; //Field offset: 0x0
	public readonly GameSetting Language; //Field offset: 0x18
	public readonly GameSetting SelectedMemberCategory; //Field offset: 0x20
	public readonly GameSetting QuickSlotsVisibility; //Field offset: 0x28
	public readonly GameSetting StaminaVisibility; //Field offset: 0x30
	public readonly GameSetting HealthVisibility; //Field offset: 0x38
	public readonly GameSetting HealthColor; //Field offset: 0x40
	public readonly GameSetting NotificationTransportType; //Field offset: 0x48
	public readonly GameSetting ConnectionType; //Field offset: 0x50
	public readonly GameSetting HighlightScope; //Field offset: 0x58
	public readonly GameSetting FieldOfView; //Field offset: 0x60
	public readonly GameSetting HeadBobbing; //Field offset: 0x68
	public readonly GameSetting AutoEmptyWorkingSet; //Field offset: 0x70
	public readonly GameSetting SetAffinityToLogicalCores; //Field offset: 0x78
	public readonly GameSetting EnableHideoutPreload; //Field offset: 0x80
	public readonly GameSetting StreamerModeEnabled; //Field offset: 0x88
	public readonly GameSetting BlockGroupInvites; //Field offset: 0x90
	public readonly GameSetting ItemQuickUseMode; //Field offset: 0x98
	public readonly GameSetting PriorityWindowMode; //Field offset: 0xA0
	public readonly GameSetting AutoVaultingMode; //Field offset: 0xA8
	public readonly GameSetting ContinuousHealMode; //Field offset: 0xB0
	public readonly GameSetting QuestItemNotificationMode; //Field offset: 0xB8
	public readonly GameSetting QuestItemSearchMode; //Field offset: 0xC0
	public readonly GameSetting WishlistNotificationsType; //Field offset: 0xC8
	public readonly GameSetting AutoAddToWishlist; //Field offset: 0xD0
	public readonly GameSetting MalfunctionVisability; //Field offset: 0xD8
	public readonly GameSetting TradingIntermediateScreen; //Field offset: 0xE0
	public readonly GameSetting SpectatingEnable; //Field offset: 0xE8
	public readonly GameSetting RagfairLinesCount; //Field offset: 0xF0
	public readonly GameSetting EnvironmentUiType; //Field offset: 0xF8
	public readonly GameSetting TacticalInputMode; //Field offset: 0x100

	public GameSettingsGroup() { }

	public virtual GameSettingsGroup Clone() { }

}

