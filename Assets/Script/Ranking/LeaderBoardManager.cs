using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using UnityEngine.UI;

public class LeaderBoardManager : MonoBehaviour
{
    private Text Ntext;
    private Text NtextT;
    private Text Ntext2;
    private Text Ntext2S;
    void Start () {

        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("GameScore");

         //timeフィールドの昇順でデータを取得
                    query.OrderByAscending ("time");

                    //検索件数を5件に設定
                    query.Limit = 5;


        query.FindAsync (async (List<NCMBObject> objList ,NCMBException e) => {
                if (e != null) {
                  UnityEngine.Debug.Log ("タイムランキング取得失敗");
                } else {
                    //検索成功時の処理
                    UnityEngine.Debug.Log ("タイムランキング取得成功");
                        //ログに表示
                        foreach (NCMBObject obj in objList) {
                            //int    s = System.Convert.ToInt32(obj["score"]);
					        string n = System.Convert.ToString(obj["name"]);
					        float  t = System.Convert.ToSingle(obj["time"]);
                            this.Ntext = GameObject.Find("NCMBName1").GetComponent<Text>(); 
                            Ntext.text += n +"\n"+"\n";
                            this.NtextT = GameObject.Find("NCMBTime").GetComponent<Text>(); 
                            NtextT.text += t + "\n"+"\n";
                    }
                }
                                
        });

        NCMBQuery<NCMBObject> query2 = new NCMBQuery<NCMBObject>("GameScore");

         //timeフィールドの昇順でデータを取得
                query2.OrderByDescending ("score");

                //検索件数を5件に設定
                query2.Limit = 5;


        query2.FindAsync (async (List<NCMBObject> objList ,NCMBException e) => {
                if (e != null) {
                  UnityEngine.Debug.Log ("タイムランキング取得失敗");
                } else {
                    //検索成功時の処理
                    UnityEngine.Debug.Log ("タイムランキング取得成功");
                        //ログに表示
                        foreach (NCMBObject obj in objList) {
                            int    s = System.Convert.ToInt32(obj["score"]);
					        string n = System.Convert.ToString(obj["name"]);
                            this.Ntext2 = GameObject.Find("NCMBName2").GetComponent<Text>(); 
                            Ntext2.text += n + "\n"+"\n";
                            this.Ntext2S = GameObject.Find("NCMBScore").GetComponent<Text>(); 
                            Ntext2S.text += s + "\n"+"\n";
                    }
                }
                                
        });
    }
}