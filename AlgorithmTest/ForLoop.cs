using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    public class ForLoop
    {
        public void First_Test(List<Plan> inputs)
        {
            for (int i = 0; i <= inputs.Count; i++)
            {
                for (int j = 0; j <= inputs[i].Features.Count; i++)
                {

                }
            }
        }

        public void Second_Test(List<Plan> inputs)
        {
            foreach(var i in inputs)
            {
                foreach (var j in i.Features)
                {

                }
            }
        }

        public void Third_Test(List<Plan> inputs)
        {
            
        }
    }

    public class Plan
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Feature> Features { get; set; }
    }

    public class Feature
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int BenefitId { get; set; }
    }
}
