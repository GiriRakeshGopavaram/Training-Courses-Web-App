using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData
{
    public class TrainingProductManager
    {
        public List<TrainingProduct> Get(TrainingProduct entity)
        {
            //entity = new TrainingProduct(); 
            List<TrainingProduct> ret = new List<TrainingProduct>();
            ret = CreateMockData();
            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                ret = ret.FindAll(p => p.ProductName.ToLower().StartsWith(entity.ProductName, StringComparison.CurrentCultureIgnoreCase));

            }
            return ret;
        }
        private List<TrainingProduct> CreateMockData()
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();
            ret.Add(new TrainingProduct()
            {
                ProductId = 1,
                ProductName = "Building RESTful API's",
                IntroductionDate = Convert.ToDateTime("05/14/2017"),
                Price = Convert.ToDecimal(29.0),
                Url = "https://goo.gl/wLPDB9"
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 2,
                ProductName = "API Design",
                IntroductionDate = Convert.ToDateTime("05/14/2017"),
                Price = Convert.ToDecimal(29.0),
                Url = "https://goo.gl/wLPDB9"
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 3,
                ProductName = "ASP.Net by Scott Allen",
                IntroductionDate = Convert.ToDateTime("05/14/2017"),
                Price = Convert.ToDecimal(29.0),
                Url = "https://goo.gl/wLPDB9"
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 4,
                ProductName = "Ionic Framework by Shaun Waldermuth",
                IntroductionDate = Convert.ToDateTime("05/14/2017"),
                Price = Convert.ToDecimal(29.0),
                Url = "https://goo.gl/wLPDB9"
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 5,
                ProductName = "Swift Fundamentals",
                IntroductionDate = Convert.ToDateTime("05/14/2017"),
                Price = Convert.ToDecimal(29.0),
                Url = "https://goo.gl/wLPDB9"
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 6,
                ProductName = "Building RESTful API's",
                IntroductionDate = Convert.ToDateTime("05/14/2017"),
                Price = Convert.ToDecimal(29.0),
                Url = "https://goo.gl/wLPDB9"
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 7,
                ProductName = "Building RESTful API's",
                IntroductionDate = Convert.ToDateTime("05/14/2017"),
                Price = Convert.ToDecimal(29.0),
                Url = "https://goo.gl/wLPDB9"
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 8,
                ProductName = "Building RESTful API's",
                IntroductionDate = Convert.ToDateTime("05/14/2017"),
                Price = Convert.ToDecimal(29.0),
                Url = "https://goo.gl/wLPDB9"
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 9,
                ProductName = "Building RESTful API's",
                IntroductionDate = Convert.ToDateTime("05/14/2017"),
                Price = Convert.ToDecimal(29.0),
                Url = "https://goo.gl/wLPDB9"
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 10,
                ProductName = "Building RESTful API's",
                IntroductionDate = Convert.ToDateTime("05/14/2017"),
                Price = Convert.ToDecimal(29.0),
                Url = "https://goo.gl/wLPDB9"
            });
            return ret;

        }
    }
}
