using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Model.ViewModel
{
   public class RentImgView
    {
        /// <summary>
        /// 图片ID
        /// </summary>
        public int ImgId { get; set; }
        /// <summary>
        /// 房间ID
        /// </summary>
        public Nullable<int> RoomId { get; set; }
        /// <summary>
        /// 房ID
        /// </summary>
        public Nullable<int> HouseId { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
