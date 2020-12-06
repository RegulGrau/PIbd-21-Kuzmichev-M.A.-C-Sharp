using System.Collections.Generic;
using System.Linq;
namespace FormTyeplovoz
{
	class DepotCollection
	{
        readonly Dictionary<string, Depot<Locomotive>> depotStages;
        public List<string> Keys => depotStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
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
    }
}
