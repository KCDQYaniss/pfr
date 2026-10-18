namespace EFT.Interactive.Commands;

public class CommandContainer
{
	private readonly LampLights _lampLights; //Field offset: 0x10
	[CompilerGenerated]
	private float <Intensity>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly ContinuePlayCommand <ContinuePlay>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly DestroyCommand <Destroy>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly PlayEffectCommand <PlayEffect>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly PlayFlickeringSoundCommand <PlayFlickeringSound>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly PlaySoundCommand <PlaySound>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly StartConstantFlickeringCommand <StartConstantFlickering>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly PlayTurnOffClipCommand <PlayTurnOffSound>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly ProcessTurnOnFlickeringCommand <ProcessTurnOnFlickering>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly SmartEnableCommand <SmartEnable>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly TurnLightsCommand <TurnLights>k__BackingField; //Field offset: 0x68

	public ContinuePlayCommand ContinuePlay
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public DestroyCommand Destroy
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public float Intensity
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public PlayEffectCommand PlayEffect
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public PlayFlickeringSoundCommand PlayFlickeringSound
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public PlaySoundCommand PlaySound
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public PlayTurnOffClipCommand PlayTurnOffSound
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ProcessTurnOnFlickeringCommand ProcessTurnOnFlickering
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public SmartEnableCommand SmartEnable
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public StartConstantFlickeringCommand StartConstantFlickering
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public TurnLightsCommand TurnLights
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CommandContainer(LampController lampController, LampLights lampLights, LampSound lampSound) { }

	public void Execute(float time) { }

	[CompilerGenerated]
	public ContinuePlayCommand get_ContinuePlay() { }

	[CompilerGenerated]
	public DestroyCommand get_Destroy() { }

	[CompilerGenerated]
	public float get_Intensity() { }

	[CompilerGenerated]
	public PlayEffectCommand get_PlayEffect() { }

	[CompilerGenerated]
	public PlayFlickeringSoundCommand get_PlayFlickeringSound() { }

	[CompilerGenerated]
	public PlaySoundCommand get_PlaySound() { }

	[CompilerGenerated]
	public PlayTurnOffClipCommand get_PlayTurnOffSound() { }

	[CompilerGenerated]
	public ProcessTurnOnFlickeringCommand get_ProcessTurnOnFlickering() { }

	[CompilerGenerated]
	public SmartEnableCommand get_SmartEnable() { }

	[CompilerGenerated]
	public StartConstantFlickeringCommand get_StartConstantFlickering() { }

	[CompilerGenerated]
	public TurnLightsCommand get_TurnLights() { }

	[CompilerGenerated]
	public void set_Intensity(float value) { }

}

