
using ArcgisWebDAL;
using ArcgisWebModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArcgisWebBLL
{
    public class MapsBLL
    {
        // 根据 address 查询经纬度
        public Maps GetMapsByAdress(string address)
        {
            MapsDAL mapsDAL = new MapsDAL();
            return mapsDAL.GetMapsByAdress(address);
        }

        public bool AddMaps(Maps maps)
        {
            throw new NotImplementedException();
        }
    }
}
