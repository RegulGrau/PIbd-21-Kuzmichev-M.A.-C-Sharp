using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace FormTyeplovoz
{
	class DepotCollection
	{
        readonly Dictionary<string, Depot<Locomotive>> depotStages;
        public List<string> Keys => depotStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly char separator = ':';
        private readonly char separator2 = ';';
        public DepotCollection(int pictureWidth, int pictureHeight)
        {
            depotStages = new Dictionary<string, Depot<Locomotive>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddDepot(string name)
        {
            if (depotStages.ContainsKey(name))
            {
                return;
            }
            depotStages.Add(name, new Depot<Locomotive>(pictureWidth, pictureHeight));
        }
        public void DelDepot(string name)
        {
            if (depotStages.ContainsKey(name))
            {
                depotStages.Remove(name);
            }
        }
        public Depot<Locomotive> this[string ind]
        {
            get
            {
                return depotStages[ind];
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                StreamWriter streamWriter = new StreamWriter(fs, new UTF8Encoding(true));
                streamWriter.Write($"DepotCollection{Environment.NewLine}", fs);
                foreach (var level in depotStages)
                {
                    streamWriter.Write($"Depot{separator}{level.Key}{Environment.NewLine}", fs);
                    ILocomotive train = null;
                    for (int i = 0; (train = level.Value.GetNext(i)) != null; i++)
                    {
                        if (train != null)
                        { 
                            if (train.GetType().Name == "Locomotive")
                            {
                                streamWriter.Write($"Locomotive{separator}", fs);
                            }
                            if (train.GetType().Name == "Tyeplovoz")
                            {
                                streamWriter.Write($"Tyeplovoz{separator}", fs);
                            }
                            streamWriter.Write(train + Environment.NewLine, fs);
                        }
                    }
                }
                streamWriter.Close();
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            StreamReader streamReader = new StreamReader(filename, new UTF8Encoding(true));
            string bufferTextFromFile = "";

            bufferTextFromFile = streamReader.ReadLine();
            if (bufferTextFromFile.Contains("DepotCollection"))
            {
                depotStages.Clear();
            }
            else
            {
                return false;
            }
            Locomotive train = null;
            string key = string.Empty;
            while((bufferTextFromFile = streamReader.ReadLine()) !=null)
            {
                if (bufferTextFromFile.Contains("Depot"))
                {
                    key = bufferTextFromFile.Split(separator)[1];
                    depotStages.Add(key, new Depot<Locomotive>(pictureWidth,
                    pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(bufferTextFromFile))
                {
                    continue;
                }
                if (bufferTextFromFile.Split(separator)[0] == "Locomotive")
                {
                    train = new Locomotive(bufferTextFromFile.Split(separator)[1]);
                }
                else if (bufferTextFromFile.Split(separator)[0] == "Tyeplovoz")
                {
                    train = new Tyeplovoz(bufferTextFromFile.Split(separator)[1]);
                }
                var result = depotStages[key] + train;
                if (!result)
                {
                    streamReader.Close();
                    return false;
                }
            }
            streamReader.Close();
            return true;
        }

       
    }
}
