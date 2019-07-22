using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

#region GirlGlobeProto
/// <summary>
/// 임시 챕터 데이터
/// </summary>
public class ChapterData
{
    public int id;
    public int map_size_by_resolution;
    public float size_x;
    public float size_y;
    public byte map_color_r;
    public byte map_color_g;
    public byte map_color_b;
    public string resource_name;

    public ChapterData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        map_size_by_resolution = Utils.IntConvert( values[ 1 ] );
        size_x = Utils.FloatConvert( values[ 2 ] );
        size_y = Utils.FloatConvert( values[ 3 ] );
        map_color_r = Utils.ByteConvert( values[ 4 ] );
        map_color_g = Utils.ByteConvert( values[ 5 ] );
        map_color_b = Utils.ByteConvert( values[ 6 ] );
        resource_name = values[ 7 ];
    }
}

/// <summary>
/// 임시 스테이지 데이터
/// </summary>
public class ChapterStageData
{
    public int id;
    public int chapter_id;
    public int require_heart;
    public int reward_silver;
    public int reward_exp;
    public int reward_wear_id_1;
    public int reward_wear_id_2;
    public int reward_wear_id_3;
    public int reward_wear_id_4;
    public float pos_x;
    public float pos_y;

    public ChapterStageData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        chapter_id = Utils.IntConvert( values[ 1 ] );
        require_heart = Utils.IntConvert( values[ 2 ] );
        reward_silver = Utils.IntConvert( values[ 3 ] );
        reward_exp = Utils.IntConvert( values[ 4 ] );
        reward_wear_id_1 = Utils.IntConvert( values[ 5 ] );
        reward_wear_id_2 = Utils.IntConvert( values[ 6 ] );
        reward_wear_id_3 = Utils.IntConvert( values[ 7 ] );
        reward_wear_id_4 = Utils.IntConvert( values[ 8 ] );
        pos_x = Utils.FloatConvert( values[ 9 ] );
        pos_y = Utils.FloatConvert( values[ 10 ] );
    }
}

/// <summary>
/// 임시 챕터 오브젝트 데이터
/// </summary>
public class ChapterObjectData
{
    public int id;
    public int chapter_id;
    public int animation_type;
    public int sprite_count;
    public string resource_name;
    public float pos_x;
    public float pos_y;

    public ChapterObjectData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        chapter_id = Utils.IntConvert( values[ 1 ] );
        animation_type = Utils.IntConvert( values[ 2 ] );
        sprite_count = Utils.IntConvert( values[ 3 ] );
        resource_name = values[ 4 ];
        pos_x = Utils.FloatConvert( values[ 5 ] );
        pos_y = Utils.FloatConvert( values[ 6 ] );
    }
}

/// <summary>
/// 임시 스토리 데이터
/// </summary>
public class StoryData
{
    public int id;
    public int stage_id;
    public string background_image;
    public int character_1;
    public int character_2;
    public int teller;
    public int character_1_emotion;
    public int character_2_emotion;
    public string script;

    public StoryData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        stage_id = Utils.IntConvert( values[ 1 ] );
        background_image = values[ 2 ];
        character_1 = Utils.IntConvert( values[ 3 ] );
        character_2 = Utils.IntConvert( values[ 4 ] );
        teller = Utils.IntConvert( values[ 5 ] );
        character_1_emotion = Utils.IntConvert( values[ 6 ] );
        character_2_emotion = Utils.IntConvert( values[ 7 ] );
        script = values[ 8 ];
    }
}

/// <summary>
/// 임시 캐릭터 데이터
/// </summary>
public class CharacterData
{
    public int id;
    public string name;
    public float story_pos_x;
    public float story_pos_y;
    public float contest_pos_x;
    public float contest_pos_y;

    public CharacterData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        name = values[ 1 ];
        story_pos_x = Utils.FloatConvert( values[ 2 ] );
        story_pos_y = Utils.FloatConvert( values[ 3 ] );
        contest_pos_x = Utils.FloatConvert( values[ 4 ] );
        contest_pos_y = Utils.FloatConvert( values[ 5 ] );
    }
}

/// <summary>
/// 임시 대결 데이터
/// </summary>
public class ContestData
{
    public int id;
    public int contest_character_id;
    public int contest_attribute_id_1;
    public int contest_attribute_id_2;
    public int contest_attribute_id_3;
    public int contest_attribute_id_4;
    public int contest_attribute_id_5;
    public int contest_brand_id;
    public int contest_tag_id_1;
    public int contest_tag_id_2;
    public int contest_tag_id_3;
    public int contest_tag_id_4;
    public int contest_tag_id_5;
    public int contest_tag_id_6;
    public int contest_tag_id_7;
    public int contest_tag_id_8;
    public int contest_tag_id_9;
    public int npc_attribute_1_point;
    public int npc_attribute_2_point;
    public int npc_attribute_3_point;
    public int npc_attribute_4_point;
    public int npc_attribute_5_point;
    public int rank_c_point;
    public int rank_b_point;
    public int rank_a_point;
    public int rank_s_point;

    public ContestData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        contest_character_id = Utils.IntConvert( values[ 1 ] );
        contest_attribute_id_1 = Utils.IntConvert( values[ 2 ] );
        contest_attribute_id_2 = Utils.IntConvert( values[ 3 ] );
        contest_attribute_id_3 = Utils.IntConvert( values[ 4 ] );
        contest_attribute_id_4 = Utils.IntConvert( values[ 5 ] );
        contest_attribute_id_5 = Utils.IntConvert( values[ 6 ] );
        contest_brand_id = Utils.IntConvert( values[ 7 ] );
        contest_tag_id_1 = Utils.IntConvert( values[ 8 ] );
        contest_tag_id_2 = Utils.IntConvert( values[ 9 ] );
        contest_tag_id_3 = Utils.IntConvert( values[ 10 ] );
        contest_tag_id_4 = Utils.IntConvert( values[ 11 ] );
        contest_tag_id_5 = Utils.IntConvert( values[ 12 ] );
        contest_tag_id_6 = Utils.IntConvert( values[ 13 ] );
        contest_tag_id_7 = Utils.IntConvert( values[ 14 ] );
        contest_tag_id_8 = Utils.IntConvert( values[ 15 ] );
        contest_tag_id_9 = Utils.IntConvert( values[ 16 ] );
        npc_attribute_1_point = Utils.IntConvert( values[ 17 ] );
        npc_attribute_2_point = Utils.IntConvert( values[ 18 ] );
        npc_attribute_3_point = Utils.IntConvert( values[ 19 ] );
        npc_attribute_4_point = Utils.IntConvert( values[ 20 ] );
        npc_attribute_5_point = Utils.IntConvert( values[ 21 ] );
        rank_c_point = Utils.IntConvert( values[ 22 ] );
        rank_b_point = Utils.IntConvert( values[ 23 ] );
        rank_a_point = Utils.IntConvert( values[ 24 ] );
        rank_s_point = Utils.IntConvert( values[ 25 ] );
    }
}

/// <summary>
/// 대결 - 속성 공식 데이터
/// </summary>
public class ContestAttributeFormulaData
{
    public int id;
    public int repr_attribute_match_count;
    public float repr_attribute_addition_value;
    public int common_attribute_match_count;
    public float common_attribute_addition_value;

    public ContestAttributeFormulaData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        repr_attribute_match_count = Utils.IntConvert( values[ 1 ] );
        repr_attribute_addition_value = Utils.FloatConvert( values[ 2 ] );
        common_attribute_match_count = Utils.IntConvert( values[ 3 ] );
        common_attribute_addition_value = Utils.FloatConvert( values[ 4 ] );
    }
}

/// <summary>
/// 대결 - 태그 공식 데이터
/// </summary>
public class ContestTagFormulaData
{
    public int id;
    public int tag_match_count;
    public float tag_addition_value;

    public ContestTagFormulaData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        tag_match_count = Utils.IntConvert( values[ 1 ] );
        tag_addition_value = Utils.FloatConvert( values[ 2 ] );
    }
}

/// <summary>
/// 대결 - 브랜드 공식 데이터
/// </summary>
public class ContestBrandFormulaData
{
    public int id;
    public int brand_match_count;
    public float brand_addition_value;

    public ContestBrandFormulaData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        brand_match_count = Utils.IntConvert( values[ 1 ] );
        brand_addition_value = Utils.FloatConvert( values[ 2 ] );
    }
}

/// <summary>
/// 임시 튜토리얼 데이터
/// </summary>
public class TutorialData
{
    public int id;
    public int tutorial_phase;
    public bool show_background;
    public bool is_touch_background;
    public bool show_text_box;
    public float text_box_pos_y;
    public string script;
    public bool show_quokka;
    public int quokka_direction;
    public float quokka_pos_x;
    public float quokka_pos_y;
    public GirlGlobeEnums.eTutorialObject tutorial_object;
    public bool is_slide_ani;
    public float slide_ani_start_pos_x;
    public float slide_ani_end_pos_x;

    public TutorialData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        tutorial_phase = Utils.IntConvert( values[ 1 ] );
        show_background = Utils.BoolConvert( values[ 2 ] );
        is_touch_background = Utils.BoolConvert( values[ 3 ] );
        show_text_box = Utils.BoolConvert( values[ 4 ] );
        text_box_pos_y = Utils.FloatConvert( values[ 5 ] );
        script = values[ 6 ];
        show_quokka = Utils.BoolConvert( values[ 7 ] );
        quokka_direction = Utils.IntConvert( values[ 8 ] );
        quokka_pos_x = Utils.FloatConvert( values[ 9 ] );
        quokka_pos_y = Utils.FloatConvert( values[ 10 ] );

        if( string.IsNullOrEmpty( values[ 11 ] ) == true )
        {
            tutorial_object = GirlGlobeEnums.eTutorialObject.NONE;
        }
        else
        {
            tutorial_object = Utils.ConvertEnumData< GirlGlobeEnums.eTutorialObject >( values[ 11 ] );
        }
        
        is_slide_ani = Utils.BoolConvert( values[ 12 ] );
        slide_ani_start_pos_x = Utils.FloatConvert( values[ 13 ] );
        slide_ani_end_pos_x = Utils.FloatConvert( values[ 14 ] );
    }
}

/// <summary>
/// 게임 시작 시 유저 보유 의상 데이터
/// </summary>
public class InitHaveUserData
{
    public int id;
    public bool is_init_have;

    public InitHaveUserData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        is_init_have = Utils.BoolConvert( values[ 1 ] );
    }
}

/// <summary>
/// 오디션 봇 데이터
/// </summary>
public class AuditionBotData
{
    public int id;
    public int wear_id_1;
    public int wear_id_2;
    public int wear_id_3;
    public int wear_id_4;
    public int wear_id_5;
    public int wear_id_6;
    public int wear_id_7;
    public int wear_id_8;
    public int wear_id_9;
    public int wear_id_10;
    public int vote_count;

    public AuditionBotData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        wear_id_1 = Utils.IntConvert( values[ 1 ] );
        wear_id_2 = Utils.IntConvert( values[ 2 ] );
        wear_id_3 = Utils.IntConvert( values[ 3 ] );
        wear_id_4 = Utils.IntConvert( values[ 4 ] );
        wear_id_5 = Utils.IntConvert( values[ 5 ] );
        wear_id_6 = Utils.IntConvert( values[ 6 ] );
        wear_id_7 = Utils.IntConvert( values[ 7 ] );
        wear_id_8 = Utils.IntConvert( values[ 8 ] );
        wear_id_9 = Utils.IntConvert( values[ 9 ] );
        wear_id_10 = Utils.IntConvert( values[ 10 ] );
        vote_count = 0;
    }
}

/// <summary>
/// 랭킹 봇 데이터
/// </summary>
public class RankingBotData
{
    public int id;
    public bool is_server_ranking;
    public int rank;
    public string nickname;
    public string introduction;
    public int audition_point;
    public int stage_point;
    public int wear_id_1;
    public int wear_id_2;
    public int wear_id_3;
    public int wear_id_4;
    public int wear_id_5;
    public int wear_id_6;
    public int wear_id_7;
    public int wear_id_8;
    public int wear_id_9;
    public int wear_id_10;
    public bool is_selected;

    public RankingBotData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        is_server_ranking = Utils.BoolConvert( values[ 1 ] );
        rank = Utils.IntConvert( values[ 2 ] );
        nickname = values[ 3 ];
        introduction = values[ 4 ];
        audition_point = Utils.IntConvert( values[ 5 ] );
        stage_point = Utils.IntConvert( values[ 6 ] );
        wear_id_1 = Utils.IntConvert( values[ 7 ] );
        wear_id_2 = Utils.IntConvert( values[ 8 ] );
        wear_id_3 = Utils.IntConvert( values[ 9 ] );
        wear_id_4 = Utils.IntConvert( values[ 10 ] );
        wear_id_5 = Utils.IntConvert( values[ 11 ] );
        wear_id_6 = Utils.IntConvert( values[ 12 ] );
        wear_id_7 = Utils.IntConvert( values[ 13 ] );
        wear_id_8 = Utils.IntConvert( values[ 14 ] );
        wear_id_9 = Utils.IntConvert( values[ 15 ] );
        wear_id_10 = Utils.IntConvert( values[ 16 ] );
        is_selected = false;
    }
}

/// <summary>
/// 상점 판매 의상 데이터
/// </summary>
public class ShopWearData
{
    public int id;
    public int wear_id;

    public ShopWearData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        wear_id = Utils.IntConvert( values[ 1 ] );
    }
}

/// <summary>
/// 언어 선택 데이터
/// </summary>
public class SelectLanguageData
{
    public GirlGlobeEnums.eLanguage language;
    public string languageName;
}

public class HintData
{
    public int id;
    public int chapter_stage_id;
    public int common_hint_wear_id_1;
    public int common_hint_wear_id_2;
    public int common_hint_wear_id_3;
    public int common_hint_wear_id_4;
    public int common_hint_wear_id_5;
    public int common_hint_wear_id_6;
    public int common_hint_wear_id_7;
    public int common_hint_wear_id_8;
    public int common_hint_wear_id_9;
    public int common_hint_wear_id_10;
    public int s_hint_wear_id_1;
    public int s_hint_wear_id_2;
    public int s_hint_wear_id_3;
    public int s_hint_wear_id_4;
    public int s_hint_wear_id_5;
    public int s_hint_wear_id_6;
    public int s_hint_wear_id_7;
    public int s_hint_wear_id_8;
    public int s_hint_wear_id_9;
    public int s_hint_wear_id_10;

    public HintData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        chapter_stage_id = Utils.IntConvert( values[ 1 ] );
        common_hint_wear_id_1 = Utils.IntConvert( values[ 2 ] );
        common_hint_wear_id_2 = Utils.IntConvert( values[ 3 ] );
        common_hint_wear_id_3 = Utils.IntConvert( values[ 4 ] );
        common_hint_wear_id_4 = Utils.IntConvert( values[ 5 ] );
        common_hint_wear_id_5 = Utils.IntConvert( values[ 6 ] );
        common_hint_wear_id_6 = Utils.IntConvert( values[ 7 ] );
        common_hint_wear_id_7 = Utils.IntConvert( values[ 8 ] );
        common_hint_wear_id_8 = Utils.IntConvert( values[ 9 ] );
        common_hint_wear_id_9 = Utils.IntConvert( values[ 10 ] );
        common_hint_wear_id_10 = Utils.IntConvert( values[ 11 ] );
        s_hint_wear_id_1 = Utils.IntConvert( values[ 12 ] );
        s_hint_wear_id_2 = Utils.IntConvert( values[ 13 ] );
        s_hint_wear_id_3 = Utils.IntConvert( values[ 14 ] );
        s_hint_wear_id_4 = Utils.IntConvert( values[ 15 ] );
        s_hint_wear_id_5 = Utils.IntConvert( values[ 16 ] );
        s_hint_wear_id_6 = Utils.IntConvert( values[ 17 ] );
        s_hint_wear_id_7 = Utils.IntConvert( values[ 18 ] );
        s_hint_wear_id_8 = Utils.IntConvert( values[ 19 ] );
        s_hint_wear_id_9 = Utils.IntConvert( values[ 20 ] );
        s_hint_wear_id_10 = Utils.IntConvert( values[ 21 ] );
    }
}

public class WearData
{
    public int id;
    public int brand_id;
    public int wear_id;
    public int type_id;
    public int type;
    public int category;
    public int sub_category;
    public int set_id;
    public int color;
    public int tag_id_1;
    public int tag_id_2;
    public int tag_id_3;
    public int tag_id_4;
    public int tag_id_5;
    public int tag_id_6;
    public int tag_id_7;
    public int tag_id_8;
    public int tag_id_9;
    public int rank;
    public int rarity;
    public int repr_attribute_1;
    public int repr_attribute_2;
    public int girlish_point;
    public int girlish_rank;
    public int mature_point;
    public int mature_rank;
    public int casual_point;
    public int casual_rank;
    public int formal_point;
    public int formal_rank;
    public int warm_point;
    public int warm_rank;
    public int cool_point;
    public int cool_rank;
    public int cute_point;
    public int cute_rank;
    public int sexy_point;
    public int sexy_rank;
    public int manish_point;
    public int manish_rank;
    public int feminine_point;
    public int feminine_rank;
    public int path_1;
    public int path_1_stage_id;
    public int path_2;
    public int path_2_stage_id;
    public int path_3;
    public int path_3_stage_id;
    public int path_4;
    public int path_4_stage_id;
    public int path_5;
    public int path_5_stage_id;
    public int path_6;
    public int path_6_stage_id;
    public int path_7;
    public int path_7_stage_id;
    public int path_8;
    public int path_8_stage_id;
    public int path_9;
    public int path_9_stage_id;
    public int path_10;
    public int path_10_stage_id;

    public WearData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        brand_id = Utils.IntConvert( values[ 1 ] );
        wear_id = Utils.IntConvert( values[ 2 ] );
        type_id = Utils.IntConvert( values[ 3 ] );
        type = Utils.IntConvert( values[ 4 ] );
        category = Utils.IntConvert( values[ 5 ] );
        sub_category = Utils.IntConvert( values[ 6 ] );
        set_id = Utils.IntConvert( values[ 7 ] );
        color = Utils.IntConvert( values[ 8 ] );
        
        tag_id_1 = Utils.IntConvert( values[ 9 ] );
        tag_id_2 = Utils.IntConvert( values[ 10 ] );
        tag_id_3 = Utils.IntConvert( values[ 11 ] );
        tag_id_4 = Utils.IntConvert( values[ 12 ] );
        tag_id_5 = Utils.IntConvert( values[ 13 ] );
        tag_id_6 = Utils.IntConvert( values[ 14 ] );
        tag_id_7 = Utils.IntConvert( values[ 15 ] );
        tag_id_8 = Utils.IntConvert( values[ 16 ] );
        tag_id_9 = Utils.IntConvert( values[ 17 ] );
        
        rank = Utils.IntConvert( values[ 18 ] );
        rarity = Utils.IntConvert( values[ 19 ] );

        repr_attribute_1 = Utils.IntConvert( values[ 20 ] );
        repr_attribute_2 = Utils.IntConvert( values[ 21 ] );
        girlish_point = Utils.IntConvert( values[ 22 ] );
        girlish_rank = Utils.IntConvert( values[ 23 ] );
        mature_point = Utils.IntConvert( values[ 24 ] );
        mature_rank = Utils.IntConvert( values[ 25 ] );
        casual_point = Utils.IntConvert( values[ 26 ] );
        casual_rank = Utils.IntConvert( values[ 27 ] );
        formal_point = Utils.IntConvert( values[ 28 ] );
        formal_rank = Utils.IntConvert( values[ 29 ] );
        warm_point = Utils.IntConvert( values[ 30 ] );
        warm_rank = Utils.IntConvert( values[ 31 ] );
        cool_point = Utils.IntConvert( values[ 32 ] );
        cool_rank = Utils.IntConvert( values[ 33 ] );
        cute_point = Utils.IntConvert( values[ 34 ] );
        cute_rank = Utils.IntConvert( values[ 35 ] );
        sexy_point = Utils.IntConvert( values[ 36 ] );
        sexy_rank = Utils.IntConvert( values[ 37 ] );
        manish_point = Utils.IntConvert( values[ 38 ] );
        manish_rank = Utils.IntConvert( values[ 39 ] );
        feminine_point = Utils.IntConvert( values[ 40 ] );
        feminine_rank = Utils.IntConvert( values[ 41 ] );

        path_1 = Utils.IntConvert( values[ 42 ] );
        path_1_stage_id = Utils.IntConvert( values[ 43 ] );
        path_2 = Utils.IntConvert( values[ 44 ] );
        path_2_stage_id = Utils.IntConvert( values[ 45 ] );
        path_3 = Utils.IntConvert( values[ 46 ] );
        path_3_stage_id = Utils.IntConvert( values[ 47 ] );
        path_4 = Utils.IntConvert( values[ 48 ] );
        path_4_stage_id = Utils.IntConvert( values[ 49 ] );
        path_5 = Utils.IntConvert( values[ 50 ] );
        path_5_stage_id = Utils.IntConvert( values[ 51 ] );
        path_6 = Utils.IntConvert( values[ 52 ] );
        path_6_stage_id = Utils.IntConvert( values[ 53 ] );
        path_7 = Utils.IntConvert( values[ 54 ] );
        path_7_stage_id = Utils.IntConvert( values[ 55 ] );
        path_8 = Utils.IntConvert( values[ 56 ] );
        path_8_stage_id = Utils.IntConvert( values[ 57 ] );
        path_9 = Utils.IntConvert( values[ 58 ] );
        path_9_stage_id = Utils.IntConvert( values[ 59 ] );
        path_10 = Utils.IntConvert( values[ 60 ] );
        path_10_stage_id = Utils.IntConvert( values[ 61 ] );
    }
}

public class WearUIData
{
    public int id;
    public string frontResourceName;
    public string backResourceName;
    public GirlGlobeEnums.eCurrencyType currencyType;
    public int wearPrice;
    public int frontWearLayerIndex;
    public int backWearLayerIndex;
    public float frontWearPosX;
    public float frontWearPosY;
    public float backWearPosX;
    public float backWearPosY;
    public string wearURL;
    public bool is_selected;
    public int decompose_count;

    public WearUIData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        frontResourceName = values[ 1 ];
        backResourceName = values[ 2 ];
        currencyType = Utils.ConvertEnumData< GirlGlobeEnums.eCurrencyType >( values[ 3 ] );
        wearPrice = Utils.IntConvert( values[ 4 ] );
        frontWearLayerIndex = Utils.IntConvert( values[ 5 ] );
        backWearLayerIndex = Utils.IntConvert( values[ 6 ] );
        frontWearPosX = Utils.FloatConvert( values[ 7 ] );
        frontWearPosY = Utils.FloatConvert( values[ 8 ] );
        backWearPosX = Utils.FloatConvert( values[ 9 ] );
        backWearPosY = Utils.FloatConvert( values[ 10 ] );
        wearURL = values[ 11 ];

        is_selected = false;
        decompose_count = 0;
    }
}

public class WearSetData
{
    public int id;
    public int brand_id;
    public int total_wear_cnt;
    public int set_wear_table_id_1;
    public int set_wear_table_id_2;
    public int set_wear_table_id_3;
    public int set_wear_table_id_4;
    public int set_wear_table_id_5;
    public int set_wear_table_id_6;
    public int set_wear_table_id_7;
    public int set_wear_table_id_8;
    public int set_wear_table_id_9;
    public int set_wear_table_id_10;

    public WearSetData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        brand_id = Utils.IntConvert( values[ 1 ] );
        total_wear_cnt = Utils.IntConvert( values[ 2 ] );
        set_wear_table_id_1 = Utils.IntConvert( values[ 3 ] );
        set_wear_table_id_2 = Utils.IntConvert( values[ 4 ] );
        set_wear_table_id_3 = Utils.IntConvert( values[ 5 ] );
        set_wear_table_id_4 = Utils.IntConvert( values[ 6 ] );
        set_wear_table_id_5 = Utils.IntConvert( values[ 7 ] );
        set_wear_table_id_6 = Utils.IntConvert( values[ 8 ] );
        set_wear_table_id_7 = Utils.IntConvert( values[ 9 ] );
        set_wear_table_id_8 = Utils.IntConvert( values[ 10 ] );
        set_wear_table_id_9 = Utils.IntConvert( values[ 11 ] );
        set_wear_table_id_10 = Utils.IntConvert( values[ 12 ] );
    }
}

public class WearSetUIData
{
    public bool is_collected;
    public int current_collect_count;

    public WearSetUIData()
    {
        is_collected = false;
        current_collect_count = 0;
    }
}

public class BrandData
{
    public int id;
    public int country_id;

    public BrandData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        country_id = Utils.IntConvert( values[ 1 ] );
    }
}

public class BrandUIData
{
    public int id;
    public string resourceName;
    public bool is_selected;
}

public class GachaData
{
    public int id;
    public int nation_id;
    public int wear_id;

    public GachaData( string[] values )
    {
        id = Utils.IntConvert( values[ 0 ] );
        nation_id = Utils.IntConvert( values[ 1 ] );
        wear_id = Utils.IntConvert( values[ 2 ] );
    }
}
#endregion

/// <summary>
/// 유저 정보
/// </summary>
public class UserData
{
    public string nickname;
    public int age;
    public int bloodType;
    public int starmapType;
    public int currentScheduleCount;
    public int currentMonth;
    public string currentDayOfWeek;
    public int currentDate;
    public string characterBirthDay;
    public int characterHeight;
    public int characterWeight;
    public int characterChestSize;
    public int characterWeistSize;
    public int characterHipSize;
    public string fatherBirthDay;
    public int fatherJob;
}

public class StaticDataManager
{
    public Dictionary< string, string > languageStringDic;

    public List< WearData > wearDataList;
    public List< WearUIData > wearUIDataList;
    public List< WearSetData > wearSetDataList;
    public List< WearSetUIData > wearSetUIDataList;

    public List< BrandData > brandDataList;
    public List< BrandUIData > brandUIDataList;

    public List< ChapterData > chapterDataList;
    public List< ChapterStageData > chapterStageDataList;
    public List< ChapterObjectData > chapterObjectDataList;

    public List< StoryData > storyDataList;
    public List< CharacterData > characterDataList;

    public List< ContestData > contestDataList;
    public List< ContestAttributeFormulaData > contestAttributeFormulaDataList;
    public List< ContestTagFormulaData > contestTagFormulaDataList;
    public List< ContestBrandFormulaData > contestBrandFormulaDataList;

    public Dictionary< int, List< GachaData > > gachaDataDic;

    public List< AuditionBotData > auditionBotDataList;
    public List< RankingBotData > rankingBotDataList;

    public List< TutorialData > tutorialDataList;

    public List< InitHaveUserData > initHaveUserDataList;

    public List< ShopWearData > shopWearDataList;

    public List< HintData > hintDataList;
        
    public StaticDataManager()
    {
        languageStringDic = new Dictionary< string, string >();

        wearDataList = new List< WearData >();
        wearUIDataList = new List< WearUIData >();
        wearSetDataList = new List< WearSetData >();
        wearSetUIDataList = new List< WearSetUIData >();

        brandDataList = new List< BrandData >();
        brandUIDataList = new List< BrandUIData >();

        chapterDataList = new List< ChapterData >();
        chapterStageDataList = new List< ChapterStageData >();
        chapterObjectDataList = new List< ChapterObjectData >();

        storyDataList = new List< StoryData >();
        characterDataList = new List< CharacterData >();

        contestDataList = new List< ContestData >();
        contestAttributeFormulaDataList = new List< ContestAttributeFormulaData >();
        contestTagFormulaDataList = new List< ContestTagFormulaData >();
        contestBrandFormulaDataList = new List< ContestBrandFormulaData >();

        gachaDataDic = new Dictionary< int, List< GachaData > >();

        auditionBotDataList = new List< AuditionBotData >();
        rankingBotDataList = new List< RankingBotData >();

        tutorialDataList = new List< TutorialData >();

        initHaveUserDataList = new List< InitHaveUserData >();

        shopWearDataList = new List< ShopWearData >();

        hintDataList = new List< HintData >();
    }

    #region 의상 데이터
    //임시로 클라이언트에서 로드해서 사용.
    public IEnumerator LoadWearData()
	{
		wearDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/WearData" );
        string wearData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                wearData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( wearData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( wearData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
                    string[] word = readLine.Split( '\t' );
					wearDataList.Add( new WearData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}

    //의상 클라이언트용 데이터 로드
    public IEnumerator LoadWearUIData()
	{
		wearUIDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/WearUIData" );
        string wearUIData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                wearUIData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( wearUIData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( wearUIData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					wearUIDataList.Add( new WearUIData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}

    //의상 세트 데이터 로드
    public IEnumerator LoadWearSetData()
	{
		wearSetDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/WearSetData" );
        string wearSetData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                wearSetData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( wearSetData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( wearSetData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					wearSetDataList.Add( new WearSetData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}

    //의상 세트 클라이언트용 데이터 로드
    public IEnumerator LoadWearSetUIData()
	{
		wearSetUIDataList.Clear();

        for( int i = 0; i < wearSetDataList.Count; i++ )
        {
            wearSetUIDataList.Add( new WearSetUIData() );
        }

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 여정 데이터
    //챕터 데이터 로드
    public IEnumerator LoadChapterData()
	{
		chapterDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/ChapterData" );
        string chapterData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                chapterData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( chapterData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( chapterData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					chapterDataList.Add( new ChapterData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}

    //챕터 스테이지 데이터 로드
    public IEnumerator LoadChapterStageData()
	{
		chapterStageDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/ChapterStageData" );
        string chapterStageData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                chapterStageData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( chapterStageData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( chapterStageData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					chapterStageDataList.Add( new ChapterStageData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}

    //챕터 오브젝트 데이터 로드
    public IEnumerator LoadChapterObjectData()
	{
		chapterObjectDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/ChapterObjectData" );
        string chapterObjectData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                chapterObjectData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( chapterObjectData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( chapterObjectData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					chapterObjectDataList.Add( new ChapterObjectData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 스토리 데이터
    //스토리 데이터 로드
    public IEnumerator LoadStoryData()
	{
		storyDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/StoryData" );
        string storyData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                storyData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( storyData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( storyData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					storyDataList.Add( new StoryData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}

    //캐릭터 데이터 로드
    public IEnumerator LoadCharacterData()
	{
		characterDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/CharacterData" );
        string characterData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                characterData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( characterData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( characterData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					characterDataList.Add( new CharacterData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 대결 데이터
    //대결 데이터 로드
    public IEnumerator LoadContestData()
	{
		contestDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/ContestData" );
        string contestData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                contestData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( contestData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( contestData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					contestDataList.Add( new ContestData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 대결 - 속성 공식 데이터
    //대결 - 속성 공식 데이터 로드
    public IEnumerator LoadContestAttributeFormulaData()
	{
		contestAttributeFormulaDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/ContestAttributeFormulaData" );
        string contestAttributeFormulaData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                contestAttributeFormulaData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( contestAttributeFormulaData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( contestAttributeFormulaData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					contestAttributeFormulaDataList.Add( new ContestAttributeFormulaData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 대결 - 태그 공식 데이터
    //대결 - 속성 공식 데이터 로드
    public IEnumerator LoadContestTagFormulaData()
	{
		contestTagFormulaDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/ContestTagFormulaData" );
        string contestTagFormulaData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                contestTagFormulaData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( contestTagFormulaData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( contestTagFormulaData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					contestTagFormulaDataList.Add( new ContestTagFormulaData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 대결 - 브랜드 공식 데이터
    //대결 - 브랜드 공식 데이터 로드
    public IEnumerator LoadContestBrandFormulaData()
	{
		contestBrandFormulaDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/ContestBrandFormulaData" );
        string contestBrandFormulaData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                contestBrandFormulaData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( contestBrandFormulaData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( contestBrandFormulaData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					contestBrandFormulaDataList.Add( new ContestBrandFormulaData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 가챠 데이터
    //가챠 데이터 로드
    public IEnumerator LoadGachaData()
	{
		gachaDataDic.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/GachaData" );
        string gachaData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                gachaData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( gachaData ) )
        {
			yield break;
		}

        List< GachaData > gachaDataList = new List< GachaData >();
		using( StringReader sr = new StringReader( gachaData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					gachaDataList.Add( new GachaData( word ) );
				}
			}
		}

        int nationCount = System.Enum.GetNames( typeof( GirlGlobeEnums.eNation ) ).Length;

        //1 = 튜토리얼 챕터라 2부터 시작
        for( int i = 2; i < nationCount+1; i++ )
        {
            List< GachaData > tempList = new List< GachaData >();

            for( int j = 0; j < gachaDataList.Count; j++ )
            {
                if(  i == gachaDataList[ j ].nation_id )
                {
                    tempList.Add( gachaDataList[ j ] );
                }
            }

            gachaDataDic.Add( i, tempList );
        }

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 언어 데이터
    //언어 데이터 로드
    public IEnumerator LoadLanguageData()
	{
		languageStringDic.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/LanguageData" );
        string languageData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                languageData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( languageData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( languageData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
                    string key = word[ 0 ];
                    string text = word[ ( int )ProjectManager.Instance.language ];
                    text = text.Replace( "/n", "\n" );
                    text = text.Trim();

                    if( languageStringDic.ContainsKey( key ) == false )
                    {
                        languageStringDic.Add( key, text );
                    }
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 튜토리얼 데이터
    //튜토리얼 데이터 로드
    public IEnumerator LoadTutorialData()
	{
		tutorialDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/TutorialData" );
        string tutorialData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                tutorialData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( tutorialData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( tutorialData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					tutorialDataList.Add( new TutorialData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 초기 유저 보유 의상 데이터
    //초기 유저 보유 의상 데이터 로드
    public IEnumerator LoadInitHaveWearData()
	{
		initHaveUserDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/InitHaveWearData" );
        string initHaveWearData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                initHaveWearData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( initHaveWearData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( initHaveWearData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					initHaveUserDataList.Add( new InitHaveUserData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 오디션 봇 데이터
    //오디션 봇 데이터 로드
    public IEnumerator LoadAuditionBotData()
	{
		auditionBotDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/AuditionBotData" );
        string auditionBotData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                auditionBotData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( auditionBotData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( auditionBotData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					auditionBotDataList.Add( new AuditionBotData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 랭킹 봇 데이터
    //랭킹 봇 데이터 로드
    public IEnumerator LoadRankingBotData()
	{
		rankingBotDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/RankingBotData" );
        string rankingBotData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                rankingBotData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( rankingBotData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( rankingBotData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					rankingBotDataList.Add( new RankingBotData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 상점 판매 의상 데이터
    //상점 판매 의상 데이터 로드
    public IEnumerator LoadShopWearData()
	{
		shopWearDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/ShopWearData" );
        string shopWearData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                shopWearData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( shopWearData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( shopWearData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					shopWearDataList.Add( new ShopWearData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion

    #region 힌트 데이터
    //힌트 데이터 로드
    public IEnumerator LoadHintData()
	{
		hintDataList.Clear();

        TextAsset textAsset = Resources.Load< TextAsset >( "Data/HintData" );
        string hintData = "";

        if( textAsset != null )
        {
            using( StreamReader streamReader = new StreamReader( new MemoryStream( textAsset.bytes ) ) )
            {
                hintData = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

		if( string.IsNullOrEmpty( hintData ) )
        {
			yield break;
		}

		using( StringReader sr = new StringReader( hintData ) )
		{
			string readLine;

			while( ( readLine = sr.ReadLine() ) != null )
			{
				if( !readLine.StartsWith( "\t" ) )
				{
					string[] word = readLine.Split( '\t' );
					hintDataList.Add( new HintData( word ) );
				}
			}
		}

        yield return YieldReturnManager.waitForEndOfFrame();
	}
    #endregion
}
