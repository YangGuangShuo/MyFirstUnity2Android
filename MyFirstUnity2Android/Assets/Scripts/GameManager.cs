using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Text_ShowMessage;

    /// <summary>
    /// 外部按钮调用
    /// </summary>
    public void SendMessageToAndroid()
    {
        AndroidJavaClass javaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject javaObject = javaClass.GetStatic<AndroidJavaObject>("currentActivity");
        //此处"ReceiveMessageFromUnity"必须与AndroidStudio项目中的方法名字一致
        javaObject.Call("ReceiveMessageFromUnity", "这是一个从Unity发送的消息内容!");
    }
    /// <summary>
    /// 接收Android返回的消息方法，必须与AndroidStudio项目中的名字一致
    /// </summary>
    /// <param name="message"></param>
    public void GetMessageFromAndroid(string message)
    {
        Text_ShowMessage.text = message;
    }
}
