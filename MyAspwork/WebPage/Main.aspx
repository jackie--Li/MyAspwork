<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="MyAspwork.WebPage.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <style type="text/css">
        .ullicss {height:30px;background:green;}
        .ullicss ul{list-style:none;}
        .ullicss li{float:left; width:100px; margin-left:3px; line-height:30px;}
        .ullicss a:link   {color:pink; font-weight:bold; text-decoration:none; background:green;}
        .ullicss a:visited{color:pink; font-weight:bold; text-decoration:none; background:green;}
        .ullicss a:hover  {color:green; font-weight:bold; text-decoration:none; background:yellow;}
        .ullicss a  {display:block; text-align:center; height:30px;}
     .style1
     {
         width: 100%;
     }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="title" style="width:auto;height:80px;background-color:red;text-align:center;line-height:80px" >
 
         <marquee><h1>欢迎来到东东干货店<h1></marquee>
   
    </div>
    <br>

    <div class="ullicss">
        <ul>
            <li><a target="_blank" href="http://www.baidu.com">菜单例一</a></li>
            <li><a target="_blank" href="http://www.google.com">菜单例二</a></li>
            <li><a target="_blank" href="http://www.bing.com">菜单例三</a></li>
            <li><a target="_blank" href="http://www.jike.com">菜单例四</a></li>
            <li><a target="_blank" href="http://www.soso.com">菜单例五</a></li>
            <li><a target="_blank" href="http://www.youdao.com">菜单例六</a></li>
           
        </ul>
    </div>
    </form>
</body>
</html>
