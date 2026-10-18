namespace EFT.Settings.PostFx;

public sealed class PostFxSettingsController : BaseSettingsController
{
	private readonly GradingPostFX _postFx; //Field offset: 0x28

	public PostFxSettingsController(GradingPostFX postFX) { }

	protected virtual void CreateBindings() { }

	public virtual PostFxSettingsGroup SettingsGroupFactory() { }

	public void TryForceUpdate() { }

	private void TryUpdateAdaptiveSharpen(int value) { }

	private void TryUpdateBrightness(int value) { }

	private void TryUpdateClarity(int value) { }

	private void TryUpdateColorblindnessIntensity(int value) { }

	private void TryUpdateColorBlindnessType(ColorBlindMode value) { }

	private void TryUpdateColorFilterType(Filter value) { }

	private void TryUpdateColorfulness(int value) { }

	private void TryUpdateIntensity(int value) { }

	private void TryUpdateLumaSharpen(int value) { }

	private void TryUpdateSaturation(int value) { }

	private void UpdateAdaptiveSharpen(int value) { }

	private void UpdateBrightness(int value) { }

	private void UpdateClarity(int value) { }

	private void UpdateColorblindnessIntensity(int value) { }

	private void UpdateColorBlindnessType(ColorBlindMode value) { }

	private void UpdateColorFilterType(Filter value) { }

	private void UpdateColorfulness() { }

	private void UpdateEnablePostFX(bool value) { }

	private void UpdateIntensity(int value) { }

	private void UpdateLumaSharpen(int value) { }

	private void UpdateSaturation() { }

}

