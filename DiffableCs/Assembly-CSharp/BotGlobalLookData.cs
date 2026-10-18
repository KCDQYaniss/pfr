//Type is in global namespace

public class BotGlobalLookData
{
	[Comment("Время жизни точки до которой бот будет обращать внимание на нее при стандартном алгоритме осмотра.")]
	public float OLD_TIME_POINT; //Field offset: 0x10
	[Comment("дельта через которую бот обновит точки в стандартном алгоритме куда ему смотреть")]
	public float WAIT_NEW_SENSOR; //Field offset: 0x14
	[Comment("Дельта при которой бот может повернутся в другую сторону вдоль стены в стандартном алгоритме")]
	public float WAIT_NEW__LOOK_SENSOR; //Field offset: 0x18
	[Comment("Время просмотра одного направления, когда бот осматривает место.")]
	public float LOOK_AROUND_DELTA; //Field offset: 0x1C
	[Comment("Дистанция через на которую бот видит в листву")]
	public float MAX_VISION_GRASS_METERS; //Field offset: 0x20
	[Comment("Коэфициент вспышки от оружия. Влияет на то как быстро бот заметит стрелявшего")]
	public float MAX_VISION_GRASS_METERS_FLARE; //Field offset: 0x24
	[Comment(null)]
	public float MAX_VISION_GRASS_METERS_OPT; //Field offset: 0x28
	[Comment(null)]
	public float MAX_VISION_GRASS_METERS_FLARE_OPT; //Field offset: 0x2C
	[Comment("TODO фонарики")]
	public float LightOnVisionDistance; //Field offset: 0x30
	[Comment("Дистанция выше которой объект считается дальеко")]
	public float FAR_DISTANCE; //Field offset: 0x34
	[Comment("Дельта апдейта следущего времни на дальнем расстоянии")]
	public float FarDeltaTimeSec; //Field offset: 0x38
	[Comment("Дистанция выше которой объект считается на среднем расстоянии")]
	public float MIDDLE_DIST; //Field offset: 0x3C
	[Comment("Дельта апдейта следущего времни на среднем расстоянии")]
	public float MiddleDeltaTimeSec; //Field offset: 0x40
	[Comment("Дельта апдейта следущего времни на близком расстоянии")]
	public float CloseDeltaTimeSec; //Field offset: 0x44
	[Comment("Время при котором не сбрасывается набор видимости.")]
	public float POSIBLE_VISION_SPACE; //Field offset: 0x48
	[Comment("Скорость изменения шкалы видимости. 1= с течением времени >1 - быстрее, <1 - медленнее.")]
	public float VISIBILITY_CHANGE_SPEED; //Field offset: 0x4C
	[Comment("Скорость изменения шкалы видимости (только для уменьшения шкалы). 1= с течением времени >1 - быстрее, <1 - медленнее.")]
	public float VISIBILITY_CHANGE_DECREASE_SPEED; //Field offset: 0x50
	[Comment("Базовый коэфициент влияния рантайм эффектов(дым/ослепление итд) на общую скорость замечания. Крутить в случае необходимости различий влияния эффектов на конкретную роль. 1= с течением времени >1 - быстрее, <1 - медленнее.")]
	public float BASE_RUNTIME_EFFECT_K; //Field offset: 0x54
	[Comment("Максимальное значение коэфициента скорости изменения шкалы видимости при минимальной дистанции. Чем больше, тем быстрее будет увеличиваться шкала вблизи противника.")]
	public float MIN_DISTANCE_VISIBILITY_CHANGE_SPEED_K; //Field offset: 0x58
	[Comment("Минимальное значение коэфициента скорости изменения шкалы видимости при максимальной дистанции. Чем больше, тем быстрее будет увеличиваться шкала вдали противника.")]
	public float MAX_DISTANCE_VISIBILITY_CHANGE_SPEED_K; //Field offset: 0x5C
	[Comment("После пропадания из видимости бот еще столько секуннд будет \"Видеть\" врага")]
	public float GOAL_TO_FULL_DISSAPEAR; //Field offset: 0x60
	[Comment("После пропадания из видимости бот еще столько секуннд будет \"Видеть\" врага если мешает только зелень")]
	public float GOAL_TO_FULL_DISSAPEAR_GREEN; //Field offset: 0x64
	[Comment("После пропадания из видимости бот еще столько секуннд сможет стрелять во врага")]
	public float GOAL_TO_FULL_DISSAPEAR_SHOOT; //Field offset: 0x68
	[Comment("Частота поиска новых тел")]
	public float BODY_DELTA_TIME_SEARCH_SEC; //Field offset: 0x6C
	[Comment("Период обновления цели в search ноде")]
	public float REFRESH_SEARCH_POINT_PERIOD; //Field offset: 0x70
	[Comment(null)]
	public float COME_TO_BODY_DIST; //Field offset: 0x74
	[Comment(null)]
	public float MARKSMAN_VISIBLE_DIST_COEF; //Field offset: 0x78
	[Comment("Дальности видимости с фонариком")]
	public float VISIBLE_DISNACE_WITH_LIGHT; //Field offset: 0x7C
	[Comment("Настолько дальше в метрах будет виден враг если у него включен фонарь.")]
	public float ENEMY_LIGHT_ADD; //Field offset: 0x80
	[Comment("Если дальность зрения бота меньше Х то начинает действовать параметр ENEMY_LIGHT_COEF")]
	public float ENEMY_LIGHT_START_DIST; //Field offset: 0x84
	[Comment("Если точка на которую смотрит бот ближе чем Х. Он может будет игрорить стены")]
	public float DIST_NOT_TO_IGNORE_WALL; //Field offset: 0x88
	[Comment("Если стена ближе чем Х то бот будет смотреть по ходу движения когда идет к подозрительной точке.")]
	public float DIST_CHECK_WALL; //Field offset: 0x8C
	[Comment("Если небыло никаких других точек интереса, то бот будет смотреть на последнюю точку где они видел своего врага")]
	public float LOOK_LAST_POSENEMY_IF_NO_DANGER_SEC; //Field offset: 0x90
	[Comment(null)]
	public float MIN_LOOK_AROUD_TIME; //Field offset: 0x94
	[Comment(null)]
	public bool LOOK_THROUGH_GRASS; //Field offset: 0x98
	[Comment("Если расстояние между первой точкой попадания в лист и обратной точкой попадания в листу меньше чем Х то бот видит. Работает только при Х > 0")]
	public float LOOK_THROUGH_GRASS_DIST_METERS; //Field offset: 0x9C
	[Comment("Меньше скольки секунд  последний раз был замечен бот что бы сработл коэфициент ускоренного замечания")]
	public float SEC_REPEATED_SEEN; //Field offset: 0xA0
	[Comment(null)]
	public double DIST_SQRT_REPEATED_SEEN; //Field offset: 0xA8
	[Comment("Меньше скольки метров относительно своей старой точки долежн быть бот что бы сработл коэфициент ускоренного замечания")]
	public double DIST_REPEATED_SEEN; //Field offset: 0xB0
	[Comment("Коэфициент на сколько быстрее увидет бот при условии DIST_REPEATED_SEEN и SEC_REPEATED_SEEN больше - быстрее. 1==Также")]
	public float COEF_REPEATED_SEEN; //Field offset: 0xB8
	[Comment("Если враг дальеш чем Х метров то будет учитываться эта дистанця")]
	public float MAX_DIST_CLAMP_TO_SEEN_SPEED; //Field offset: 0xBC
	[Comment(" Если дальность видимости бот меньше Х вкл ПНВ")]
	public float NIGHT_VISION_ON; //Field offset: 0xC0
	[Comment("   Если дальность видимости бот больше Х выкл ПНВ")]
	public float NIGHT_VISION_OFF; //Field offset: 0xC4
	[Comment(" При включенном ПНВ бот видит на Х метров")]
	public float NIGHT_VISION_DIST; //Field offset: 0xC8
	[Comment("Бот никогда не прячет ПНВ в подсумок и не снимает шлемы с пнв")]
	public bool NEVER_HIDE_NIGHT_VISION; //Field offset: 0xCC
	[Comment("Угл видимости когда включен фонарик")]
	public float VISIBLE_ANG_LIGHT; //Field offset: 0xD0
	[Comment("Угл видимости когда включен ПНВ")]
	public float VISIBLE_ANG_NIGHTVISION; //Field offset: 0xD4
	[Comment("если расстояние между игроками меньше Х то трава и листва игноряться на уровне Слоёв. ")]
	public float NO_GREEN_DIST; //Field offset: 0xD8
	[Comment("если расстояние между игроками меньше Х то трава игноряться на уровне Слоёв. ")]
	public float NO_GRASS_DIST; //Field offset: 0xDC
	[Comment("Коэфициент применяемый к скорости замечания если бот находится внутри куста")]
	public float INSIDE_BUSH_COEF; //Field offset: 0xE0
	[Comment("какую кривую использовать для дальности зрения по времени суток")]
	public bool SELF_NIGHTVISION; //Field offset: 0xE4
	[Comment("Видимость 360")]
	public bool FULL_SECTOR_VIEW; //Field offset: 0xE5
	[Comment("Видимость 360 Дистанция ограничения")]
	public double FULL_SECTOR_VIEW_DIST; //Field offset: 0xE8
	[Comment("Сколько секунд после попадния во себя будет иметь возможность смотреть через зелень")]
	public float LOOK_THROUGH_PERIOD_BY_HIT; //Field offset: 0xF0
	public bool CHECK_HEAD_ANY_DIST; //Field offset: 0xF4
	public bool MIDDLE_DIST_CAN_SHOOT_HEAD; //Field offset: 0xF5
	[Comment("Может ли использовать фонарик")]
	public bool CAN_USE_LIGHT; //Field offset: 0xF6
	[Comment("Множитель дистанции видимости при самом сильном дожде")]
	public float RAIN_DEBUFF_MAXVISIBILITY_MULTIPLYER; //Field offset: 0xF8
	[Comment("Множитель дистанции видимости при самом сильном тумане")]
	public float FOG_DEBUFF_MAXVISIBILITY_MULTIPLYER; //Field offset: 0xFC
	[Comment("Множитель задержки распознавания при самом сильном дожде")]
	public float RAIN_DEBUFF_SEENCOEFF_MULTIPLYER; //Field offset: 0x100
	[Comment("Множитель задержки распознавания при самом сильном тумане")]
	public float FOG_DEBUFF_SEENCOEFF_MULTIPLYER; //Field offset: 0x104
	[Comment("В качестве файр порта всегда будут использованны глаза бота а не ствол оружия (локально и на сервере)")]
	public bool SHOOT_FROM_EYES; //Field offset: 0x108
	public float ANGLE_FOR_GETUP; //Field offset: 0x10C
	[Comment("видимость ниже которой после применения кривой видимост, видимость падать не будет")]
	public float MINIMUM_VISIBLE_DIST; //Field offset: 0x110
	[Comment("Шанс на точ то бот будет использовать стробоскоп")]
	public float CAN_USE_STRIBOSCOPE; //Field offset: 0x114
	[Comment("Сколько времени наблюдать за врагом если он есть при стандартном зррении")]
	public float LOOK_TO_ENEMY_TIME; //Field offset: 0x118
	[Comment("Чем больше значение, тем быстрее будет проявляться на коэфициент угла по мере увеличения дистанции. Диапазон имеет смысл от 1 до 200. Есть матмодель.")]
	public float ANGLE_VISION_COEF_FILTER; //Field offset: 0x11C
	[Comment("Скорость поворота головы во время процесса замечания цели")]
	public float HEAD_ROTATE_SPEED; //Field offset: 0x120
	[Comment("Уровень видимости для старта поворота головы на наиболее замечаемую цель")]
	public float VISIBILITY_LEVEL_TO_TURN_HEAD; //Field offset: 0x124
	[Comment("Сколько секунд бот будет смотреть на врага в ноде аттак мувинг после потери прямого контакта")]
	public float ATTCK_MOVING_LOOK_TO_ENEMY; //Field offset: 0x128

	public BotGlobalLookData() { }

	public void Update() { }

}

