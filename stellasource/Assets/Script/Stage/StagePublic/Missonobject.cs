using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missonobject : MonoBehaviour
{
    public Stage_misson st;//스테이지 미션에서 카운터를 올리기위해 받아옴
                           //사용방법 : 이 스크립트를 미션 오브젝트가 될 에네미들 에게 집어넣고 메인카메라엔 스테이지 미션을 넣으면 됨

    private void OnDisable()
    {
        if (this.gameObject.GetComponent<Enemy_normal_status>().life <= 0)
        {
            st = GameObject.Find("MainCamera").GetComponent<Stage_misson>();//스테이지에 저장된 것을 가져온다.


            string[] name = gameObject.name.Split(' ');
            

            if (name[0] == st.missionname1)
            {
                st.object1count++;
            }
            if (name[0] == st.missionname2)
            {
                st.object2count++;
            }
            if (name[0] == st.missionname3)
            {
                st.object3count++;
            }

        }
    }
}
