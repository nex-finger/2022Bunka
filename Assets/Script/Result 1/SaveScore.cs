using NCMB; //mobile backendのSDKを読み込む
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// 【mBaaS】データの保存
public class SaveScore : MonoBehaviour {
	public static void save( string Name, int Score, float Time) {
		//　保存先のクラスを作成
		NCMBObject obj = new NCMBObject ("GameScore");
		//　データを代入
		obj ["name"] = Name;
		obj ["score"] = Score;
        obj ["time"] = Time;
		//　保存を行う
		obj.SaveAsync ((NCMBException e) => {
			if(e != null)
			{
				//　保存に失敗
				Debug.Log("保存に失敗しました。エラーコード：" + e.ErrorCode);
			}
			else
			{
				//　保存に成功
				Debug.Log("保存に成功しました。objectId:" + obj.ObjectId);
			}
		});
	}
}