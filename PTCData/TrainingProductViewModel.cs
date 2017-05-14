using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData
{
    public class TrainingProductViewModel
    {
        public TrainingProductViewModel()
        {
            Init();
            SearchEntity = new TrainingProduct();
            Products = new List<TrainingProduct>();
            Entity = new TrainingProduct();
        }

        public TrainingProduct SearchEntity { get; set; }
        public TrainingProduct Entity { get; set; }
        public bool IsValid { get; set; }
        public List<TrainingProduct> Products { get; set; }
        public string EventCommand { get; set; }
        public string Mode { get; set; }

        public bool IsDetailAreaVisible { get; set; }
        public bool IsListAreaVisible { get; set; }
        public bool IsSearchAreaVisible { get; set; }

        public void Init()
        {
            EventCommand = "List";
            ListMode();
        }


        public void HandleEvent()
        {
            switch (EventCommand.ToLower())
            {
               
                case "list":
                case "search":
                    Get();
                    break;
                case "save":
                    Save();
                    if (IsValid)
                    {
                        Get();
                    }
                    break;
                case "cancel":
                    ListMode();
                    Get(); 
                    break;
                case "reset":
                    ResetSearch();
                    Get();
                    break;
                case "add":
                    AddProduct();
                    break;
                default:
                    break;
                        
            }
        }

        private void Save()
        {
            if (IsValid)
            {
                if(Mode == "Add")
                {
                    //Add data
                }
            }
            else
            {
                if(Mode == "Add")
                {
                    AddMode();
                }
            }
        }
        private void ListMode()
        {
            IsListAreaVisible = true;
            IsSearchAreaVisible = true;
            IsDetailAreaVisible = false;

            IsValid = true;
            Mode = "List";
        }

        public void AddProduct()
        {
            IsValid = true;
            Entity = new TrainingProduct();
            Entity.Price = 0;
            Entity.IntroductionDate = DateTime.Now;
            Entity.Url = "http://";

            AddMode();
        }
        public void AddMode()
        {
            IsListAreaVisible = false;
            IsSearchAreaVisible = false;
            IsDetailAreaVisible = true;

            Mode = "Add";
        }
        private void ResetSearch()
        {
            SearchEntity = new TrainingProduct();
        }
        private void Get()
        {
            TrainingProductManager manager = new TrainingProductManager();
            Products = manager.Get(SearchEntity);
        }
    }
}
