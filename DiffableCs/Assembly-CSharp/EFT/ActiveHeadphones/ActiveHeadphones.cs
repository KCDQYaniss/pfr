namespace EFT.ActiveHeadphones;

public class ActiveHeadphones : IActiveHeadphones, IHeadphonesTemplateComponent
{
	private readonly IHeadphonesTemplateComponent[] _components; //Field offset: 0x10

	public ActiveHeadphones(IHeadphonesTemplateComponent[] components) { }

	public override void Configure(HeadphonesApplyContext context, bool doFade = true) { }

}

