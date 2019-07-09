using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlGlobeEnums
{
    public enum eLanguage
    {
        KR = 1,
        EN,
        JP,
        CN,
    }

    public enum eTutorialObject
    {
        NONE,
        DRESSROOM_FIRST,
        DRESSROOM_SECOND,
        DRESSROOM_THIRD,
        DRESSROOM_FOURTH,
        DRESSROOM_FIFTH,
        DRESSROOM_SIXTH,
        DRESSROOM_SEVENTH,
        DRESSROOM_EIGHTH,
        DRESSROOM_NINTH,
        DRESSROOM_TENTH,
        DRESSROOM_ELEVENTH,

        SHOP_FIRST,
        SHOP_SECOND,
        SHOP_THIRD,

        CONTEST_FIRST,
        CONTEST_SECOND,
        CONTEST_THIRD,
        CONTEST_FOURTH,
        CONTEST_FIFTH,

        JOURNEYMAP_FIRST,
        JOURNEYMAP_SECOND,
        JOURNEYMAP_THIRD,

        SELECTNATION_FIRST,
        SELECTNATION_SECOND,
        SELECTNATION_THIRD,

        MAINLOBBY_FIRST,
        MAINLOBBY_SECOND,
        MAINLOBBY_THIRD,
        MAINLOBBY_FOURTH,
        MAINLOBBY_FIFTH,

        LUCKYSHOP_FIRST,
        LUCKYSHOP_SECOND,

        CLOSET_FIRST,
        CLOSET_SECOND,
        CLOSET_THIRD,
        CLOSET_FOURTH,

        CLOSETINFO_FIRST,
        CLOSETINFO_SECOND,
        CLOSETINFO_THIRD,
        CLOSETINFO_FOURTH,
        CLOSETINFO_FIFTH,
        CLOSETINFO_SIXTH,

        AUDITION_FIRST,
        AUDITION_SECOND,
        AUDITION_THIRD,

        AUDITIONVOTE_FIRST,
        AUDITIONVOTE_SECOND,
    }

    #region UI
    //화면에 보여지는 뷰 타입에 대한 enum - 해당 뷰 Prefab 이름과 매칭 시킬 것.
    public enum eUIViewType
    {
        MainLobbyView,
        ShopView,
        DressroomView,
        ClosetView,
        ClosetWearInformationView,
        JourneyMapView,
        StoryView,
        ContestView,
        CollectionView,
        CollectionInformationView,
        LuckyShopView,
        AuditionView,
        AuditionVoteView,
        AuditionRankingView,
        SelectNationView,
    }

    //화면에 보여지는 팝업 타입에 대한 enum - 해당 팝업 Prefab 이름과 매칭 시킬 것.
    public enum eUIPopupType
    {
        CommonNoticePopup,
        CommonSelectPopup,
        GameExitPopup,
        RechargeWealthPopup,
        RechargeSapphirePopup,
        WearSearchPopup,
        WearDetailInformationPopup,
        AllDecomposePopup,
        DecomposeConfirmPopup,
        WearGetPathPopup,
        ShopPurchaseAmountPopup,
        StageInformationPopup,
        GetWearInformationPopup,
        GetPossibleWearPopup,
        GachaPurchaseConfirmPopup,
        GachaResultPopup,
        JangHintPopup,
        SelectLanguagePopup,
    }

    //유저 정보 UI 노출 상태 enum
    public enum eUserInformationType
    {
        DEFAULT,
        SWITCH_BACKKEY,
        ONLY_BACKKEY,
        NOTHING,
    }

    //유저 재화 타입
    public enum eWealthType
    {
        HEART = 0,
        SAPPHIRE,
        SILVER,
    }

    //구입 재화 타입
    public enum eCurrencyType
    {
        SILVER = 0,
        SAPPHIRE,
    }

    //검색 타입
    public enum eWearSearchType
    {
        ATTRIBUTE,
        TAG,
        NAME,
        BRAND,
    }

    //드레스룸 카테고리 노출 타입
    public enum eDressroomCategoryShowType
    {
        FIRST_CATEGORY,
        SECOND_CATEGORY_SOCKS,
        SECOND_CATEGORY_DECO,
        THIRD_CATEGORY_HEAD,
        THIRD_CATEGORY_HAND,
        THIRD_CATEGORY_NECK,
        THIRD_CATEGORY_SPECIAL,
        THIRD_CATEGORY_PROPS,
        WEARLIST,
        SETLIST,
    }

    //옷장 첫번째 정렬 타입
    public enum eClosetFirstArrayType
    {
        HAVE,
        NOTHAVE,
        TOTAL,
    }

    //옷장 두번째 정렬 타입
    public enum eClosetSecondArrayType
    {
        ID,
        RARITY,
        GRADE,
    }

    //옷장 의상 상세 화면 노출 타입
    public enum eClosetWearInfoShowType
    {
        DEFAULT,
        DETAIL,
        BRAND,
    }

    //의상 종류 - 클라이언트 분류용.
    public enum eWearUICategory
    {
        NONE = 0,
        HAIR,
        OUTER,
        TOP,
        BOTTOM,
        ONEPIECE,
        SOCKS,
        SHOES,
        MAKEUP,
        DECO,
    }

    public enum eJourneyRankingShowType
    {
        SERVER_RANKING,
        FRIEND_RANKING,
    }

    public enum eCharacterEmotionType
    {
        Default = 1,
        SAD,
        ANGRY,
        DISREGARD,
    }

    public enum eAuditionParticipationType
    {
        NOT_PARTICIPATION = 0,
        PARTICIPATION,
    }

    public enum eAuditionRankingShowType
    {
        SERVER_RANKING,
        FRIEND_RANKING,
    }

    public enum eHintPopupShowType
    {
        STORY_HINT = 0,
        COMMON_HINT,
        S_HINT,
    }
    #endregion

    #region CommonData
    //여정평가등급
    public enum eJourneyResultGrade
    {
        S = 1,
        A,
        B,
        C,
        F,
    }

    //여정등급
    public enum eJourneyDifficult
    {
        GIRL = 1,
        GODDESS,
    }

    //의상희귀도
    public enum eWearRarity
    {
        COMMON = 1,
        RARE,
        SUPERRARE,
    }

    //브랜드
    public enum eBrandList
    {
        NONE = 0,
        BAEKOAKSOO,
        ENTREREVES,
        YOHANIX,
        VVV,
        MAG_AND_LOGAN,
        JAMIE_AND_BEL,
        EYEYE,
        KYE,
        PORSCHE,
    }

    //의상태그
    public enum eWearTag
    {
        NONE = 0,
        ETHNIC,
        DENIM,
        DRESS,
        SUNCARE,
    }

    //의상등급
    public enum eWearRank
    {
        ONE_STAR = 1,
        TWO_STAR,
        THREE_STAR,
        FOUR_STAR,
        FIVE_STAR,
        SIX_STAR,
    }

    //의상속성
    public enum eWearAttribute
    {
        GIRLISH = 1,
        MATURE,
        CASUAL,
        FORMAL,
        WARM,
        COOL,
        CUTE,
        SEXY,
        MANISH,
        FEMININE,
    }

    //의상 속성 랭크
    public enum eWearAttributeRank
    {
        SS = 1,
        S,
        A,
        B,
        C,
    }

    //의상 종류
    public enum eWearCategory
    {
        NONE = 0,
        HAIR,
        OUTER,
        TOP,
        BOTTOM,
        ONEPIECE,
        SOCKS_SOCKS,
        SOCKS_LEGS,
        SHOES,
        MAKEUP,
        DECO_HEAD_HEAD,
        DECO_HEAD_HAIRPIN,
        DECO_HAND_BRACELET_L,
        DECO_HAND_BRACELET_R,
        DECO_HAND_GLOVES,
        DECO_NECK_NECKLESS,
        DECO_SPECIAL_CHEST,
        DECO_PROP_PROP_L,
        DECO_PROP_PROP_R,
        DECO_WAIST,
        DECO_EAR,
    }

    //염료
    public enum eDyeType
    {
        RED_DYE = 1,
        ORANGE_DYE,
        YELLOW_DYE,
        GREEN_DYE,
        BLUE_DYE,
        NAVY_DYE,
        PURPLE_DYE,
        MAGICAL_DYE,
    }

    //의상 획득 경로
    public enum eWearGetPath
    {
        REFORM = 1,
        DESIGN_CREATE,
        PIECE_COMPOSE,
        SHOP,
        AUDITION_SHOP,
        CLUB_SHOP,
        CLUB_HANDCRAFT,
        SECRET_SHOP,
        PACKAGE_SHOP,
        CLUB_COLLABORATE,
        TEMPLE_OF_GIRL,
        ACHIEVEMENT,
        ATTENDANCE,
        VIP,
        STAGE,
        EVENT_STAGE,
    }

    //아이템 획득 경로
    public enum eItemGetPath
    {
        STYLINGACADEMY_SHOP = 1,
        CLUB_SHOP,
        PACKAGE_SHOP,
        CLUB_MISSION,
        CLUB_BATTLE,
        CLOSET,
        TEMPLE_OF_GIRL,
        ACHIEVEMENT,
        ATTENDANCE,
        VIP,
        STAGE,
        EVENT_STAGE,
    }

    //재료
    public enum eMaterial
    {
        CLOTH = 1,
        DYE,
    }

    //국가
    public enum eNation
    {
        NONE = 0,
        RABYRINTH,
        KOREA,
    }
    #endregion
}