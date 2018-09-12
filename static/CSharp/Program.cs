using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CSharp {
    internal class DataModel {
        public string image {set; get;}

        public string audio {set; get;}

        public string text {set; get;} 
    }
    class Program {
        static void Main(string[] args) {

            string path = @"D:\svnbox\SocialStory\content\post\";
            string content =  
                "+++\\n" + 
                "draft = false \\n" + 
                "image = \"/images/story$index$_c_t.png\" \\n" + 
                "showonlyimage = true \\n" + 
                "title = \"第$index$課\" \\n" + 
                "weight = $index$ \\n" + 
                "path = \"/data/story$index$.json\" \\n" + 
                "+++"; 

            for (int i = 1; i <= 100; i++) {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path + "story" + i + ".md")) {
                    file.WriteLine(content.Replace("$index$", i.ToString()).Replace("\\n", System.Environment.NewLine)); 
                }
            }
             /*
            DataModel model = null;
            List<DataModel> models = new List<DataModel>();
            string lastRecord = "";
            string fileName = "";


            string jsonPath = @"D:\svnbox\SocialStory\data\";
            string pathToFolder = @"D:\svnbox\SocialStory\static\images\";
            foreach (string readFile in Directory.EnumerateFiles(pathToFolder, "*", SearchOption.AllDirectories)) {
                fileName = readFile.Replace(pathToFolder, "");
                fileName = fileName.Substring(0, fileName.IndexOf("_"));

                //Console.WriteLine(fileName);
                model = new DataModel();
                model.image = "/images/" + readFile.Replace(pathToFolder, "");
                model.audio = "/audios/" + readFile.Replace(pathToFolder, "").Replace("t.png", "m.mp3");
                model.text = "";

                if (!lastRecord.Equals(fileName) && models.Count > 0) {
                    // Console.Write(lastRecord);
                    // Console.Write(JsonConvert.SerializeObject(models));
                    
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(jsonPath + lastRecord + ".json")) {
                        file.WriteLine(JsonConvert.SerializeObject(models).Replace("},{", "}," + System.Environment.NewLine + "{")); 
                    }
                    
                    models = new List<DataModel>();
                }

                models.Add(model);
                lastRecord = fileName;
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(jsonPath + lastRecord + ".json")) {
                file.WriteLine(JsonConvert.SerializeObject(models).Replace("},{", "}," + System.Environment.NewLine + "{")); 
            }
              */
        } 
    }
}
