function checkdata() {
    var name = document.all("username").value;
    var password = document.all("password").value;
    if (name == "" || password == "") {
        alert("用户名或密码不能为空！");
       
       return false;
    }
    return true;
}
function Test() {
        alert("用户名或密码不能为空！");
  
}