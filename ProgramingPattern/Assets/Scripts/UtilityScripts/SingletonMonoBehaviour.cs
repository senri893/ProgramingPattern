using UnityEngine;
using System;

/// <summary>
/// シングルトンの親クラス　[継承して使うためオブジェクトにアタッチできない]
/// </summary>
/// <typeparam name="T">テンプレート(ジェネリック型)</typeparam>　//abstractは継承クラスの宣言　必ず継承して使うためnewなどができない
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour　//Tはテンプレート(ジェネリック型)　ここではMonoBehaviourをテンプレートの条件として指定し継承
{
    //シングルトンの中身を保持する変数
    private static T instance;　//staticはクラス依存でクラス.メソッド名で呼びさせる　staticでないものはインスタンス依存(変数で呼び出し)

    //シングルトンにアクセスするためのpublic変数
    public static T Instance 
    {
        //中身がnullかどうかの確認　(getはプロパティを読み取るときに呼び出される関数)
        get
        {
            //instanceがなかったら処理
            if(instance == null)
            {
                //一番初めに見つけたオブジェクトをtype型にキャストしている typeofはキャスト
                Type t = typeof(T);

                //キャストしたオブジェクトを検索して最初に発見した者だけをinstanceに格納
                instance = (T)FindFirstObjectByType(t);

                //検索出来なかった場合はシングルトンがアタッチされたオブジェクトがないためエラーを表示
                if(instance ==null)
                {
                    Debug.LogError(t + "をアタッチしているGameObjectはありません");
                }
            }

            //instanceをInstanceに返す
            return instance;
        }    //{get; private set;}にすると参照だけ出来、内容の変更は宣言したクラス内以外では不可能
    }

    /// <summary>
    /// ゲーム開始時に一番最初に呼び出される仮想メソッド
    /// </summary>
    virtual protected void Awake()
    {
        //他のゲームオブジェクトにアタッチされているか調べる
        //アタッチされている場合は破棄する
        CheckInstnace();
    }

    /// <summary>
    /// 他にシングルトンがアタッチされていないかチェックする継承先のみが呼び出せるメソッド
    /// </summary>
    /// <returns></returns>
    protected bool CheckInstnace()
    {
        //instanceがnullならば自身のクラスをジェネリック型にキャストして代入しtrueを返す
        if(instance == null)
        {
            instance = this as T;　//asキャスト(失敗したらnullを入れる)　thisは自身のインスタンス
            return true;
        }
        else if(Instance == null)　//Instanceがnullならばnullであることを通知するためtrueを返す
        {
            return true;
        }
        //最初に存在しているシングルトンのみを使うため他にシングルトンが存在しているなら破棄
        Destroy(this);//コンポーネントだけ破棄
        return false;
    }

}
