using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;
public class jsonstudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string jsondata = File.ReadAllText(Application.dataPath + "/Resources/objectTest.json");
        JObject objData = JObject.Parse(jsondata);
        foreach (var item in objData)
        {
            Debug.Log(item.Key);
            Debug.Log(item.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
