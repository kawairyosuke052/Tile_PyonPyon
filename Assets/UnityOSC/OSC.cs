using UnityEngine;
using UnityOSC;

public class OSC : MonoBehaviour
{
    private Vector2 pos;
    
    public OSCReciever r;

    public int port = 7000;
    
    public static Vector2 GetPosition()
    {
        OSC osc = FindFirstObjectByType<OSC>();
        if (osc != null)
        {
            return osc.pos;
        }
        return Vector2.zero;
    }
    
    void Start()
    {
        r = new OSCReciever();
        r.Open(port);
    }

    void Update()
    {
        if(r.hasWaitingMessages())
        {
            OSCMessage msg = r.getNextMessage();
            
            if (msg.Address == "/object")
            {
                pos = new Vector2(float.Parse(msg.Data[1].ToString()), float.Parse(msg.Data[2].ToString()));
            }
        }
    }
}