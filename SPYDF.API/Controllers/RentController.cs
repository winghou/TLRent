using SPYDF.Model.InputModel;
using SPYDF.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPYDF.API.Controllers
{
    public class RentController : ApiController
    {

        /// <summary>
        /// 分页获取房间数据
        /// </summary>
        /// <param name="model">查询条件</param>
        /// <returns></returns>
        // POST: Rent/GetRoomList
        [HttpPost]
        public List<RoomView> GetRoomList(PageFind<RoomFindInput> model)
        {
            List<RoomView> re = new List<RoomView>();
            RoomView m = new RoomView()
            {
                Name = "漂亮大房子",
                Price = 1800,
                RoomType = "豪宅",
                Acreage=80,
                Status= "待租",
                IsAir=1,
                IsHeater=1,
                IsBay=1,
                IsBalcony=1,
                LiveNum=2,
            };
            List<RentImgView> imgList = new List<RentImgView>();
            RentImgView img = new RentImgView()
            {
                Path="~/Images/a.png",
                ImgId=1,
            };
            imgList.Add(img);
            m.ImgList = imgList;
            re.Add(m);
            return re;
        }
    }
}
