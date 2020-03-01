using UnityEngine;
using System.Collections;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class MonoContentWebServer {
	private bool mRunning;
	Thread mThread;
	TcpListener tcpListener = null;

	int port;
	string content;

	public MonoContentWebServer(int port, string content) {
		this.port = port;
		this.content = content;
		mRunning = true;
		ThreadStart ts = new ThreadStart(Main);
		mThread = new Thread(ts);
		mThread.Start();
	}
	
	public void stop() {
		mRunning = false;
		mThread.Join(500);
		Debug.Log("Server Stopped");
	}
	
	void Main() {
		tcpListener = new TcpListener(IPAddress.Any, port);
		tcpListener.Start();
		Debug.Log("TcpServer Started: port = " + port);
		while (mRunning)
		{
			//check if new connections are pending, if not, be nice and sleep 100ms
			if (!tcpListener.Pending()){
				Thread.Sleep(100);
			}
			else {
				Socket ss = tcpListener.AcceptSocket();
				ss.Send(getContent());
				ss.Close();
			}
		}
	}

	private byte[] getContent() {
		var contentBytes = Encoding.UTF8.GetBytes(content);
		string[] headers = new string[] {
			"HTTP/1.1 200 OK", 
		    "Content-Type: text/html; charset=utf-8",
			"Content-Length: " + contentBytes.Length
		};
		var response = Encoding.UTF8.GetBytes(string.Join("\n", headers) + "\n\n" + content);
		return response;
	}
}