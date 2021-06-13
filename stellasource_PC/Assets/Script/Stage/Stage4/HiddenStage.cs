using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenStage : MonoBehaviour
{
    // Start is called before the first frame update
    //스테이지별로 메인카메라에 달것
    public int stageHiddenTimecheck = 0;
    //적기체 프리팹 달아주기


    //생성용 스크립트 달아주기
    public EnemySpawnHidden create;
    bool start = true;
    public int phase = 1;

    void Update()
    {
        stageHiddenTimecheck++;
        //조건이 되는 정수는 frame 이 frame이상으로 timecheck가 증가하면 보스 출현
        if (start)
        {
            if (stageHiddenTimecheck == 10)
            {
                create.PrintEnemy(7, 0);
                start = false;
            }
        }
            switch (phase)
            {
                case 2:
                if (stageHiddenTimecheck == 100)
                {
                    create.PrintEnemy(7, 1);
                    stageHiddenTimecheck = 0;
                    phase = 3;
                }
                    break;
                case 4:
                if (stageHiddenTimecheck == 100)
                {
                    create.PrintEnemy(7, 2);
                    stageHiddenTimecheck = 0;
                    phase = 5;

                }
                break;
            case 6:
                if (stageHiddenTimecheck == 100)
                {
                    create.PrintEnemy(7, 3);
                    stageHiddenTimecheck = 0;
                    phase = 7;

                }
                break;

            case 8:
                if (stageHiddenTimecheck == 100)
                {
                    create.PrintEnemy(7, 4);
                    stageHiddenTimecheck = 0;
                    phase = 5;

                }
                break;

        }
           
        


    }
}
