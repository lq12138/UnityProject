using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;

public class jsontest : MonoBehaviour
{
    List<People> peopleGroup = new List<People>();
    private void Awake()
    {

        string dataJson = File.ReadAllText(Application.dataPath + "/Resources/Test.json", Encoding.GetEncoding("utf-8"));
        JObject obj = JObject.Parse(dataJson);
        JObject classdata = JObject.Parse(obj["Classdata"].ToString());
        JArray ja = (JArray)classdata["people"];
        for (int i = 0; i < ja.Count; i++)
        {
            People json = JsonConvert.DeserializeObject<People>(ja[i].ToString());
            
            peopleGroup.Add(json);
        }
        foreach (var item in peopleGroup)
        {
            Debug.Log(string.Format("ID：{0} 姓名：{1} 年龄：{2}", item.id, item.name, item.age));
        }
    }
}
class People
{
    //public int id;
    //public string name;
    //public int age;


    public int id { get; set; }
    public string name { get; set; }
    public int age { get; set; }
}