using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Model.ViewModel
{
   public class RentImgView
    {
        public int ImgId { get; set; }
        public Nullable<int> RoomId { get; set; }
        public Nullable<int> HouseId { get; set; }
        public string Path { get; set; }
        public string Remark { get; set; }
    }
}
