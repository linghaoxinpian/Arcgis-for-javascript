using ArcgisWebBLL;
using ArcgisWebModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArcgisWebUI
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            MapsBLL mapsBLL = new MapsBLL();
            Maps map = mapsBLL.GetMapsByAdress(txtAddress.Text);
            if (map == null)
            {
                Response.Write("<script>alert('改点尚未被记录');</script>");
                return;
            }
            TextBox1.Text = map.latitude;
            TextBox2.Text = map.longitude;
            TextBox3.Text = map.elevationvalue;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            MapsBLL mapsBLL = new MapsBLL();
            //获取输入的地点的各项值
            Maps maps = new Maps();
            maps.address = TextBox4.Text;
            maps.longitude = TextBox5.Text;
            maps.latitude = TextBox6.Text;
            maps.elevationvalue = TextBox7.Text;
            //向数据库中添加一条记录
            if (mapsBLL.AddMaps(maps))
            {
                Response.Write("<script>alert('添加成功！！');</script>");
            }else
            {
                Response.Write("<script>alert('添加失败！请重试');</script>");
            }
        }
    }
}