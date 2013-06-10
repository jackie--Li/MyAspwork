using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;
using MyAspwork.Sqlconnection;
using MyAspwork.Model;

namespace MyAspwork.WebPage
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (Request.Cookies["user"] != null)
            {
                username.Text = Request.Cookies["user"].Value;
                menberbox.Checked = true;
            }
            else
            {
                username.Text = "";
            }
            

            
        }

        protected void surebtm_Click(object sender, EventArgs e)
        {
            string name = Request["username"];
            string password = Request["password"];
            PersonEntity person = new PersonEntity();
            person.Password = password;
            person.Username = name;
            Didsqlconntion sql = new Didsqlconntion();
            if (name == "")
            {
                userLab.Text = "用户名不能为空！";
            }
           
                if (sql.getperson(person))
                {
                    
                    // Response.Cookies.Add(cookie);
                    if (menberbox.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("user", name);
                        cookie.Expires = DateTime.MaxValue;//设置Cookie 永不过期
                        Response.Cookies.Add(cookie);
                       
                    }
                    Server.Transfer("Main.aspx");
                }
                else
                {
                    errorLab.Text = "用户名或密码错误！";

                }
            }

        protected void exitbtn_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
            errorLab.Text = "";
            menberbox.Checked = false;
        }
          

        }

      

      
    }
