using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_status : MonoBehaviour
{
    //device id 테이블
    public static string PS_deviceID;
    public static int PS_ID;

    //playerreference 테이블
    public static int PS_maxHp;
    public static int PS_hp;
    public static int PS_maxBomb;
    public static int PS_bomb;
    public static int PS_blitz;
    public static int PS_bulletLevel;
    public static int PS_score;
    public static int PS_stage;
    public static int PS_sp;
    public static int PS_maxsp;
    public static int PS_instanceDrone;
    public static int PS_drone;
    public static int PS_easyMode;
    public static int combo = 0;
    public static string PS_name;

    //DB에서 사용안함
    public static bool isDead;
    private static MySqlConnector DB;
    public static int slotNow;

    public Player_status()
    {
        Debug.Log("생성");
    }

    //db체크, 멤버변수 초기화, 기기정보 확인
    public void Awake()
    {
        this.DBConnectCheck();
        DB.firstmysql();
        Debug.Log("현재 난이도:" + PS_easyMode);
        GetID();
        DBDeviceFirst();
    }

    //db연결되는지 확인함
    public void DBConnectCheck()
    {
        this.gameObject.AddComponent<MySqlConnector>(); //생성자가 연결해봄
        DB = this.GetComponent<MySqlConnector>();   //앵커
        DB.closeSqlConnection();    //닫기
    }

    //디바이스 정보 insert 최초로 게임 실행시 실행
    public static void DBDeviceFirst()
    {
        //최초 추가여부확인 메소드 필요
        if (DB.DeviceisSave())
        {
            DB.DeviceInsertDB();
        }
    }

    //insert playerreference 게임스타트에서 빈슬롯 클릭시
    public static bool DBSavePreference(int slot)
    {
        DB.setPlayerToMysql();
        return DB.PreferenceInsertDB(toString(), slot);
    }

    //insert playerreference 게임스타트에서 존재하는슬롯 클릭시
    public static void DBSavePreference()
    {
        DB.setPlayerToMysql();
        DB.PreferenceOverwriteDB(toString(), slotNow);
    }

    //update playerreference
    public static void DBUpdate()
    {
        DB.UpdateDB(toUpdate());
    }

    //default값으로 playerstatus 적용
    public static void DBSetUser()
    {
        DB.setPlayerToMysql();
    }

    //db종료
    public static void DBDisConnect()
    {
        DB.closeSqlConnection();
    }

    //닉네임 기반으로 데이터로드
    public static void DBLoadPreference()
    {
        DB.LoadPreference();
    }

    //슬롯 눌렀을때 닉네임 기반으로 데이터 로드
    public static void DBLoadPreference(string txt)
    {
        DB.LoadPreference(txt);
    }

    //기기id 기반으로 데이터슬롯개수 로드
    public static string DBLoadPlayerSlot()
    {
        return DB.LoadPlayerSlot();
    }

    //기기id 기반으로 데이터슬롯받고 PlayerReference id 기반으로 내용 로드
    public static string[] DBLoadPlayerSlotDB(int id)
    {

        return DB.LoadPlayerSlotDB(id);
    }

    //게임오버되거나 클리어시 호출
    public static void DBEndGame()
    {
        DB.InsertScore();
        DB.DeletePlayer();
    }

    //achivement 누를시 호출
    public static string DBReadScore()
    {
        return DB.ReadScore();
    }

    //인설트 쿼리문
    public static string toString()
    {
        return "Insert into PlayerReference(maxhp,hp,maxbomb,bomb,blitz,bulletlevel,score,stage,sp,maxsp,instanceDrone,drone,easymode,nickname) " +
            "VALUES(" + PS_maxHp
            + ", " + PS_hp
            + ", " + PS_maxBomb
            + ", " + PS_bomb
            + ", " + PS_blitz
            + ", " + PS_bulletLevel
            + ", " + PS_score
            + ", " + PS_stage
            + ", " + PS_sp
            + ", " + PS_maxsp
            + ", " + PS_instanceDrone
            + ", " + PS_drone
            + ", " + PS_easyMode
            + ", '" + PS_name + "');";
    }

    //업데이트 쿼리문
    public static string toUpdate()
    {
        return "UPDATE PlayerReference " +
            "SET " +
            "maxhp = " + PS_maxHp +
            ", hp = " + PS_hp +
            ", maxbomb = " + PS_maxBomb +
            ", bomb = " + PS_bomb +
            ", blitz = " + PS_blitz +
            ", bulletlevel = " + PS_bulletLevel +
            ", score = " + PS_score +
            ", stage = " + PS_stage +
            ", sp = " + PS_sp +
            ", maxsp = " + PS_maxsp +
            ", instanceDrone = " + PS_instanceDrone +
            ", drone = " + PS_drone +
            ", easymode = " + PS_easyMode +
            " WHERE nickname = '" + PS_name + "';";
    }

    //기기정보 받아오기
    public static void GetID()
    {
        Player_status.PS_deviceID = SystemInfo.deviceUniqueIdentifier;
        Debug.Log("현재디바이스 = " + SystemInfo.deviceUniqueIdentifier);
    }
}
