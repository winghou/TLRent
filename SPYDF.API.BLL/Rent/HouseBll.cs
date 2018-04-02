using SPYDF.Core.RentService;
using SPYDF.Core.RentService.Impl;
using SPYDF.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.API.BLL.Rent
{
    [Export]
    public class HouseBll
    {
        #region Service
        [Import]
        public IHouseService HouseService { get; set; }
        #endregion

        #region 方法
        //public List<HouseView> Get()
        //{

        //}

        #endregion
    }
}
