using ArcgisWebModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArcgisWebDAL
{
    public class MapsDAL
    {
        // 根据 address 查询经纬度
        public Maps  GetMapsByAdress(string address) //比如：address="上海海洋大学"
        {
            // select * from maps where address='address'

            string connStr = "server=localhost;database=map;user id=root;password=123456;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();    //打开数据库连接

            string sql = " select * from maps where address='" + address + "'";     //select * from maps where address='上海海洋大学'
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader= comm.ExecuteReader();   //获得读取数据库中表的 指针

            if (reader.HasRows)     //判断是否查询到了数据（执行   select * from maps where address='上海海洋大学'   这条语句后是否查询到了数据）
            {
                //查询到了数据
                reader.Read();  //将指针读取下一行

                Maps map = new Maps();               
                map.address = reader["address"].ToString();                   //读取查询出的结果的第一列
                map.longitude = reader["longitude"].ToString();               //读取查询出的结果的第二列
                map.latitude = reader["latitude"].ToString();                 //读取查询出的结果的第三列
                map.elevationvalue = reader["elevationvalue"].ToString();     //读取查询出的结果的第四列;
                //现在已将查询到的一行数据用类Maps的对象map保存了
                return map; //返回map
            }
            else
            {
                //没有查询到数据
                return null;    //返回空
            }
        }


    }
}
