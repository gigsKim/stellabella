using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;
using UnityEngine.UI;
using System;

public class MySqlConnector : MonoBehaviour
{

    private MySqlConnection dbConnection;
    private MySqlConnector instance = null;
    private MySqlCommand command = null;
    private MySqlDataReader reader = null;
    public MySqlConnector Instance
    {
        get
        {
            if (instance == null)
            {
                lock (typeof(MySqlConnector))
                {
                    if (instance == null)
                    {
                        instance = new MySqlConnector();
                    }
                }
            }
            return instance;
        }
    }


    //외부에서 닫아줌
    public MySqlConnector()
    {
        openSqlConnection();
    }

    // Connect to database 사용후 무조건 닫아주기!
    public void openSqlConnection()
    {
        string sqlDBip = "118.67.134.106";
        string sqlDBname = "sys";
        string sqlDBid = "root";
        string sqlDBpw = "!@66Rjqofk";
        string sqlDatabase = "Server=" + sqlDBip + ";Database=" + sqlDBname + ";UserId=" + sqlDBid + ";Password=" + sqlDBpw + ";";

        try
        {
            dbConnection = new MySqlConnection(sqlDatabase);
            dbConnection.Open();
            Debug.Log("Connected to database.");
        }
        catch (Exception msg)
        {

            Debug.Log(msg); //기타다른오류가 나타나면 오류에 대한 내용이 나타남
        }

    }

    // Disconnect from database
    public void closeSqlConnection()
    {
        dbConnection.Close();
        dbConnection = null;
        Debug.Log("Disconnected from database.");
    }


    public void firstmysql()
    {
        openSqlConnection();
        try
        {
            command = new MySqlCommand("SELECT * FROM PlayerReference WHERE nickname = 'setplayer';", dbConnection);
            reader = command.ExecuteReader();

            string temp = string.Empty;
            string[] status = new string[13];
            if (reader == null)
            {
                temp = "No return";
            }
            else
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (i != reader.FieldCount - 1)
                        {
                            temp += reader[i] + ";";
                        }
                        else if (i == reader.FieldCount - 1)    //마지막인덱스
                        {
                            temp += reader[i] + "/n";
                        }
                    }
                }
                Debug.Log(temp);
                status = temp.Split(';');
                Player_status.PS_maxHp = Convert.ToInt32(status[0]);
                Player_status.PS_hp = Convert.ToInt32(status[1]);
                Player_status.PS_maxBomb = Convert.ToInt32(status[2]);
                Player_status.PS_bomb = Convert.ToInt32(status[3]);
                Player_status.PS_blitz = Convert.ToInt32(status[4]);
                Player_status.PS_bulletLevel = Convert.ToInt32(status[5]);
                Player_status.PS_score = Convert.ToInt32(status[6]);
                Player_status.PS_stage = Convert.ToInt32(status[7]);
                Player_status.PS_sp = Convert.ToInt32(status[8]);
                Player_status.PS_maxsp = Convert.ToInt32(status[9]);
                Player_status.PS_instanceDrone = Convert.ToInt32(status[10]);
                Player_status.PS_drone = Convert.ToInt32(status[11]);
                Player_status.PS_easyMode = Convert.ToInt32(status[12]);

                Debug.Log("" + Player_status.PS_maxHp +
                Player_status.PS_hp +
                Player_status.PS_maxBomb +
                Player_status.PS_bomb +
                Player_status.PS_blitz +
                Player_status.PS_bulletLevel +
                Player_status.PS_score +
                Player_status.PS_stage +
                Player_status.PS_sp +
                Player_status.PS_maxsp +
                Player_status.PS_instanceDrone +
                Player_status.PS_drone +
                Player_status.PS_easyMode);

            }
        }
        catch (Exception msg)
        {
            Debug.Log(msg);
        }
        finally
        {
            reader.Close();
            command = null;
            reader = null;
            closeSqlConnection();
        }
    }
    //맨처음 player_status에 넣을 default값
    public void setPlayerToMysql()
    {
        openSqlConnection();
        try
        {
            if (Player_status.PS_easyMode == 1)
            {

                command = new MySqlCommand("SELECT * FROM PlayerReference WHERE nickname = 'setplayer';", dbConnection);
                reader = command.ExecuteReader();

                string temp = string.Empty;
                string[] status = new string[13];
                if (reader == null)
                {
                    temp = "No return";
                }
                else
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (i != reader.FieldCount - 1)
                            {
                                temp += reader[i] + ";";
                            }
                            else if (i == reader.FieldCount - 1)    //마지막인덱스
                            {
                                temp += reader[i] + "/n";
                            }
                        }
                    }
                    Debug.Log(temp);
                    status = temp.Split(';');
                    Player_status.PS_maxHp = Convert.ToInt32(status[0]);
                    Player_status.PS_hp = Convert.ToInt32(status[1]);
                    Player_status.PS_maxBomb = Convert.ToInt32(status[2]);
                    Player_status.PS_bomb = Convert.ToInt32(status[3]);
                    Player_status.PS_blitz = Convert.ToInt32(status[4]);
                    Player_status.PS_bulletLevel = Convert.ToInt32(status[5]);
                    Player_status.PS_score = Convert.ToInt32(status[6]);
                    Player_status.PS_stage = Convert.ToInt32(status[7]);
                    Player_status.PS_sp = Convert.ToInt32(status[8]);
                    Player_status.PS_maxsp = Convert.ToInt32(status[9]);
                    Player_status.PS_instanceDrone = Convert.ToInt32(status[10]);
                    Player_status.PS_drone = Convert.ToInt32(status[11]);
                    Player_status.PS_easyMode = Convert.ToInt32(status[12]);

                    Debug.Log("" + Player_status.PS_maxHp +
                    Player_status.PS_hp +
                    Player_status.PS_maxBomb +
                    Player_status.PS_bomb +
                    Player_status.PS_blitz +
                    Player_status.PS_bulletLevel +
                    Player_status.PS_score +
                    Player_status.PS_stage +
                    Player_status.PS_sp +
                    Player_status.PS_maxsp +
                    Player_status.PS_instanceDrone +
                    Player_status.PS_drone +
                    Player_status.PS_easyMode);

                }
            }
            else if (Player_status.PS_easyMode == 0)
            {

                command = new MySqlCommand("SELECT * FROM PlayerReference WHERE nickname = 'hardplayer';", dbConnection);
                reader = command.ExecuteReader();

                string temp = string.Empty;
                string[] status = new string[13];
                if (reader == null)
                {
                    temp = "No return";
                }
                else
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (i != reader.FieldCount - 1)
                            {
                                temp += reader[i] + ";";
                            }
                            else if (i == reader.FieldCount - 1)    //마지막인덱스
                            {
                                temp += reader[i] + "/n";
                            }
                        }
                    }
                    Debug.Log(temp);
                    status = temp.Split(';');
                    Player_status.PS_maxHp = Convert.ToInt32(status[0]);
                    Player_status.PS_hp = Convert.ToInt32(status[1]);
                    Player_status.PS_maxBomb = Convert.ToInt32(status[2]);
                    Player_status.PS_bomb = Convert.ToInt32(status[3]);
                    Player_status.PS_blitz = Convert.ToInt32(status[4]);
                    Player_status.PS_bulletLevel = Convert.ToInt32(status[5]);
                    Player_status.PS_score = Convert.ToInt32(status[6]);
                    Player_status.PS_stage = Convert.ToInt32(status[7]);
                    Player_status.PS_sp = Convert.ToInt32(status[8]);
                    Player_status.PS_maxsp = Convert.ToInt32(status[9]);
                    Player_status.PS_instanceDrone = Convert.ToInt32(status[10]);
                    Player_status.PS_drone = Convert.ToInt32(status[11]);
                    Player_status.PS_easyMode = Convert.ToInt32(status[12]);

                    Debug.Log("하드모드 생성" + Player_status.PS_maxHp +
                    Player_status.PS_hp +
                    Player_status.PS_maxBomb +
                    Player_status.PS_bomb +
                    Player_status.PS_blitz +
                    Player_status.PS_bulletLevel +
                    Player_status.PS_score +
                    Player_status.PS_stage +
                    Player_status.PS_sp +
                    Player_status.PS_maxsp +
                    Player_status.PS_instanceDrone +
                    Player_status.PS_drone +
                    Player_status.PS_easyMode);

                }

            }

        }
        catch (Exception msg)
        {
            Debug.Log(msg);
        }
        finally
        {
            reader.Close();
            command = null;
            reader = null;
            closeSqlConnection();
        }


    }

    //최초 GameStart에서 클릭시 조건문 조건에 사용 빈슬롯이면 삽입
    public bool PreferenceInsertDB(string query, int slotIndex)
    {
        openSqlConnection();
        try
        {
            //기기정보 컬럼의 slot 조회
            command = new MySqlCommand("SELECT slot" + slotIndex + " FROM deviceid WHERE deviceid='" + Player_status.PS_deviceID + "';", dbConnection);
            reader = command.ExecuteReader();


            while (reader.Read())
            {
                Debug.Log(reader[0] + "끼에에에엥에에에엑" + Player_status.PS_ID);
            }

            //비어있는 슬롯 선택시 선택한 슬롯에 update id
            if (Convert.ToInt32(reader[0]) == 0)
            {
                Debug.Log(slotIndex + "슬롯 비어있음!!!!!!!!!!");
                reader.Close();

                //닉네임과 난이도 받아서 레퍼런스 컬럼 만듬(Insert)
                command = new MySqlCommand(query, dbConnection);
                command.ExecuteNonQuery();
                command = null;

                //만든 컬럼의 id 조회 후 담아둠
                command = new MySqlCommand("SELECT id FROM PlayerReference WHERE nickname = '" + Player_status.PS_name + "';", dbConnection);
                MySqlDataReader reader1 = command.ExecuteReader();
                if (reader1 != null)
                {
                    while (reader1.Read())
                    {
                        Player_status.PS_ID = Convert.ToInt32(reader1[0]);
                    }
                    Debug.Log("현재 게임중인 ID = " + Player_status.PS_ID);
                }
                else
                {
                    Debug.Log("치명적 에러-PreferenceInsertDB");
                    return false;
                }
                reader1.Close();

                //업데이트
                command = null;
                command = new MySqlCommand("UPDATE deviceid SET slot" + slotIndex + " = " + Player_status.PS_ID + " WHERE deviceid = '" + Player_status.PS_deviceID + "';", dbConnection);
                command.ExecuteNonQuery();
                Debug.Log(Player_status.PS_ID + "새 슬롯에 저장완료!");
                return true;
            }
            else //컬럼이 안비어있으면 false반환 
            {/*
                command = null;
                reader = null;
                command = new MySqlCommand("DELETE from PlayerReference where id=" + id, dbConnection);
                reader = command.ExecuteReader();*/
                return false;
            }

        }
        catch (Exception msg)
        {
            Debug.Log(msg);
            return false;
        }
        finally
        {
            Debug.Log(query);
            command = null;
            reader = null;
            closeSqlConnection();
        }
    }

    //최초 GameStart에서 있는슬롯 클릭시 기존꺼 지우고 새로Update
    public void PreferenceOverwriteDB(string query, int slotIndex)
    {
        openSqlConnection();
        try
        {
            //ex slotIndex==1) slot1컬럼을 찾아서 밸류 비교 후 0이아니면 delete 시키고 새로만든값 넣는다.
            command = new MySqlCommand("SELECT slot" + slotIndex + " FROM deviceid WHERE deviceid ='" + Player_status.PS_deviceID + "';", dbConnection);
            reader = command.ExecuteReader();

            int idx = 0;
            while (reader.Read())
            {
                idx = (int)reader[0];
                Debug.Log("PreferenceOverwriteDB : 지워지는 playerreference id = " + idx);
            }

            reader.Close();
            reader = null;

            if (idx != 0)
            {
                command = null;
                command = new MySqlCommand("DELETE from PlayerReference where id = " + idx + ";", dbConnection);
                command.ExecuteNonQuery();

                //닉네임과 난이도 받아서 레퍼런스 컬럼 만듬(Insert)
                command = null;
                command = new MySqlCommand(query, dbConnection);
                command.ExecuteNonQuery();

                //만든 컬럼의 id 조회 후 담아둠
                command = null;
                command = new MySqlCommand("SELECT id FROM PlayerReference WHERE nickname = '" + Player_status.PS_name + "';", dbConnection);
                MySqlDataReader reader1 = command.ExecuteReader();
                while (reader1.Read())
                {
                    if (reader1 != null)
                    {
                        Player_status.PS_ID = Convert.ToInt32(reader1[0]);
                    }
                    else
                    {
                        Debug.Log("치명적 에러-PreferenceOverwriteDB");
                    }
                }
                reader1.Close();
                reader1 = null;

                //업데이트
                command = null;
                command = new MySqlCommand("UPDATE deviceid SET slot" + slotIndex + " = " + Player_status.PS_ID + " WHERE deviceid = '" + Player_status.PS_deviceID + "';", dbConnection);
                command.ExecuteNonQuery();
                Debug.Log(Player_status.PS_ID + "를 기존 슬롯에 저장완료!");
            }
        }
        catch (Exception msg)
        {
            Debug.Log(msg);
        }
        finally
        {
            command = null;
            closeSqlConnection();
        }
    }

    //기기저장 여부를 확인하는 메소드, 저장해야한다면 true반환
    public bool DeviceisSave()
    {
        openSqlConnection();
        try
        {
            command = new MySqlCommand("SELECT deviceid FROM deviceid WHERE deviceid='" + Player_status.PS_deviceID + "';", dbConnection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                Debug.Log("저장된 디바이스 있음..!!");
                return false;
            }
            else
            {
                Debug.Log("저장된 디바이스 없음..!!");
                return true;
            }
        }
        catch (Exception msg)
        {
            Debug.Log(msg);
            Debug.Log("저장오류 - DeviceisSave");
            return false;
        }
        finally
        {
            reader.Close();
            command = null;
            reader = null;
            closeSqlConnection();
        }
    }

    //맨처음 기기저장 게임시작시 메소드호출됨 (insert구문)
    public void DeviceInsertDB()
    {
        openSqlConnection();

        try
        {
            //기기정보 컬럼 만듬
            command = new MySqlCommand("INSERT INTO deviceid (deviceid) Values('" + Player_status.PS_deviceID + "');", dbConnection);
            command.ExecuteNonQuery();
            Debug.Log("DeviceInsertDB() - 성공");
        }
        catch (Exception msg)
        {
            Debug.Log(msg);
        }
        finally
        {
            command = null;
            closeSqlConnection();
        }

    }

    //Garage에서 저장시 호출됨 플레이어 레퍼런스 Update구문
    public void UpdateDB(string updateQuery)
    {
        openSqlConnection();
        try
        {
            command = new MySqlCommand("SET SQL_SAFE_UPDATES = 0;", dbConnection);
            command.ExecuteNonQuery();
            command = null;

            command = new MySqlCommand(updateQuery, dbConnection);
            command.ExecuteNonQuery();
        }
        catch (Exception msg)
        {
            Debug.Log(msg);
        }
        finally
        {
            command = null;
            Debug.Log("UpdateDB() - 성공" + updateQuery);
            closeSqlConnection();
        }

    }

    //스테이지도중 Garage 버튼 클릭시 & 사망시
    public void LoadPreference()
    {
        openSqlConnection();
        try
        {
            command = new MySqlCommand("SELECT * FROM PlayerReference WHERE nickname='" + Player_status.PS_name + "';", dbConnection);
            reader = command.ExecuteReader();

            string temp = string.Empty;
            string[] status = new string[13];
            if (reader == null)
            {
                temp = "No return";
            }
            else
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (i != reader.FieldCount - 1)
                        {
                            temp += reader[i] + ";";
                        }
                        else if (i == reader.FieldCount - 1)
                        {
                            temp += reader[i] + "/n";
                        }
                    }
                }
                status = temp.Split(';');
                Player_status.PS_maxHp = Convert.ToInt32(status[0]);
                Player_status.PS_hp = Convert.ToInt32(status[1]);
                Player_status.PS_maxBomb = Convert.ToInt32(status[2]);
                Player_status.PS_bomb = Convert.ToInt32(status[3]);
                Player_status.PS_blitz = Convert.ToInt32(status[4]);
                Player_status.PS_bulletLevel = Convert.ToInt32(status[5]);
                Player_status.PS_score = Convert.ToInt32(status[6]);
                Player_status.PS_stage = Convert.ToInt32(status[7]);
                Player_status.PS_sp = Convert.ToInt32(status[8]);
                Player_status.PS_maxsp = Convert.ToInt32(status[9]);
                Player_status.PS_instanceDrone = Convert.ToInt32(status[10]);
                Player_status.PS_drone = Convert.ToInt32(status[11]);
                Player_status.PS_easyMode = Convert.ToInt32(status[12]);

                Debug.Log("LoadPreference() - 성공" + Player_status.PS_maxHp +
                Player_status.PS_hp +
                Player_status.PS_maxBomb +
                Player_status.PS_bomb +
                Player_status.PS_blitz +
                Player_status.PS_bulletLevel +
                Player_status.PS_score +
                Player_status.PS_stage +
                Player_status.PS_sp +
                Player_status.PS_maxsp +
                Player_status.PS_instanceDrone +
                Player_status.PS_drone +
                Player_status.PS_easyMode);

            }


        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
        finally
        {
            reader.Close();
            command = null;
            reader = null;
            closeSqlConnection();
        }

    }

    //Title 씬에서 Load 클릭 후 슬롯 클릭시 & start에서 있는슬롯 클릭시
    public void LoadPreference(string txt)
    {
        openSqlConnection();
        try
        {
            command = new MySqlCommand("SELECT * FROM PlayerReference WHERE nickname='" + txt + "';", dbConnection);
            reader = command.ExecuteReader();

            string temp = string.Empty;
            string[] status = new string[16];
            if (reader == null)
            {
                temp = "No return";
            }
            else
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (i != reader.FieldCount - 1)
                        {
                            temp += reader[i] + ";";
                        }
                        else if (i == reader.FieldCount - 1)
                        {
                            temp += reader[i] + "";
                        }
                    }
                }
                status = temp.Split(';');
                Player_status.PS_maxHp = Convert.ToInt32(status[0]);
                Player_status.PS_hp = Convert.ToInt32(status[1]);
                Player_status.PS_maxBomb = Convert.ToInt32(status[2]);
                Player_status.PS_bomb = Convert.ToInt32(status[3]);
                Player_status.PS_blitz = Convert.ToInt32(status[4]);
                Player_status.PS_bulletLevel = Convert.ToInt32(status[5]);
                Player_status.PS_score = Convert.ToInt32(status[6]);
                Player_status.PS_stage = Convert.ToInt32(status[7]);
                Player_status.PS_sp = Convert.ToInt32(status[8]);
                Player_status.PS_maxsp = Convert.ToInt32(status[9]);
                Player_status.PS_instanceDrone = Convert.ToInt32(status[10]);
                Player_status.PS_drone = Convert.ToInt32(status[11]);
                Player_status.PS_easyMode = Convert.ToInt32(status[12]);
                Player_status.PS_name = Convert.ToString(status[13]);
                Player_status.PS_ID = Convert.ToInt32(status[14]);

                Debug.Log("LoadPreference(nickname) - 성공" + Player_status.PS_maxHp +
                Player_status.PS_hp +
                Player_status.PS_maxBomb +
                Player_status.PS_bomb +
                Player_status.PS_blitz +
                Player_status.PS_bulletLevel +
                Player_status.PS_score +
                Player_status.PS_stage +
                Player_status.PS_sp +
                Player_status.PS_maxsp +
                Player_status.PS_instanceDrone +
                Player_status.PS_drone +
                Player_status.PS_easyMode +
                Player_status.PS_name);

            }


        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
        finally
        {
            reader.Close();
            command = null;
            reader = null;
            closeSqlConnection();
        }

    }

    //플레이어슬롯 로드
    public string LoadPlayerSlot()
    {
        openSqlConnection();
        try
        {
            command = new MySqlCommand("SELECT * FROM deviceid WHERE deviceid ='" + Player_status.PS_deviceID + "';", dbConnection);
            /*command = new MySqlCommand("SELECT * FROM deviceid WHERE deviceid ='ASDAASD';", dbConnection);  //테스트용*/
            reader = command.ExecuteReader();

            string temp = string.Empty;
            if (reader.HasRows)
            {
                reader.Read();
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    temp += reader.GetString(i) + ";";
                }
            }
            Debug.Log("LoadPlayerSlot() - 성공");
            return temp;
        }
        catch (Exception msg)
        {
            Debug.Log(msg);
            return null;
        }
        finally
        {
            reader.Close();
            command = null;
            reader = null;
            closeSqlConnection();
        }

    }

    //플레이어 슬롯별 값
    public string[] LoadPlayerSlotDB(int id)
    {
        openSqlConnection();
        try
        {
            //디바이스아이디 받아와서 select로 playerreference받아서
            command = new MySqlCommand("SELECT * FROM PlayerReference WHERE id ='" + id + "';", dbConnection);
            reader = command.ExecuteReader();

            string temp = string.Empty;
            string[] status = new string[14];
            string[] forSlot = new string[3];
            if (reader == null)
            {
                temp = "No return";
            }
            else
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (i != reader.FieldCount - 1)
                        {
                            temp += reader[i] + ";";
                        }
                        else if (i == reader.FieldCount - 1)
                        {
                            temp += reader[i] + "/n";
                        }
                    }
                }
                Debug.Log("LoadPlayerSlotDB(id) - 성공" + temp);
                status = temp.Split(';');
                forSlot[0] = Convert.ToString(status[13]);
                forSlot[1] = Convert.ToInt32(status[7]) + "";
                forSlot[2] = Convert.ToInt32(status[6]) + "";
            }

            return forSlot;
        }
        catch (Exception e)
        {
            Debug.Log(e);
            return null;
        }
        finally
        {
            reader.Close();
            command = null;
            reader = null;
            closeSqlConnection();
        }

    }

    //디바이스아이디에 저장된 id 날리고 playerReference 정보 delete
    public void DeletePlayer()
    {
        openSqlConnection();
        try
        {
            command = new MySqlCommand("UPDATE deviceid " +
                "SET " +
                "slot1 = CASE slot1 WHEN " + Player_status.PS_ID + " THEN 0 ELSE slot1 END," +
                "slot2 = CASE slot2 WHEN " + Player_status.PS_ID + " THEN 0 ELSE slot2 END," +
                "slot3 = CASE slot3 WHEN " + Player_status.PS_ID + " THEN 0 ELSE slot3 END " +
                "WHERE deviceid = '" + Player_status.PS_deviceID +
                "';", dbConnection);
            command.ExecuteNonQuery();
            command = null;

            command = new MySqlCommand("delete from PlayerReference where id =" + Player_status.PS_ID + ";", dbConnection);
            int hang = command.ExecuteNonQuery();
            Debug.Log("DeletePlayer() - 성공, 아이디 제거 영향을 받은 행 수 = " + hang);
        }
        catch (Exception msg)
        {
            Debug.Log(msg);
        }
        finally
        {
            command = null;
            closeSqlConnection();
        }
    }

    //게임오버가 되거나 클리어시 점수저장
    public void InsertScore()
    {
        openSqlConnection();
        try
        {
            command = new MySqlCommand("insert into ScoreBoard(nickname,score) values('" + Player_status.PS_name + "', " + Player_status.PS_score + "); ; ", dbConnection);
            command.ExecuteNonQuery();
            Debug.Log("InsertScore() - 성공");
        }
        catch (Exception msg)
        {
            Debug.Log(msg);
        }
        finally
        {
            command = null;
            closeSqlConnection();
        }
    }

    //스코어 읽어오기
    public string ReadScore()
    {
        openSqlConnection();
        try
        {
            command = new MySqlCommand("SELECT * FROM ScoreBoard order by score desc; ", dbConnection);
            reader = command.ExecuteReader();

            string temp = string.Empty;
            if (reader == null)
            {
                temp = "No return";
                return null;
            }
            else
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (i != reader.FieldCount - 1)
                        {
                            temp += reader[i] + ";";
                        }
                        else if (i == reader.FieldCount - 1)
                        {
                            temp += reader[i] + ";";
                        }
                    }
                }
                Debug.Log("ReadScore() - 성공" + temp);
                return temp;
            }

        }
        catch (Exception msg)
        {
            Debug.Log(msg);
            return null;
        }
        finally
        {
            closeSqlConnection();
        }
    }
    /* 기본 쿼리작성양식
     openSqlConnection();
        try
        {

        }
        catch (Exception msg)
        {
            Debug.Log(msg);
        }
        finally
        {
            closeSqlConnection();
        }
     */
}
