namespace EFT.Settings.Graphics;

public sealed class GraphicsSettingsCameraController : BaseSettingsController
{
	private readonly CameraManager _manager; //Field offset: 0x28

	public GraphicsSettingsCameraController(CameraManager manager) { }

	[CompilerGenerated]
	private void <CreateBindings>b__3_0(EftDisplaySettings displaySettings) { }

	[CompilerGenerated]
	private void <CreateBindings>b__3_1(ESamplingMode x) { }

	[CompilerGenerated]
	private void <CreateBindings>b__3_2(EAntialiasingMode x) { }

	[CompilerGenerated]
	private void <CreateBindings>b__3_3(EDLSSMode x) { }

	[CompilerGenerated]
	private void <CreateBindings>b__3_4(EFSR2Mode x) { }

	[CompilerGenerated]
	private void <CreateBindings>b__3_5(EFSR3Mode x) { }

	[CompilerGenerated]
	private void <CreateBindings>b__3_6(EFSR2Mode x) { }

	[CompilerGenerated]
	private void <CreateBindings>b__3_7(EFSR3Mode x) { }

	[CompilerGenerated]
	private void <CreateBindings>b__3_8(EDLSSPreset x) { }

	protected virtual void CreateBindings() { }

	public virtual GraphicsSettingsGroup SettingsGroupFactory() { }

}

