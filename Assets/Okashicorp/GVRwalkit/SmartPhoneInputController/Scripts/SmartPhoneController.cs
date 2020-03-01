using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Net;
using System.Linq;

public class SmartPhoneController : MonoBehaviour {
	static public string WebUrl { get { return webUrl; } }

	MonoContentWebServer webServer;
	List<WebSocketServer> wsList;
	static string webUrl;
	static int webPort = 9999;
	static int wsPort = 9998;

	// Use this for initialization
	void Start () {
		wsList = new List<WebSocketServer>();
		var ip = GetIP();
		webUrl = "http://" + ip + ":" + webPort;
		var wsUrl = "ws://"+ ip + ":" + wsPort;
		var ws = new WebSocketServer(wsUrl);
		ws.AddWebSocketService<SmartPhoneInput>("/p1");
		ws.Start();
		wsList.Add(ws);
		Debug.Log("WS Start: " + wsUrl);

		webServer = new MonoContentWebServer(webPort, loadHTML(wsUrl));
	}

	string loadHTML(string wsUrl) {
		var html = (Resources.Load("SmartPhoneInputController/ws") as TextAsset).text;
		return html.Replace("WEBSOCKET_BASE", wsUrl);
	}

	void OnDestroy() {
		Debug.Log ("OnDestroy");
		if (webServer != null) {
			webServer.stop();
		}
		if (wsList != null) {
			foreach (var ws in wsList) {
				ws.Stop();
			}
		}
	}

	string GetIP() 
    {
        string ipaddress = "";
        IPHostEntry ipentry = Dns.GetHostEntry(Dns.GetHostName());

        foreach (IPAddress ip in ipentry.AddressList)
        {
            if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                ipaddress = ip.ToString();
                Debug.Log("getIPv4=" + ip.ToString());
                break;
            }
        }
        return ipaddress;
    }
}

public class SmartPhoneInput : WebSocketService {
	// x, y: from about -50 to 50
	static public float PadX { get { return Mathf.Clamp(x / 50f, -1, 1); }}
	static public float PadY { get { return Mathf.Clamp(y / -50f, -1, 1); }}
	// ax, ay, az: from about -100 to 100
	static public float PadGradX { get { return Mathf.Clamp(ax / 100f, -1, 1); }}
	static public float PadGradY { get { return Mathf.Clamp(ay / -100f, -1, 1); }}
	static public float PadGradZ { get { return Mathf.Clamp(az / 100f, -1, 1); }}


	static int x, y, ax, ay ,az;

	protected override void OnMessage(MessageEventArgs e) {
		var values = e.Data.Split (',');
		if (values.Length == 5) {
			int.TryParse(values[0], out x);
			int.TryParse(values[1], out y);
			int.TryParse(values[2], out ax);
			int.TryParse(values[3], out ay);
			int.TryParse(values[4], out az);
		}
	}

	static int connectCount = 0;

	static public bool IsConnected() {
		return connectCount > 0;
	}
	protected override void OnOpen() {
		Debug.Log ("connected");
		connectCount++;
	}

	protected override void OnClose(CloseEventArgs e) {
		Debug.Log ("disconnected");
		connectCount--;
	}
}
