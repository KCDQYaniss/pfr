namespace EFT.Water;

[Flags]
public enum EWaterFeatureDirty
{
	None = 0,
	PropertiesChanged = 1,
	GraphicsSettingsChanged = 2,
	OpticSightChanged = 4,
	InitialRender = 8,
	DrawingResultsChanged = 16,
}

