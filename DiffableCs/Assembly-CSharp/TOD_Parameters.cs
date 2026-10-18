//Type is in global namespace

public class TOD_Parameters
{
	public TOD_CycleParameters Cycle; //Field offset: 0x10
	public TOD_WorldParameters World; //Field offset: 0x18
	public TOD_AtmosphereParameters Atmosphere; //Field offset: 0x20
	public TOD_DayParameters Day; //Field offset: 0x28
	public TOD_NightParameters Night; //Field offset: 0x30
	public TOD_SunParameters Sun; //Field offset: 0x38
	public TOD_MoonParameters Moon; //Field offset: 0x40
	public TOD_LightParameters Light; //Field offset: 0x48
	public TOD_StarParameters Stars; //Field offset: 0x50
	public TOD_FogParameters Fog; //Field offset: 0x58
	public TOD_AmbientParameters Ambient; //Field offset: 0x60
	public TOD_ReflectionParameters Reflection; //Field offset: 0x68

	public TOD_Parameters() { }

	public TOD_Parameters(TOD_Sky sky) { }

	public void ToSky(TOD_Sky sky) { }

}

