<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyAspwork.WebPage.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <script language="javascript" src="../Scripts/check.js" type="text/javascript">
// <![CDATA[


        function Submit1_onclick() {
            var name = document.all("username").value;
            if (name=="") {
                // alert("请输入用户名！");
                document.all("passLab").value = "用户名不能为空awedf！";
                return false;
            }
        }

// ]]>
    </script>
    <style type="text/css">
        #Text2 {
            margin-left: 1px;
        }
    </style>
</head>
<body>
    
    

    <form id="form1" runat="server">
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 用户名: <asp:TextBox ID="username" runat="server"></asp:TextBox>
    <asp:Label ID="userLab" runat="server" ForeColor="Red"></asp:Label>
    <p>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;密&nbsp; 码:&nbsp;&nbsp; 
        <asp:TextBox ID="password" runat="server" TextMode="Password" ></asp:TextBox>
        <asp:Label ID="passLab" runat="server" ForeColor="Red"></asp:Label>
    </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
        ID="errorLab" runat="server" ForeColor="Red"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="menberbox" runat="server" 
        Text="记住用户名" />
    <asp:Button 
        ID="surebtm" runat="server" Text="登陆"   OnClientClick="return Submit1_onclick() " 
        onclick="surebtm_Click" />
    &nbsp; <asp:Button ID="exitbtn" runat="server" Text="取消" onclick="exitbtn_Click" />
    &nbsp;&nbsp;
    </form>
 
    
</body>
</html>
