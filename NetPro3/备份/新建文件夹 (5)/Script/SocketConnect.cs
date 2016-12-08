using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

public class SocketConnect 
{
	private Socket socket=null;
	private string host;
	private int port;
	private bool isDisposed;
	private const int TimeOut = 30;//30秒的超时时间

	enum ErrorCode
	{
		eSuccess = 0,
		eConnectError = -1,
		eTimeOutError = -2,
	}
    public SocketConnect()
    {
        
    }
	//传ip地址与端口
	public SocketConnect(string host, int port)
	{
		this.host = host;
		this.port = port;
	}
	//更新ip地址
	public void setHost(string _host)
	{
		this.host=_host;
	}
	//更新端口
	public void setPort(int port)
	{
		this.port = port;
	}

	/// <summary>
	/// 打开连接
	/// </summary>
	public bool Open()
	{
		UnityEngine.NetworkReachability state = UnityEngine.Application.internetReachability;
		if (state != UnityEngine.NetworkReachability.NotReachable)
		{
            Close();
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				socket.Connect(host, port);
			}
			catch
			{
				socket = null;
				return false;
			}
		}
		return true;
	}
	/// <summary>
	/// 关闭连接
	/// </summary>
	public void Close()
	{
		if (socket == null) return;
		try
		{
			socket.Shutdown(SocketShutdown.Both);
			socket.Close();
			socket = null;
		}
		catch (Exception ex)
		{
            Debug.LogError(ex.ToString());
			socket = null;
		}
	}
	private void EnsureConnected()
	{
		if (socket == null)
		{
			Open();
		}
	}
	/// <summary>
	/// 发送数据
	/// </summary>
	/// <param name="data"></param>
	public bool Send(byte[] _data)
	{
        ///////////////////////////////////////////////////////////////////////////////////////
        int _messagelen = _data.Length;
        int _sendLeght = 4 + _messagelen;
        byte[] _sendData = new byte[_sendLeght];
        _sendData[0] = (byte)((_messagelen & 0xff000000) >> 24);
        _sendData[1] = (byte)((_messagelen & 0x00ff0000) >> 16);
        _sendData[2] = (byte)((_messagelen & 0x0000ff00) >> 8);
        _sendData[3] = (byte)(_messagelen & 0x000000ff);
        for (int i = 4; i < _sendLeght; i++)
        {
            _sendData[i] = _data[i - 4];
        }
        /////////////////////////////////////////////////////////////////////////////////////////

        //
		if (socket != null)
		{
            int len = _sendData.Length;
            int sendcount = 0;
            while (sendcount < len)
            {
                int ret = socket.Send(_sendData, sendcount, len - sendcount, SocketFlags.None);
                if (ret == 0)
                {
                    return false;
                }
                sendcount += ret;
                if (sendcount < len) Debug.LogError("一次发不完！");
            }
		}
		return true;
	}

    //
    public bool Rece(ref byte[] d,ref int l)
    {
        //默认接受数据数组长度，暂定这个长度，具体长度后面再修改。
        int defaultLen = 1024 * 64;
        int allLen = defaultLen;
        byte[] data = new byte[allLen];
        bool changeSize = false;

        try
        {
            if (socket.Poll(5, SelectMode.SelectRead))
            {
                if (socket.Available == 0)
                {
                    UnityEngine.Debug.Log("Close Socket");

                    Close();

                    return false;
                }

                byte[] prefix = new byte[4];
                int recnum = socket.Receive(prefix);

                if (recnum == 4)
                {
                    int datalen = (int)(prefix[0]) << 24 | (int)(prefix[1]) << 16 | (int)(prefix[2]) << 8 | (int)(prefix[3]);
                    //重设数组大小。
                    if (datalen > allLen)
                    {
                        allLen = datalen;
                        data = new byte[allLen];
                        changeSize = true;
                    }
                    else
                    {
                        if (changeSize && defaultLen >= datalen)
                        {
                            allLen = defaultLen;
                            data = new byte[allLen];
                            changeSize = false;
                        }
                    }
                    int startIndex = 0;
                    recnum = 0;

                    do
                    {
                        int rev = socket.Receive(data, startIndex, datalen - recnum, SocketFlags.None);
                        recnum += rev;
                        startIndex += rev;
                    }
                    while (recnum != datalen);//会不会有问题呢？

                    d = data;
                    l = datalen;

                    return true;
                }
            }
            else if (socket.Poll(5, SelectMode.SelectError))
            {
                Close();

                UnityEngine.Debug.Log("SelectError Close Socket");

                return false;
            }
        }
        catch (Exception ex)
        {
            UnityEngine.Debug.Log("catch" + ex.ToString());

            return false;
        }

        return false;
    }

    public bool isSocketNull()
    {
        if (socket == null) return true;

        return false;
    }

}
