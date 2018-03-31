using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Model.ViewModel
{
   public class HouseView
    {
        public int HouseID { get; set; }
        public string Name { get; set; }
        public int ResourceType { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public Nullable<int> IsJoint { get; set; }
        public Nullable<int> HouseType { get; set; }
        public Nullable<int> HouseFloor { get; set; }
        public string LinkPhone { get; set; }
        public Nullable<int> TotalFloor { get; set; }

        public List<RentImgView> ImgList { get; set; }
    }
}
