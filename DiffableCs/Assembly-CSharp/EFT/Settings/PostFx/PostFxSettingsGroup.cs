namespace EFT.Settings.PostFx;

public sealed class PostFxSettingsGroup : SettingsGroup
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__ClampTwoSide; //Field offset: 0x0
		public static Func <1>__ClampOneSide; //Field offset: 0x8

	}

	public readonly GameSetting EnablePostFx; //Field offset: 0x18
	public readonly GameSetting Brightness; //Field offset: 0x20
	public readonly GameSetting Saturation; //Field offset: 0x28
	public readonly GameSetting Clarity; //Field offset: 0x30
	public readonly GameSetting Colorfulness; //Field offset: 0x38
	public readonly GameSetting LumaSharpen; //Field offset: 0x40
	public readonly GameSetting AdaptiveSharpen; //Field offset: 0x48
	public readonly GameSetting ColorFilterType; //Field offset: 0x50
	public readonly GameSetting Intensity; //Field offset: 0x58
	public readonly GameSetting ColorBlindnessType; //Field offset: 0x60
	public readonly GameSetting ColorBlindnessIntensity; //Field offset: 0x68

	public PostFxSettingsGroup() { }

	private static int ClampOneSide(int value) { }

	private static int ClampTwoSide(int value) { }

	public virtual PostFxSettingsGroup Clone() { }

}

