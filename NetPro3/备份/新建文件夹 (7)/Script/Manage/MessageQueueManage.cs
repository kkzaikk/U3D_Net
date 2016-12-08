using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MessageQueueManage 
{
    private static MessageQueueManage s_queueManage = null;
    public static MessageQueueManage getInstance()
    {
        if (s_queueManage == null)
        {
            s_queueManage = new MessageQueueManage();
        }
        return s_queueManage;
    }


    //收到的协议队列
    private Queue<MessageStruct> recDataQueue = new Queue<MessageStruct>();
    //场景上频繁收到的协议处理，避免阻塞其它协议数据的读取
    private Queue<MessageStruct> recDataScene = new Queue<MessageStruct>();
    //将要发送的协议数据
    private List<MessageStruct> sendMemory = new List<MessageStruct>();


    private void PushReceDataScene(MessageStruct message)
    {
        recDataScene.Enqueue(message);
    }
    private void PushReceDataQueue(MessageStruct message)
    {
        recDataQueue.Enqueue(message);
    }

    public void PushYetReceData(MessageStruct message)
    {
        if (IsOftenData(message))
        {
            PushReceDataScene(message);
        }
        else
        {
            PushReceDataQueue(message);
        }
    }
    public void PushWillSendData(MessageStruct message)
    {
        sendMemory.Add(message);
    }

    public void clearData()
    {
        recDataQueue.Clear();
        recDataScene.Clear();
        sendMemory.Clear();
    }

    public MessageStruct getYetReceData()
    {
        if (recDataQueue.Count > 0)
        {
            return recDataQueue.Dequeue();
        }

        //没有消息过来，MessageStruct的dest为NETACCEPTED
        return new MessageStruct();
    }

    public MessageStruct getWillSendData()
    {
        int count = sendMemory.Count;

        if (count == 0) return null;

        MessageStruct msg = sendMemory[0];

        sendMemory.RemoveAt(0);

        return msg;

    }

    //判断是否场景上频繁接受到的协议
    private bool IsOftenData(MessageStruct message)
    {
        if (message.dest == 7)
        {
            if (message.cmd == 4 || message.cmd == 5 || message.cmd == 6 || message.cmd == 7 || message.cmd == 8 || message.cmd == 11) return true;
        }
        return false;
    }

    //清除数据
    public void ClearDataScene()
    {
        recDataScene.Clear();
    }
    public void clearDataQueue()
    {
        recDataQueue.Clear();
    }
    public void ClearSendData()
    {
        sendMemory.Clear();
    }


}
