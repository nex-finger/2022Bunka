using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using UnityEngine.UI;

public class LeaderBoardManager : MonoBehaviour
{
    private Text Ntext;
    void Start () {

        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("GameScore");

         //timeフィールドの昇順でデータを取得
                    query.OrderByAscending ("time");

                    //検索件数を5件に設定
                    query.Limit = 5;


        query.FindAsync (async (List<NCMBObject> objList ,NCMBException e) => {
                if (e != null) {
                  UnityEngine.Debug.Log ("ランキング取得失敗");
                } else {
                    //検索成功時の処理
                    UnityEngine.Debug.Log ("ランキング取得成功");
                        //ログに表示
                        foreach (NCMBObject obj in objList) {
                            int    s = System.Convert.ToInt32(obj["score"]);
					        string n = System.Convert.ToString(obj["name"]);
					        float  t = System.Convert.ToSingle(obj["time"]);
                            this.Ntext = GameObject.Find("NCMBText").GetComponent<Text>(); 
                            Ntext.text +=  "名前" + n + "：スコア：" + s + "：タイム：" + t + "\n";
                    }
                }
                                
        });
    }
}