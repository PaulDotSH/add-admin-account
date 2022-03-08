using System.Diagnostics;

const string Username = "Admin";

const string Password = "TestPw123$%";

void AddUser(string username, string password)
{
    Process cmd = new Process();
    cmd.StartInfo.FileName = "cmd.exe";
    cmd.StartInfo.ArgumentList.Add("net");
    cmd.StartInfo.ArgumentList.Add("user");
    cmd.StartInfo.ArgumentList.Add(username);
    cmd.StartInfo.ArgumentList.Add(password);
    cmd.StartInfo.ArgumentList.Add("/add");
}

void MakeUserAdmin(string username)
{
    Process cmd = new Process();
    cmd.StartInfo.FileName = "cmd.exe";
    cmd.StartInfo.ArgumentList.Add("net");
    cmd.StartInfo.ArgumentList.Add("localgroup");
    cmd.StartInfo.ArgumentList.Add("administrators");
    cmd.StartInfo.ArgumentList.Add(username);
    cmd.StartInfo.ArgumentList.Add("/add");
}

AddUser(Username,Password);
MakeUserAdmin(Password);