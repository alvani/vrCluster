using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppRunner
{
    class ConfigSerializer
    {
        public struct ClusterNode
        {
            public string id;
            public string addr;
        }

        public List<ClusterNode> clusterNodes = new List<ClusterNode>();
            
        public void Load(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var cols = line.Split(' ');
                if (cols.Length > 0)
                {
                    if (cols[0] == "[cluster_node]")
                    {
                        ParseClusterNode(cols);
                    }
                }                
            }
        }

        void ParseClusterNode(string[] cols)
        {
            var cn = new ClusterNode();

            foreach (var col in cols)
            {
                var entry = col.Split('=');
                if (entry.Length == 2)
                {
                    if (entry[0] == "id")
                    {
                        cn.id = entry[1];
                    }
                    else if (entry[0] == "addr")
                    {
                        cn.addr = entry[1];
                    }
                }
            }

            clusterNodes.Add(cn);
        }
    }
}
